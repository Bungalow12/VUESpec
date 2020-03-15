using System;
using System.ComponentModel;
using System.Globalization;

namespace VUESpec.Types
{
    class PositionConverter : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return value.ToString();
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value.GetType() == typeof(string))
            {
                try
                {
                    string strVal = value as string;
                    string[] parts = strVal.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    return new Position()
                    {
                        X = int.Parse(parts[0].Trim()),
                        Y = int.Parse(parts[1].Trim()),
                        Z = int.Parse(parts[2].Trim())
                    };
                }
                catch
                {
                    {
                        throw new InvalidCastException(
                            "Cannot convert the string '" +
                            value.ToString() + "' into a Position");
                    }
                }
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
