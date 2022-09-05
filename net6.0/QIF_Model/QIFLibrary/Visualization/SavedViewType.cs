/*! \file SavedViewType.cs
	\brief defines a saved view to facilitate presentation of the model and its annotations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The SavedViewType defines a saved view to facilitate presentation of the model and its annotations.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SavedViewType : NodeWithIdBaseType
    {
        /// <remarks> The optional ActiveView element shows whether this view is active.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ActiveView { get; set; } = false;

        /// <remarks> The optional AnnotationVisibleIds element is an array
        /// of identifiers of model characteristics which must be visible in this saved view.</remarks>
        public ArrayReferenceFullType? AnnotationVisibleIds { get; set; }

        /// <remarks> The optional AnnotationHiddenIds element is an array of
        /// identifiers of model characteristics which must be hidden in this saved view.</remarks>
        public ArrayReferenceFullType? AnnotationHiddenIds { get; set; }

        /// <remarks> The optional BodyIds element is an array of identifiers of
        /// model bodies which must be visible in this saved view.If
        /// the BodyIds element is absent, then all model bodies are visible in this saved view.</remarks>
        public ArrayReferenceFullType? BodyIds { get; set; }

        /// <remarks> The optional ComponentIds element is an array of
        /// identifiers of model components which must be visible in
        /// this saved view.If the ComponentIds element is absent,
        /// then all model components are visible in this saved view.</remarks>
        public ArrayReferenceFullType? ComponentIds { get; set; }

        /// <remarks> The optional SimplifiedRepresentationId element is the
        /// identifier of a simplified representation, which shows the model in a simplified way.</remarks>
        public QIFReferenceActiveType? SimplifiedRepresentationId { get; set; }

        /// <remarks> The optional ExplodedViewId element is the identifier of
        /// an exploded view, which shows each component of the model
        /// separated from other components.</remarks>
        public QIFReferenceActiveType? ExplodedViewId { get; set; }

        /// <remarks> The optional DisplayStyleId element is the identifier of a
        /// display style, which defines a color, transparency and displaying form.</remarks>
        public QIFReferenceActiveType? DisplayStyleId { get; set; }

        /// <remarks> The optional ZoneSectionId element is the identifier of a
        /// zone section, which (1) defines a set of section planes
        /// that separate the model into parts and(2) defines logical
        /// operations that use the planes to separate the model.</remarks>
        public QIFReferenceActiveType? ZoneSectionId { get; set; }

        /// <remarks> The optional CameraIds element is an array of camera identifiers.</remarks>
        public ArrayReferenceActiveType? CameraIds { get; set; }
    }

    /// <remarks> The SavedViewSetType is a collection of saved views.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SavedViewSetType : ArrayBaseType<SavedViewType>
    {
        /// <remarks> Each SavedView element defines a saved View.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SavedView")]
        public SavedViewType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
