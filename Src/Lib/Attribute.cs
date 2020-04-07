using System.Collections.Generic;

namespace software_craftsmanship.Lib
{
    public class Attribute
    {
        public List<string> Name { get; set; }

        public List<string> Value { get; set; }

        public int NameId { get; set; }

        public int ValueId { get; set; }

        public int? ColourwayId { get; set; }
    }
}