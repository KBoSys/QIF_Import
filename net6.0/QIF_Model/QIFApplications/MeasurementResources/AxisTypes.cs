/*! \file AxisTypes.cs
	\brief Defines an axis for a 3 dimensional coordinate system.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> 
    /// The LinearOrRotaryAxisType defines a linear or rotary axis.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class LinearOrRotaryAxisType
    {
        /// <remarks> 
        /// The Axis element is a rotary or linear axis.
        /// </remarks>
        [XmlElement]
        public AxisType? Axis { get; set; } = new AxisType();
    }

    /// <remarks> 
    /// The UserDefinedAxisType defines an axis for a 3 dimensional	coordinate system.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedAxisType : LinearOrRotaryAxisType
    {
        /// <remarks> 
        /// The optional Attributes element contains user defined
        /// attributes that define the first axis(typified, binary array, or XML structured).
        /// </remarks>
        [XmlElement]
        public AttributesType? Attributes { get; set; }

        /// <remarks> 
        /// The AxisName element is the name of the user defined axis.
        /// </remarks>
        [XmlElement]
        public string? AxisName { get; set; } = "";
    }
}
