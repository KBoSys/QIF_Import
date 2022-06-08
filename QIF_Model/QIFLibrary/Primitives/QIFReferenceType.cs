/*! \file QIFReferenceType.cs
    \brief Defines a reference to a QIF ID

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks
    /// The QIFReferenceType defines a reference to a QIF id that may be in
    /// the same file as the reference or may be in an identified external file. 
    /// In order to ensure that each reference refers to an object of
    /// the correct type, where possible, each reference is covered by an appropriate key/keyref constraint./>
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSetReferenceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSetReferenceSingleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSetReferenceRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointSetReferenceWholeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QIFReferenceFullType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QIFReferenceActiveType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class QIFReferenceType : QIFReferenceBaseType
	{
        private QIFReferenceSimpleType xidField;
        public QIFReferenceType() { }
		public QIFReferenceType(System.UInt32 value) : base(value) { }

		/// Implicit conversion from System.UInt32 to UInt32Type 
		public static implicit operator QIFReferenceType(System.UInt32 value)
		{
			return new QIFReferenceType(value);
		}

        /// <remarks The optional xId attribute is a reference to the id of a QIF
        /// object in an external document.A QIF object in an external
        /// QIF document can be referenced by using references to two QIF ids: 
        /// the id of the external document reference of type ExternalQIFDocumentReferenceType found in the local document
        /// and the id of the object found in the external document./>
        [System.Xml.Serialization.XmlAttributeAttribute("xId")]
        public uint XId 
        { 
            get => this.xidField; 
            set => this.xidField = value; 
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XIdSpecified { get; set; }
    }

    /// <summary>
    /// The QIFReferenceSimpleType defines the type for simple references
    /// to 'id' attributes.It has no external id and no asm path.
    /// </summary>
    public class QIFReferenceSimpleType : QIFReferenceBaseType
	{
		public QIFReferenceSimpleType() { }
		public QIFReferenceSimpleType(System.UInt32 value) : base(value) { }

		/// Implicit conversion from System.UInt32 to UInt32Type 
		public static implicit operator QIFReferenceSimpleType(System.UInt32 value)
		{
			return new QIFReferenceSimpleType(value);
		}
	}

    /// <remarks The ArrayBinaryQIFReferenceType defines a binary array of references to the QIF ids of other objects./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArrayBinaryQIFReferenceFullType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayBinaryQIFReferenceType
    {
        /// <remarks This compositor allows for a choice between an array of
        /// references to QIF ids in the local document, or an array of references to QIF ids in an external document./>
        [System.Xml.Serialization.XmlElementAttribute("Id", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("Ids", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlElementAttribute("XIds", typeof(ArrayBinaryType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public RefChoiceType[] ItemsElementName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum RefChoiceType
    {
        Id,
        Ids,
        XIds,
    }

    /// <remarks The ListQIFReferenceSimpleType is an array of references to QIF ids./>
    public class ListQIFReferenceSimpleType : QIFReferenceSimpleType
    {
    }

    /// <remarks The ListQIFReferenceType defines a set of references to the QIF ids
    /// of other objects.The other objects are either all in the local
    /// QIF document or all in the same external QIF document./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListQIFReferenceFullType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListQIFReferenceType
    {
        /// <remarks This compositor allows for a choice between a list of QIF ids in
        /// the local document, or a list of external QIF ids in separate document./>
        [System.Xml.Serialization.XmlElementAttribute("Id", typeof(QIFReferenceSimpleType))]
        [System.Xml.Serialization.XmlElementAttribute("Ids", typeof(ListQIFReferenceSimpleType))]
        [System.Xml.Serialization.XmlElementAttribute("XIds", typeof(ListQIFReferenceSimpleType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public QIFReferenceBaseType[] Items { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public RefChoiceType[] ItemsElementName { get; set; }

        /// <remarks The required n attribute is the number of QIF id references in this list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The QIFReferenceActiveType is a reference to a QIFId with defined activity./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFReferenceActiveType : QIFReferenceType
    {
        /// <remarks The active attribute defines whether the reference is active./>
        [System.Xml.Serialization.XmlAttributeAttribute("active")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Active { get; set; } = false;
    }
}
