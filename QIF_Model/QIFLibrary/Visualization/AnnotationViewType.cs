/*! \file AnnotationViewType.cs
	\brief defines an annotation view to facilitate representation of the model's annotations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The AnnotationViewType element defines an annotation view to facilitate representation of the model's annotations.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AnnotationViewType : NodeWithIdBaseType
    {
        /// <remarks> The Normal element is the normal vector of the visualization planes.</remarks>
        public UnitVectorType Normal { get; set; }

        /// <remarks> The Direction element is the default text direction.</remarks>
        public UnitVectorType Direction { get; set; }
    }

    /// <remarks> The AnnotationViewSetType defines a collection of annotation views.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AnnotationViewSetType : ArrayBaseType<AnnotationViewType>
    {
        /// <remarks> Each AnnotationView element defines an annotation view.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AnnotationView")]
        public AnnotationViewType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
