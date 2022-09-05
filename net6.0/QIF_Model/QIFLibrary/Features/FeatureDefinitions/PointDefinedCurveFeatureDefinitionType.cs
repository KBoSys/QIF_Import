/*! \file PointDefinedCurveFeatureDefinitionType.cs
	\brief Defines the point-defined curve feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The PointDefinedCurveFeatureDefinitionType defines the
    /// point-defined curve feature nominal information that can be common
    /// to one or more point-defined curve features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PointDefinedCurveFeatureDefinitionType : CurveFeatureDefinitionBaseType
    {
    }
}
