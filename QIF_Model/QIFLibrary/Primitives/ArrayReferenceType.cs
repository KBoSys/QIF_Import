/*! \file ArrayReferenceType.cs
	\brief The ArrayReferenceType is an array of references to object IDs.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Collections.Generic;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ArrayReferenceType
    {
        public ArrayReferenceType() { }

        /// <remarks Each Id element is a reference to the QIF id of an object./>
        [XmlElement(ElementName = "Id", Type = typeof(QIFReferenceType))]
        public List<QIFReferenceType> References { get; set; }

        /// <remarks The required n attribute is the number of reference types in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.References.Count;
            set { }
        }
    }

    /// <remarks The ArrayReferenceActiveType is an array of references to object IDs. />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayReferenceActiveType
    {
        /// <remarks Each Id element is a reference to the QIF id of an object with an indicator of whether the reference is active or not./>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFReferenceActiveType[] Items { get; set; }

        /// <remarks The required n attribute is the number of Id elements in this array./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
