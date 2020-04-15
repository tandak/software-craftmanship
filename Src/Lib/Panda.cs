using System.Collections.Generic;

namespace software_craftsmanship.ConsoleApp
{
    public class Panda
    {
        public string Name { get; } = "foo";

        public int Age { get; set; }
        public string Location { get; set; }
    }

    public class Pandas
    {
        public IEnumerable<Panda> PandaZoo
        {
            get
            {
                yield return new Panda {Age = 10, Location = "London"};
                yield return new Panda {Age = 20, Location = "China"};
                yield return new Panda {Age = 47, Location = "Uganda"};
            }
        }
    }
}