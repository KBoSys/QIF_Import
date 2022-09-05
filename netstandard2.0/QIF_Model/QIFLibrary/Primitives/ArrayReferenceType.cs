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
    public class ArrayReferenceType : ArrayBaseType<QIFReferenceType>
    {
        /// <remarks> Each Id element is a reference to the QIF id of an object.</remarks>
        [XmlElement(ElementName = "Id", Type = typeof(QIFReferenceType))]
        public QIFReferenceType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ArrayReferenceActiveType is an array of references to object IDs. </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayReferenceActiveType : ArrayBaseType<QIFReferenceActiveType>
    {
        /// <remarks> Each Id element is a reference to the QIF id of an object with an indicator of whether the reference is active or not.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFReferenceActiveType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
