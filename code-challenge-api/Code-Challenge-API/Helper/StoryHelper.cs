using Code_Challenge_API.Model;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http;
using System.Text.Json;

namespace Code_Challenge_API.Helper
{
    public class StoryHelper : IStoryHelper
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _memoryCache;

        public StoryHelper(HttpClient httpClient, IMemoryCache memoryCache)
        {
            _httpClient = httpClient;
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// Name: FetchStories
        /// </summary>
        /// <returns>List of top new stories with details </returns>
        public async Task<List<Story>> FetchStories(string? searchStory)
        {
            var stories = new List<Story>();

            try
            {
                var key = "storyKey";

                if (!_memoryCache.TryGetValue(key, out stories))
                {

                    var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                    var allURL = config.GetValue<string>("BaseURL") + config.GetValue<string>("Version") + "/topstories.json?print=pretty";

                    var response = await _httpClient.GetAsync(allURL);

                    var allStories = await response.Content.ReadAsStringAsync();

                    var allStoriesNumberArray = JsonSerializer.Deserialize<int[]>(allStories);

                    allStoriesNumberArray = allStoriesNumberArray?.OrderByDescending(x => x).ToArray();

                    stories = new List<Story>();

                    for (int i = 0; i < 200; i++)
                    {
                        var storyURL = config.GetValue<string>("BaseURL") + config.GetValue<string>("Version") + "/item/" + allStoriesNumberArray[i] + ".json?print=pretty";
                        var storyResponse = await _httpClient.GetAsync(storyURL);

                        var storyResponseObject = await storyResponse.Content.ReadAsStringAsync();

                        var storyModel = JsonSerializer.Deserialize<Story>(storyResponseObject);

                        if (storyModel != null)
                        {
                            stories.Add(storyModel);
                        }
                    }

                    var cacheExpiryOptions = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = DateTime.Now.AddDays(3),
                        Priority = CacheItemPriority.High,
                    };

                    _memoryCache.Set(key, stories, cacheExpiryOptions);
                }


                if (!string.IsNullOrEmpty(searchStory))
                {
                    stories = stories.Where(f => f.title.ToLower().Contains(searchStory.ToLower())).ToList();
                }

                return stories;
            }
            catch (Exception ex)
            {
                return stories;
            }
        }

    }
}
