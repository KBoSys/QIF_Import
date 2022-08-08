/*! \file PointDefinedCurveFeatureItemType.cs
    \brief Defines an individual point-defined curve feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks The PointDefinedCurveFeatureItemType defines an individual point-defined curve feature.
    /// A point-defined curve feature is defined by a set of points and may be a planar curve or a free-form
    /// curve not in a plane./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks/>
        public PointDefinedCurveMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveMeasurementDeterminationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(PointDefinedCurveCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveCheckedFeatureType
    {
        /// <remarks/>
        public PointDefinedCurveCheckedType CheckDetails { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveCheckedType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(PointDefinedCurveConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveConstructionMethodType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(PointDefinedCurveBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(PointDefinedCurveCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Extract", typeof(PointDefinedCurveExtractType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(PointDefinedCurveFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(PointDefinedCurveRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(PointDefinedCurveTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
