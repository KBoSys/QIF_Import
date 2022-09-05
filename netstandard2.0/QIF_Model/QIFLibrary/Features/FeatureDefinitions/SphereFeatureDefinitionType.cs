/*! \file SphereFeatureDefinitionType.cs
	\brief Defines the sphere feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The SphereFeatureDefinitionType defines the sphere feature nominal
    /// information that can be common to one or more sphere features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SphereFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Diameter element is the nominal diameter of the sphere.</remarks>
        public LinearValueType Diameter { get; set; }
    }
}
