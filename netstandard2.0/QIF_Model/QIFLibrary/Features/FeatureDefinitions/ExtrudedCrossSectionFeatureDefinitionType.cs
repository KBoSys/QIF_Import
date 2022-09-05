/*! \file ExtrudedCrossSectionFeatureDefinitionType.cs
	\brief Defines the extruded cross-section feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The ExtrudedCrossSectionFeatureDefinitionType defines the extruded
    /// cross-section feature nominal information that can be common to one
    /// or more extruded cross-section features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The Length element is the nominal length of the feature in the direction of extrusion.</remarks>
        public LinearValueType Length { get; set; }
    }
}
