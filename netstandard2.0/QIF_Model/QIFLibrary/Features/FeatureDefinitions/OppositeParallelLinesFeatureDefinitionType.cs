/*! \file OppositeParallelLinesFeatureDefinitionType.cs
	\brief Defines the nominal information that can be common to one or more opposite parallel lines features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The OppositeParallelLinesFeatureDefinitionType defines the nominal
    /// information that can be common to one or more opposite parallel lines features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesFeatureDefinitionType : CurveFeatureDefinitionBaseType
    {
        /// <remarks></remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks></remarks>
        public LinearValueType Width { get; set; }

        /// <remarks></remarks>
        public LinearValueType Length { get; set; }

        /// <remarks></remarks>
        public SlotEndType EndType { get; set; }

        /// <remarks></remarks>
        public bool SingleOpenEnd { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SingleOpenEndSpecified { get; set; }

        /// <remarks></remarks>
        public EndRadiusType EndRadius1 { get; set; }

        /// <remarks></remarks>
        public EndRadiusType EndRadius2 { get; set; }
    }
}
