/*! \file OppositeParallelLinesFeatureItemType.cs
    \brief Defines an individual feature-of-size opposite parallel lines feature located by its centerline. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The OppositeParallelLinesFeatureItemType defines an individual
    /// feature-of-size opposite parallel lines feature located by its centerline.
    /// This feature can be used to describe a slot or groove
    /// (internal feature) or a rib, web, or block(external feature).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks></remarks>
        public OppositeParallelLinesMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(OppositeParallelLinesCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesCheckedFeatureType
    {
        /// <remarks></remarks>
        public OppositeParallelLinesCheckedType CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(OppositeParallelLinesConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(OppositeParallelLinesBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(OppositeParallelLinesCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(OppositeParallelLinesCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(OppositeParallelLinesFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersection", typeof(OppositeParallelLinesIntersectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Projection", typeof(OppositeParallelLinesProjectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(OppositeParallelLinesRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(OppositeParallelLinesTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
