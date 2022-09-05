/*! \file PatternFeatureParallelogramNominalType.cs
    \brief Defines the pattern feature nominal information for an individual parallelogram pattern feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The PatternFeatureParallelogramNominalType defines the pattern
    /// feature nominal information for an individual parallelogram pattern
    /// feature. The nominal location of the parallelogram pattern is the
    /// nominal location of the first feature in the pattern(which is
    /// not necessarily the first feature in the feature set).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PatternFeatureParallelogramNominalType : PatternFeatureNominalBaseType
    {
        /// <remarks></remarks>
        public QIFReferenceType? FirstFeatureLocation { get; set; }
    }
}
