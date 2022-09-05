/*! \file OtherCurveFeatureNominalType.cs
    \brief Defines the other curve feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The OtherCurveFeatureNominalType defines the other curve
    /// feature nominal information for an individual other curve
    /// feature.An other curve feature is intended to be used by having
    /// it reference a collection of curves in an internal or external CAD
    /// definition.An other curve feature must not be used to represent
    /// a feature that can be represented as a more specific type of feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherCurveFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks></remarks>
        public OtherCurveConstructionMethodType Constructed { get; set; }
    }
}
