/*! \file OtherShapeFeatureNominalType.cs
    \brief Defines the other shape feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The OtherShapeFeatureNominalType defines the other shape feature
    /// nominal information for an individual other shape feature.An other
    /// shape feature is intended to be used by having it reference a mixed
    /// collection of topology(shells, faces, curves, vertices) in an
    /// internal or external CAD definition.An other shape feature must
    /// not be used to represent a feature that can be represented as a
    /// more specific type of feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherShapeFeatureNominalType : ShapeFeatureNominalBaseType
    {
        /// <remarks></remarks>
        public OtherShapeConstructionMethodType? Constructed { get; set; }
    }
}
