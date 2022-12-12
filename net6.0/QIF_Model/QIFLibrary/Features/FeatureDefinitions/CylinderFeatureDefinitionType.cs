/*! \file CylinderFeatureDefinitionType.cs
	\brief defines cylinder feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The CylinderFeatureDefinitionType defines the cylinder feature
    /// nominal information that can be common to one or more cylinder features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CylinderFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        [XmlElement]
        public PrimitivesPMI.InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        [XmlElement]
        public Units.LinearValueType Diameter { get; set; } = new Units.LinearValueType();

        /// <remarks> The optional Length element is the nominal length of the cylinder from the start point in the direction of the cylinder axis.</remarks>
        [XmlElement]
        public Units.LinearValueType Length { get; set; } = new Units.LinearValueType();

        /// <remarks> The optional Bottom element describes the bottom type of the cylinder.</remarks>
        [XmlElement]
        public PrimitivesPMI.BottomType? Bottom { get; set; }
    }
}
