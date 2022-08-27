/*! \file ColorType.cs
	\brief The ColorType is the RGB color type

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks> The ColorType is the RGB color type - a triplet of integer numbers: the red-component, the green-component and the blue-component.</remarks>
    public class ColorType : Primitives.ListIntType
    {
        enum ColorIndex { RED, GREEN, BLUE };
        public ColorType() : base(3) { }
        public ColorType(int r, int g, int b) : base(3)
        {
            Value[(int)ColorIndex.RED] = r;
            Value[(int)ColorIndex.GREEN] = g;
            Value[(int)ColorIndex.BLUE] = b;
        }

        [XmlIgnore]
        int Red
        {
            get => Value[(int)ColorIndex.RED];
            set => Value[(int)ColorIndex.RED] = value;
        }
        [XmlIgnore]
        int Green
        {
            get => Value[(int)ColorIndex.GREEN];
            set => Value[(int)ColorIndex.GREEN] = value;
        }
        [XmlIgnore]
        int Blue
        {
            get => Value[(int)ColorIndex.BLUE];
            set => Value[(int)ColorIndex.BLUE] = value;
        }

        public static ColorType FromString(string rgb)
        {
            ColorType colorType = null;

            string[] parts = rgb.Split(' ');
            if (parts.Length == 3)
            {
                byte r = 0, g = 0, b = 0;
                bool valid = true;
                valid &= byte.TryParse(parts[0], out r);
                valid &= byte.TryParse(parts[1], out g);
                valid &= byte.TryParse(parts[2], out b);

                if (valid)
                {
                    colorType = new ColorType(r, g, b);
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
