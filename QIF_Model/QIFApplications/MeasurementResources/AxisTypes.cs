/*! \file AxisTypes.cs
	\brief Defines an axis for a 3 dimensional coordinate system.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
	/// <remarks 
	/// The LinearOrRotaryAxisType defines a linear or rotary axis.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class LinearOrRotaryAxisType
	{
		/// <remarks 
		/// The Axis element is a rotary or linear axis.
		/// />
		[XmlElement(IsNullable = false)]
		public QIFLibrary.Primitives.AxisType Axis { get; set; }
	}

	/// <remarks 
	/// The UserDefinedAxisType defines an axis for a 3 dimensional	coordinate system.
	/// />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class UserDefinedAxisType : LinearOrRotaryAxisType
	{
		/// <remarks 
		/// The optional Attributes element contains user defined
		/// attributes that define the first axis(typified, binary array, or XML structured).
		/// />
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.AttributesType Attributes { get; set; }

		/// <remarks 
		/// The AxisName element is the name of the user defined axis.
		/// />
		[XmlElement(IsNullable = false)]
		public string AxisName { get; set; }
	}
}
