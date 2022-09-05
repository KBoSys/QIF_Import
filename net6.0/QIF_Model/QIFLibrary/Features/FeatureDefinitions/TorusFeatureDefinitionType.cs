/*! \file TorusFeatureDefinitionType.cs
	\brief Defines the torus feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The TorusFeatureDefinitionType defines the torus feature nominal
    /// information that can be common to one or more torus features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The MinorDiameter element is the nominal minor diameter of the torus.</remarks>
        public LinearValueType? MinorDiameter { get; set; }

        /// <remarks> The MajorDiameter element is the nominal major diameter of the torus.</remarks>
        public LinearValueType? MajorDiameter { get; set; }
    }
}
