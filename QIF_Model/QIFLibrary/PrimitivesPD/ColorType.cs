/*! \file ColorType.cs
	\brief The ColorType is the RGB color type

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
	/// <remarks The ColorType is the RGB color type - a triplet of integer numbers: the red-component, the green-component and the blue-component./>
	public class ColorType : Primitives.ListIntType
	{
		public ColorType() : base(3) {}

		public static ColorType FromString(string rgb)
		{
			ColorType colorType = new ColorType();
			// TODO parse
			return colorType;
		}
	}

	/// <remarks The TransparencyType is the transparency type - double value in range[0..1]./>
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
