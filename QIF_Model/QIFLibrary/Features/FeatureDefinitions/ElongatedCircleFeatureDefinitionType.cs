/*! \file ElongatedCircleFeatureDefinitionType.cs
	\brief Defines the elongated circle feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The ElongatedCircleFeatureDefinitionType defines the elongated
    /// circle feature nominal information that can be common to one or
    /// more elongated circle features./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleFeatureDefinitionType : CurveFeatureDefinitionBaseType
    {
        /// <remarks The InternalExternal element indicates whether the feature is internal or external./>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks The Diameter element is the nominal diameter of the elongated circle./>
        public LinearValueType Diameter { get; set; }

        /// <remarks The Length element is the length (i.e., size) of the elongated circle from circular end to circular end./>
        public LinearValueType Length { get; set; }
    }
}
