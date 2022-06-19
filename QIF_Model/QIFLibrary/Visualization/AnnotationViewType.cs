/*! \file AnnotationViewType.cs
	\brief defines an annotation view to facilitate representation of the model's annotations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The AnnotationViewType element defines an annotation view to facilitate representation of the model's annotations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AnnotationViewType : NodeWithIdBaseType
    {
        /// <remarks The Normal element is the normal vector of the visualization planes./>
        public UnitVectorType Normal { get; set; }

        /// <remarks The Direction element is the default text direction./>
        public UnitVectorType Direction { get; set; }
    }

    /// <remarks The AnnotationViewSetType defines a collection of annotation views./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AnnotationViewSetType
    {
        /// <remarks Each AnnotationView element defines an annotation view./>
        [System.Xml.Serialization.XmlElementAttribute("AnnotationView")]
        public AnnotationViewType[] Items { get; set; }

        /// <remarks The required n attribute is the number of annotations in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
