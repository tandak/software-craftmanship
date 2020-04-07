using System.Collections.Generic;
using System.Linq;

namespace software_craftsmanship.Lib
{
    public class GetAttributesBenchmark
    {
        public bool HasMakeupAttributeV1(List<Attribute> attributes)
        {
            return attributes.Select(a => a.NameId).Contains(1025);
        }

        public bool HasMakeupAttributeV2(List<Attribute> attributes)
        {
            return attributes.Any(a => a.NameId == 1052);
        }
    }
}