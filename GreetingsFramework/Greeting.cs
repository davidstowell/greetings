using System.Linq;
using System.Xml.Linq;

namespace GreetingsFramework
{
    public static class Greeting
    {
        private static XDocument _greetings;

        static Greeting()
        {
            _greetings = XDocument.Load(Properties.Resources.GreetingDataFile);
        }

        public static string GetGreeting(string lang)
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return string.Empty;
            }

            var retval = _greetings.Descendants().Elements()
                .Where(x => x.Attribute("lang").Value == lang)
                .FirstOrDefault()?.Value;

            return retval ?? string.Empty;
        }
    }
}
