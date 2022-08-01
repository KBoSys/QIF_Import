/*! \file OtherNonShapeFeatureDefinitionType.cs
	\brief defines a non-shape feature definition.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The OtherNonShapeFeatureDefinitionType defines a non-shape feature definition./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OtherNonShapeFeatureDefinitionType : NonShapeFeatureDefinitionBaseType
    {
        /// <remarks The Description element describes the other non-shape feature in natural language./>
        public string Description { get; set; }
    }
}
