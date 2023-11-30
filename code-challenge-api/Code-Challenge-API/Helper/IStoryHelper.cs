using Code_Challenge_API.Model;

namespace Code_Challenge_API.Helper
{
    public interface IStoryHelper
    {
        public Task<List<Story>> FetchStories(string? searchStories);
    }
}
