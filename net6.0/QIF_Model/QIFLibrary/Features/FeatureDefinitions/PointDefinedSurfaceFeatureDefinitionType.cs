/*! \file PointDefinedSurfaceFeatureDefinitionType.cs
	\brief Defines the point-defined surface feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The PointDefinedSurfaceDefinitionType defines the point-defined
    /// surface feature nominal information that can be common to one or
    /// more point-defined surface features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PointDefinedSurfaceFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
    }
}
