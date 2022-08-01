﻿/*! \file SavedViewType.cs
	\brief defines a saved view to facilitate presentation of the model and its annotations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The SavedViewType defines a saved view to facilitate presentation of the model and its annotations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SavedViewType : NodeWithIdBaseType
    {
        /// <remarks The optional ActiveView element shows whether this view is active./>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ActiveView { get; set; } = false;

        /// <remarks The optional AnnotationVisibleIds element is an array
        /// of identifiers of model characteristics which must be visible in this saved view./>
        public ArrayReferenceFullType AnnotationVisibleIds { get; set; }

        /// <remarks The optional AnnotationHiddenIds element is an array of
        /// identifiers of model characteristics which must be hidden in this saved view./>
        public ArrayReferenceFullType AnnotationHiddenIds { get; set; }

        /// <remarks The optional BodyIds element is an array of identifiers of
        /// model bodies which must be visible in this saved view.If
        /// the BodyIds element is absent, then all model bodies are visible in this saved view./>
        public ArrayReferenceFullType BodyIds { get; set; }

        /// <remarks The optional ComponentIds element is an array of
        /// identifiers of model components which must be visible in
        /// this saved view.If the ComponentIds element is absent,
        /// then all model components are visible in this saved view./>
        public ArrayReferenceFullType ComponentIds { get; set; }

        /// <remarks The optional SimplifiedRepresentationId element is the
        /// identifier of a simplified representation, which shows the model in a simplified way./>
        public QIFReferenceActiveType SimplifiedRepresentationId { get; set; }

        /// <remarks The optional ExplodedViewId element is the identifier of
        /// an exploded view, which shows each component of the model
        /// separated from other components./>
        public QIFReferenceActiveType ExplodedViewId { get; set; }

        /// <remarks The optional DisplayStyleId element is the identifier of a
        /// display style, which defines a color, transparency and displaying form./>
        public QIFReferenceActiveType DisplayStyleId { get; set; }

        /// <remarks The optional ZoneSectionId element is the identifier of a
        /// zone section, which (1) defines a set of section planes
        /// that separate the model into parts and(2) defines logical
        /// operations that use the planes to separate the model./>
        public QIFReferenceActiveType ZoneSectionId { get; set; }

        /// <remarks The optional CameraIds element is an array of camera identifiers./>
        public ArrayReferenceActiveType CameraIds { get; set; }
    }

    /// <remarks The SavedViewSetType is a collection of saved views./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SavedViewSetType
    {
        /// <remarks Each SavedView element defines a saved View./>
        [System.Xml.Serialization.XmlElementAttribute("SavedView")]
        public SavedViewType[] Items { get; set; }

        /// <remarks The required n attribute is the number of saved views in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
