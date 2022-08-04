/*! \file PlaneFeatureDefinitionType.cs
	\brief Defines the plane feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The PlaneFeatureDefinitionType defines the plane feature nominal
    /// information that can be common to one or more plane features.
    /// There is no definition information for a plane feature beyond what is
    /// provided by the SurfaceFeatureDefinitionBaseType./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PlaneFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
    }
}
