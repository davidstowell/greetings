using System.Xml.Linq;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            // read xml file
            XDocument doc = XDocument.Load(Properties.Resources.GreetingInstancesDataFile);

            // select child
            foreach (XElement element in doc.Descendants().Elements())
            {
                var lang = element.Attribute("lang").Value;
                var dest = element.Attribute("dest").Value;
                IGreetingOutput greet;

                switch (dest)
                {
                    case "console":
                    {
                        greet = new ConsoleOutput();
                        break;
                    }
                    case "database":
                    {
                        greet = new DatabaseOutput();
                        break;
                    }
                    default:
                    {
                        greet = null;
                        break;
                    }
                }

                if (greet != null)
                {
                    greet.SetGreeting(lang);
                }
            }
        }
    }
}
