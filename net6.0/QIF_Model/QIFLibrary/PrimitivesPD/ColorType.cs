/*! \file ColorType.cs
	\brief The ColorType is the RGB color type

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks> The ColorType is the RGB color type - a triplet of integer numbers: the red-component, the green-component and the blue-component.</remarks>
    public class ColorType
    {
        public ColorType()
        {
        }

        public ColorType(ushort r, ushort g, ushort b)
        {
            Red = r; Green = g; Blue = b;
        }

        [XmlIgnore]
        public ushort Red { get; set; }

        [XmlIgnore]
        public ushort Green { get; set; }

        [XmlIgnore]
        public ushort Blue { get; set; }

        [XmlText]
        public string? AsText 
        { 
            get => ToString(); 
            set
            {
                ColorType? clr = FromString(value);
                if (clr != null)
                {
                    Red = clr.Red;
                    Green = clr.Green;
                    Blue = clr.Blue;
                }
            }
        }

        public static ColorType? FromString(string? rgb)
        {
            ColorType? colorType = null;

            if (!String.IsNullOrEmpty(rgb))
            {
                string[] parts = rgb.Split(' ');
                if (parts.Length == 3)
                {
                    ushort r = 0, g = 0, b = 0;
                    bool valid = true;
                    valid &= ushort.TryParse(parts[0], out r);
                    valid &= ushort.TryParse(parts[1], out g);
                    valid &= ushort.TryParse(parts[2], out b);

                    if (valid)
                    {
                        colorType = new ColorType(r, g, b);
                    }
                }
            }

            return colorType;
        }
        public override string ToString()
        {
            return $"{Red} {Green} {Blue}";
        }
    }

    /// <remarks> The TransparencyType is the transparency type - double value in range[0..1].</remarks>
    public class TransparencyType : QIFApplications.TypeAlias<double>
    {
        public TransparencyType()
        {
            base._value = 0D;
        }
        /// As we are using implicit conversions we can keep the constructor private
        public TransparencyType(double value) => base._value = Math.Max(0.0, Math.Min(value, 1.0));

        /// Implicit conversion from double to TransparencyType
        public static implicit operator TransparencyType(double value)
        {
            return new TransparencyType(value);
        }
        /// Implicit conversion to a double.
        public static implicit operator double(TransparencyType alias)
        {
            return alias.Value;
        }
    }
}
