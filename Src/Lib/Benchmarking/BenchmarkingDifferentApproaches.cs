using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace software_craftsmanship.Lib.Benchmarking
{
    public class BenchmarkingDifferentApproaches
    {
        private readonly List<Attribute> _attributes = new List<Attribute>
        {
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 1111,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 2222,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 7777,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 3333,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 4444,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 5555,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 1025,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 9999,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 6666,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            },
            new Attribute
            {
                Name = new List<string> {"ATTRIBUTE"},
                NameId = 8249,
                Value = new List<string> {"VALUE"},
                ValueId = 999
            }
        };

        private readonly GetAttributesBenchmark _attributesBenchmark = new GetAttributesBenchmark();
        private readonly MaxPurchasableV1 _v1 = new MaxPurchasableV1();
        private readonly MaxPurchasableV2 _v2 = new MaxPurchasableV2();


        //[Benchmark]
        public int? MaxPurchasableV1()
        {
            return _v1.Compute(15816);
        }

        //[Benchmark]
        public int? MaxPurchasableV2()
        {
            return _v2.Compute(15816);
        }

        [Benchmark]
        public bool GetAttributesBenchmarkV1()
        {
            return _attributesBenchmark.HasMakeupAttributeV1(_attributes);
        }

        [Benchmark]
        public bool GetAttributesBenchmarkV2()
        {
            return _attributesBenchmark.HasMakeupAttributeV2(_attributes);
        }
    }
}