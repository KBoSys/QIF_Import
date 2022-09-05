/*! \file PMIDisplaySetType.cs
	\brief defines a container for storing all display data used for visualization of the annotation data.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The PMIDisplaySetType defines a container for storing all display data used for visualization of the annotation data.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PMIDisplaySetType : ArrayBaseType<PMIDisplayType>
    {
        /// <remarks> Each PMIDisplay element contains a block of display information which is used for visualization of the annotation data.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PMIDisplay")]
        public PMIDisplayType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The PMIDisplayType defines a block of display data used for visualization of PMI entities.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PMIDisplayType
    {
        /// <remarks> The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType? Attributes { get; set; }

        /// <remarks> The optional ColorType is the RGB color type - a triplet of
        /// integer numbers: the red-component, the green-component and the blue-component.</remarks>
        public ColorType? Color { get; set; }

        /// <remarks> The optional Plane element is an annotation plane.</remarks>
        public PlanePMIDisplayType? Plane { get; set; }

        /// <remarks> The optional Texts element specifies a set of text lines.</remarks>
        public TextsType? Texts { get; set; }

        /// <remarks> The optional Leader element defines leaders.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("LeaderExtend", typeof(LeaderExtendType))]
        [System.Xml.Serialization.XmlElementAttribute("LeaderCircular", typeof(LeaderCircularType))]
        [System.Xml.Serialization.XmlElementAttribute("LeaderDoubleHead", typeof(LeaderDoubleHeadType))]
        [System.Xml.Serialization.XmlElementAttribute("LeaderDoubleHeadCircular", typeof(LeaderDoubleHeadCircularType))]
        [System.Xml.Serialization.XmlElementAttribute("LeaderDoubleHeadExtend", typeof(LeaderDoubleHeadExtendType))]
        [System.Xml.Serialization.XmlElementAttribute("Leader")]
        public LeaderType[]? Leader { get; set; }

        /// <remarks> The optional WitnessLines element defines witness lines.</remarks>
        public WitnessLinesType? WitnessLines { get; set; }

        /// <remarks> The optional Frames element defines the visualization frames.</remarks>
        public FramesType? Frames { get; set; }

        /// <remarks> The optional Graphics element defines additional visualization data.
        /// It allows specifying user-defined PMI data that have no semantic representation in a QIF file.</remarks>
        public GraphicsType? Graphics { get; set; }

        /// <remarks> The Reference element is the id of an annotation entity which
        /// will be visualized according to the display information defined in the fields above.</remarks>
        public ElementReferenceFullType? Reference { get; set; }

        /// <remarks> The optional GroupID element is the group id:
        /// the first value is a group index, the second value is an annotation index within the group.</remarks>
        public I2Type? GroupID { get; set; }
    }

    /// <remarks> The PlanePMIDisplayType defines an annotation plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlanePMIDisplayType
    {
        /// <remarks> The AnnotationViewId element is the id of an annotation view entity.</remarks>
        public ElementReferenceType? AnnotationViewId { get; set; }

        /// <remarks> The optional Origin element is the origin of the annotation plane.</remarks>
        public PointType? Origin { get; set; }

        /// <remarks> The optional Direction element is a text direction. 
        /// Thisdirection overrides the default text direction defined in the annotation view.</remarks>
        public UnitVectorType? Direction { get; set; }
    }
}
