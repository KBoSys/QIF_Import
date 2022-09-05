/*! \file SphericalSegmentFeatureDefinitionType.cs
	\brief Defines the spherical segment feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The SphericalSegmentFeatureDefinitionType defines the spherical
    /// segment feature nominal information that can be common to one or
    /// more spherical segment features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalSegmentFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Diameter element is the nominal diameter of the spherical segment.</remarks>
        public LinearValueType? Diameter { get; set; }
    }
}
