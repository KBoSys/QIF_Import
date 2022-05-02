/*! \file DirectionalOffsetType.cs
    \brief The DirectionalOffsetType defines an offset or displacement in a specified direction.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
	/// <remarks The DirectionalOffsetType defines an offset or displacement in a specified direction./>
	public class DirectionalOffsetType
	{
		/// <remarks The Offset element is offset in the specified direction, a
		/// positive value will offset in the specified direction and a
		/// negative value will offset opposite the specified direction./>
		[XmlElement]
		public Units.LinearValueType Offset { get; set; }

		#region Choice
		[XmlChoiceIdentifier("DirectionType")]
		[XmlElement("NominalDirection", typeof(Primitives.UnitVectorType))]
		[XmlElement("FeatureDirection", typeof(BaseFeatureType))]
		public object Direction;

		// Don't serialize this field. The EnumType field
		// contains the enumeration value that corresponds
		// to the MyChoice field value.
		[XmlIgnore]
		public OffsetDirectionChoiceType DirectionType;

		#endregion
	}
	[XmlType(IncludeInSchema = false)]
	public enum OffsetDirectionChoiceType
	{
		None,
		NominalDirection,
		FeatureDirection,
	}
}
