/*! \file PointDefinedSurfaceFeatureItemType.cs
    \brief Defines an individual point-defined surface feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The PointDefinedSurfaceFeatureItemType defines an individual point-defined surface feature.
    /// A point-defined surface feature is defined by a set of points on a surface.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public PointDefinedSurfaceMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(PointDefinedSurfaceCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceCheckedFeatureType
    {
        /// <remarks></remarks>
        public PointDefinedSurfaceCheckedType CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(PointDefinedSurfaceConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(PointDefinedSurfaceBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(PointDefinedSurfaceCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Extract", typeof(PointDefinedSurfaceExtractType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(PointDefinedSurfaceRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(PointDefinedSurfaceTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
