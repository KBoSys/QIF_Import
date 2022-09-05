/*! \file OtherCurveFeatureDefinitionType.cs
	\brief Defines the other curve feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The OtherCurveFeatureDefinitionType defines the other curve
    /// feature nominal information that can be common to one or more other curve features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OtherCurveFeatureDefinitionType : CurveFeatureDefinitionBaseType
    {
    }
}
