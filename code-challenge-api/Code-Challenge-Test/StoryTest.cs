using code_challenge_api.Controllers;
using Code_Challenge_API.Helper;
using Code_Challenge_API.Model;
using Code_Challenge_Test.Data;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework.Internal;

namespace Code_Challenge_Test
{
    public class StoryTest
    {
        private Mock<IStoryHelper> _storyHelper;
        private Mock<IMemoryCache> _memoryCache ;

        [SetUp]
        public void Setup()
        {

            _storyHelper = new Mock<IStoryHelper>();

            _storyHelper.Setup(s => s.FetchStories(It.IsAny<string>())).ReturnsAsync(StoryData.GetStories());

            _memoryCache = new Mock<IMemoryCache>();

        }

        [Test]
        public async Task StoryInitialization_FetchStories_ShouldReturnRecord()
        {
            var expected = new List<Story>();
            expected = StoryData.GetStories();
            
            var actual =  await _storyHelper.Object.FetchStories(null);
            
            Assert.IsTrue((actual.Count > 0) == (expected.Count > 0));
        }

        [Test]
        public async Task StoryInitialization_SearchStories_WhenHasSearchedResult()
        {
            var searchText = "The growing list of companies pulling ads from X";

            var expected = StoryData.GetStories().Where(f=> f.title == searchText).FirstOrDefault();

            var actual = (await _storyHelper.Object.FetchStories(searchText)).Where(f => f.title == searchText).FirstOrDefault();

            Assert.That(actual?.id, Is.EqualTo(expected?.id));
            Assert.That(actual?.title, Is.EqualTo(expected?.title));
        }



        [Test]
        public async Task StoryInitialization_SearchStories_WhenHasNotSearchedResult()
        {
            var searchText = "Search Text";

            var expected = StoryData.GetStories().Where(f => f.title == searchText).FirstOrDefault();

            var actual = (await _storyHelper.Object.FetchStories(searchText)).Where(f => f.title == searchText).FirstOrDefault();

            Assert.IsNull(actual);
            Assert.IsNull(expected);
        }



        [Test]
        public async Task StoryInitialization_Cache_VerifyCacheWorking()
        {
            var key = "storyKey";
            var expacted =  StoryData.GetStories() ;

            var services = new ServiceCollection();
            services.AddMemoryCache();
            var serviceProvider = services.BuildServiceProvider();

            var memoryCache = serviceProvider.GetService<IMemoryCache>();

            var actual = new List<Story>();

            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddDays(3),
                Priority = CacheItemPriority.High,
            };

            memoryCache.Set(key, expacted, cacheExpiryOptions);

            memoryCache.TryGetValue(key, out actual);

            Assert.AreEqual(expacted, actual);
        }



    }
}

