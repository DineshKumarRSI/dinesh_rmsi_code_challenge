using Code_Challenge_API.Model;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_Test.Data
{
    public static class StoryData
    {
        public static List<Story> GetStories()
        {
            var stories = new List<Story>();
            stories.Add(new Story()
            {
                by = "MilnerRoute",
                descendants = 0,
                id = 38315034,
                kids = null,
                score = 5,
                time = 1700280595,
                title = "The growing list of companies pulling ads from X",
                type = "story",
                url = "https://www.msn.com/en-us/money/companies/this-is-the-growing-list-of-companies-pulling-ads-from-x/ar-AA1k7rki"
            });
            stories.Add(new Story()
            {
                by = "MBCook",
                descendants = 2,
                id = 38314710,
                kids = new List<int>() { 38315067 },
                score = 6,
                time = 1700278119,
                title = "Tesla Investors Call for Elon Musk to Be Suspended",
                type = "story",
                url = "https://gizmodo.com/tesla-investors-call-elon-musk-suspended-1851031830"
            });
            stories.Add(new Story()
            {
                by = "convexstrictly",
                descendants = 29,
                id = 38314407,
                kids = new List<int>() { 38315294, 38315201, 38315250, 38315284, 38314799, 38314821 },
                score = 49,
                time = 1700276064,
                title = "sutskever: OpenAI board doing its mission to build AGI that benefits all",
                type = "story",
                url = "https://twitter.com/GaryMarcus/status/1725707548106580255"
            });
            stories.Add(new Story()
            {
                by = "apsec112",
                descendants = 243,
                id = 38314299,
                 kids =  new List<int>() { 38315246, 38315195, 38314376, 38314978, 38315059, 38314462, 38314420, 38314741, 38314648, 38314633, 38314702, 38314436, 38315135, 38314800, 38314920, 38314368, 38314691, 38314486, 38314430, 38314670, 38314761, 38314660, 38314699, 38314973, 38315021, 38315183, 38314795, 38315032, 38314460, 38314814, 38314583, 38314383, 38314371, 38314338, 38314918, 38314411, 38314630, 38314987, 38315057},
                score = 243,
                time = 1700275237,
                title = "Tilya Sutskever \"at the center\" of Altman firing?",
                type = "story",
                url = "https://twitter.com/karaswisher/status/1725702501435941294"
            });
            stories.Add(new Story()
            {
                by = "gjsman-1000",
                descendants = 28,
                id = 38314224,
                 kids =  new List<int>() { 38314999, 38315191, 38314727, 38314950, 38314518, 38315004, 38314524, 38314501, 38314649, 38314951},
                score = 56,
                time = 1700274694,
                title = "Parental controls? What parental controls?",
                type = "story",
                url = "https://gabrielsieben.tech/2023/11/15/parental-controls-are-unusable-and-its-why-congress-is-stepping-in/"
            });
            stories.Add(new Story()
            {
                by = "lxm",
                descendants = 4,
                id = 38314192,
                 kids =  new List<int>() { 38314739, 38314499, 38314580, 38314446, 38314624},
                score = 7,
                time = 1700274130,
                title = "Why Aren't More People Getting Married?",
                type = "story",
                url = "https://www.nytimes.com/2023/11/11/opinion/marriage-women-men-dating.html"
            });
            stories.Add(new Story()
            {
                by = "oomuchtodo",
                descendants = 3,
                id = 38314185,
                 kids =  new List<int>() { 38314187},
                score = 13,
                time = 1700274069,
                title = "biden Uses War - Time Law to Fund Heat Pumps Citing Climate Crisis",
                type = "story",
                url = "https://www.bloomberg.com/news/articles/2023-11-17/biden-uses-war-time-law-to-fund-heat-pumps-citing-climate-crisis"
            });
            stories.Add(new Story()
            {
                by = "cpeth",
                descendants = 25,
                id = 38313747,
                 kids =  new List<int>() { 38314603, 38314319, 38314847, 38314426, 38314490, 38315130, 38314755, 38314954, 38314944, 38314560, 38314466, 38314467, 38314837, 38314568, 38314801, 38314231, 38314655, 38314599, 38314528},
                score = 32,
                time = 1700271428,
                title = "Ask HN: Are job referrals worthless now?",
                type = "story",
                url = null
            });

            stories.Add(new Story()
            {
                by = "georgehill",
                descendants = 24,
                id = 38313609,
                 kids =  new List<int>() { 38313734, 38313841, 38314001, 38313965, 38313977, 38313908, 38313776},
                score = 40,
                time = 1700270554,
                title = "What Ilya Sutskever really wants",
                type = "story",
                url = "https://www.aipanic.news/p/what-ilya-sutskever-really-wants"
            });
            stories.Add(new Story()
            {
                by = "nikhilarundesai",
                descendants = 107,
                id = 38313359,
                 kids =  new List<int>() { 38314084, 38313517, 38313487, 38313447, 38313500, 38313847, 38313488, 38313559, 38314227, 38313510, 38313627, 38313530, 38313551, 38313486, 38313592, 38314137, 38313794, 38313713, 38313579, 38313768, 38313663, 38314432, 38313808, 38313496, 38313585, 38313813},
                score = 182,
                time = 1700269174,
                title = "kara Swisher: there will be more departures of top folks at OpenAI tonight",
                type = "story",
                url = "https://twitter.com/karaswisher/status/1725678074333635028"
            });
            stories.Add(new Story()
            {
                by = "0xDEADFED5",
                descendants = 3,
                id = 38312974,
                 kids =  new List<int>() { 38314087, 38314565},
                score = 67,
                time = 1700267339,
                title = "Yuzu Progress Report October 2023",
                type = "story",
                url = "https://yuzu-emu.org/entry/yuzu-progress-report-oct-2023/"
            });
            stories.Add(new Story()
            {
                by = "PaulHoule",
                descendants = 7,
                id = 38312734,
                 kids =  new List<int>() { 38313569, 38313699},
                score = 20,
                time = 1700266346,
                title = "insecure renting ages you faster than owning a home,unemployment or obesity",
                type = "story",
                url = "https://phys.org/news/2023-11-insecure-renting-ages-faster-home.html"
            });
            stories.Add(new Story()
            {
                by = "nickrubin",
                descendants = 453,
                id = 38312704,
                 kids =  new List<int>() { 38313026, 38312848, 38312979, 38313401, 38313835, 38312779, 38312996, 38313501, 38313407, 38313047, 38313745, 38313000, 38313136, 38314658, 38313261, 38312862, 38315174, 38312859, 38312885, 38313805, 38312800, 38315015, 38312820, 38313236, 38313131, 38313791, 38313378, 38314335, 38314267, 38313165, 38314384, 38312903, 38313743, 38312785, 38313979, 38312921, 38312784, 38314369, 38313381, 38313227, 38313037, 38312751, 38312881, 38312798, 38313253, 38312867, 38312789, 38312813, 38312792, 38312838, 38312783, 38312882, 38312854, 38313023, 38312842, 38312817, 38313304, 38313318, 38312990, 38313309},
                score = 919,
                time = 1700266221,
                title = "Greg Brockman quits OpenAI",
                type = "story",
                url = "https://twitter.com/gdb/status/1725667410387378559?s=20"
            });
            stories.Add(new Story()
            {
                by = "pr337h4m",
                descendants = 3,
                id = 38312690,
                 kids =  new List<int>() { 38313775, 38313993, 38314017, 38314907},
                score = 60,
                time = 1700266147,
                title = "Your Board of Directors Is Probably Going to Fire You (2021)",
                type = "story",
                url = "https://reactionwheel.net/2021/11/your-boards-of-directors-is-probably-going-to-fire-you.html"
            });
            stories.Add(new Story()
            {
                by = "nmstoker",
                descendants = 22,
                id = 38312649,
                 kids =  new List<int>() { 38314622, 38314874, 38313670, 38314381, 38314143, 38313700},
                score = 152,
                time = 1700265988,
                title = "i Hacked the Magic Mouse",
                type = "story",
                url = "https://uplab.pro/2023/11/i-hacked-the-magic-mouse/"
            });
            stories.Add(new Story()
            {
                by = "pranay01",
                descendants = 25,
                id = 38312617,
                 kids =  new List<int>() { 38314681, 38314327, 38314678, 38314245, 38313483, 38314692},
                score = 39,
                time = 1700265839,
                title = "Who Is Mira Murati, OpenAI's New CEO?",
                type = "story",
                url = "https://www.wired.com/story/openai-new-ceo-who-is-mira-murati/"
            });
            stories.Add(new Story()
            {
                by = "aaronds",
                descendants = 162,
                id = 38312372,
                 kids =  new List<int>() { 38312572, 38312611, 38312619, 38312773, 38313064, 38312593, 38315217, 38313124, 38312591, 38313127, 38312949, 38312790, 38312732, 38312802, 38314617, 38312934, 38312651, 38313618, 38314042, 38313866, 38314070, 38312674, 38313638, 38312602, 38313513, 38314119, 38314736, 38312678, 38312761, 38313586, 38312711, 38312775, 38312522, 38313397, 38312742, 38312923},
                score = 501,
                time = 1700264558,
                title = "Microsoft was blindsided by OpenAI's ouster of CEO Sam Altman",
                type = "story",
                url = "https://www.axios.com/2023/11/17/microsoft-openai-sam-altman-ouster"
            });
            stories.Add(new Story()
            {
                by = "sanketsaurav",
                descendants = 13,
                id = 38312355,
                 kids =  new List<int>() { 38313121, 38313018, 38312741, 38313069, 38313604, 38312884, 38313040},
                score = 78,
                time = 1700264476,
                title = "satya Nadella's Statement on OpenAI",
                type = "story",
                url = "https://blogs.microsoft.com/blog/2023/11/17/a-statement-from-microsoft-chairman-and-ceo-satya-nadella/"
            });

            return stories;
        }
    }
}
