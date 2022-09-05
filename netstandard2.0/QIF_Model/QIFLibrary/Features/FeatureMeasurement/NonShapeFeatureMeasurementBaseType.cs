/*! \file NonShapeFeatureMeasurementBaseType.cs
    \brief abstract base type for non-shape feature measurements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The NonShapeFeatureMeasurementBaseType is the abstract base type for non-shape feature measurements.
    /// A non-shape feature measurement holds all information for a measured non-shape feature, e.g.the actual text of a marking.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class NonShapeFeatureMeasurementBaseType : FeatureMeasurementBaseType
    {
    }

    /// <remarks> The MarkingFeatureMeasurementType defines the measured values of a marking feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MarkingFeatureMeasurementType : NonShapeFeatureMeasurementBaseType
    {
        /// <remarks> The Text element is the actual text of the marking.</remarks>
        public string Text { get; set; }

        /// <remarks> The Location element defines a rectangle within which the marking was made.</remarks>
        public PrimitivesPMI.RectangleType Location { get; set; }
    }
}
