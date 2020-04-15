using System.ComponentModel;
using System.Globalization;

namespace software_craftsmanship.Lib
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Length
    {
        public Unit Unit { get; set; }

        public float Value { get; set; }

        public override string ToString()
        {
            string value;
            string unit;

            value = Value.ToString(CultureInfo.InvariantCulture);
            unit = Unit.ToString();

            return string.Concat(value, unit);
        }
    }

    internal class SampleClass
    {
        public Length Length1 { get; set; }

        public Length Length2 { get; set; }

        public Length Length3 { get; set; }
    }

    public enum Unit
    {
        None,
        cm,
        mm,
        pt,
        px
    }
}