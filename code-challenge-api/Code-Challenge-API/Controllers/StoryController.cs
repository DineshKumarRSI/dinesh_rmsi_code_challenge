using Microsoft.AspNetCore.Mvc;
using Code_Challenge_API.Helper;
using Code_Challenge_API.Model;

namespace code_challenge_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {

        private readonly IStoryHelper _storyHelper;

        public StoryController(IStoryHelper storyHelper)
        {
            _storyHelper = storyHelper;
        }

        /// <summary>
        /// Name: GetStories
        /// </summary>
        /// <param name="searchStory"> Search text </param>
        /// <returns>List of top new stories with details </returns>
        [HttpGet(Name = "GetStories")]
        public async Task<List<Story>> GetStories(string? searchStory)
        {
            var stories = await _storyHelper.FetchStories(searchStory);

            return stories;
        }

     
    }
}
