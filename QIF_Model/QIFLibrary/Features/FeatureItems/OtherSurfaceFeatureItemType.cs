/*! \file OtherSurfaceFeatureItemType.cs
    \brief Defines an individual other surface feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The OtherSurfaceFeatureItemType defines an individual other surface feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public OtherSurfaceMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(OtherSurfaceCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceCheckedFeatureType
    {
        /// <remarks></remarks>
        public OtherSurfaceCheckedType CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(OtherSurfaceConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Copy")]
        public OtherSurfaceFeatureCopyType Item { get; set; }
    }
}
