/*! \file OtherSurfaceFeatureDefinitionType.cs
	\brief Defines the other surface feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The OtherSurfaceFeatureDefinitionType defines the other surface
    /// feature nominal information that can be common to one or more other surface features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OtherSurfaceFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
    }
}
