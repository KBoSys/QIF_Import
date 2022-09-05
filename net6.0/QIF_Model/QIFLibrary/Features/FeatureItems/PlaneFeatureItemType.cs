/*! \file PlaneFeatureItemType.cs
    \brief Defines an individual plane feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The PlaneFeatureItemType defines an individual plane feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public PlaneMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks> The PlaneMeasurementDeterminationType defines how the plane
    /// measurement is determined, either by being set or by being checked
    /// (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneMeasurementDeterminationType
    {
        /// <remarks> 
        /// The Checked element signifies that the plane is checked from measured data, either directly measured or constructed.
        /// The Set element signifies that the plane measurement is set to its nominal value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(PlaneCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The PlaneCheckedFeatureType defines that a plane feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneCheckedFeatureType
    {
        /// <remarks> The optional CheckDetails element gives details about the plane check(measurement or construction).</remarks>
        public PlaneCheckedType? CheckDetails { get; set; }
    }

    /// <remarks> The PlaneCheckedType defines how the plane measurement is checked,
    /// either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(PlaneConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The PlaneConstructionMethodType defines the method for constructing
    /// a unique nominal or measured plane feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(PlaneBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(PlaneCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(PlaneCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Extract", typeof(PlaneExtractType))]
        [System.Xml.Serialization.XmlElementAttribute("Midplane", typeof(PlaneMidplaneType))]
        [System.Xml.Serialization.XmlElementAttribute("Offset", typeof(PlaneOffsetType))]
        [System.Xml.Serialization.XmlElementAttribute("Parallel", typeof(PlaneParallelType))]
        [System.Xml.Serialization.XmlElementAttribute("Perpendicular", typeof(PlanePerpendicularType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(PlaneRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("TangentThrough", typeof(PlaneTangentThroughType))]
        [System.Xml.Serialization.XmlElementAttribute("Through", typeof(PlaneThroughType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(PlaneTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
