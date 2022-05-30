/*! \file QIFReferenceType.cs

        The QIFReferenceType defines a reference to a QIF id that may be in
        the same file as the reference or may be in an identified external
        file. In order to ensure that each reference refers to an object of
        the correct type, where possible, each reference is covered by an
        appropriate key/keyref constraint.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
	public class QIFReferenceType : QIFReferenceBaseType
	{
		public QIFReferenceType() { }
		public QIFReferenceType(System.UInt32 value) : base(value) { }

		/// Implicit conversion from System.UInt32 to UInt32Type 
		public static implicit operator QIFReferenceType(System.UInt32 value)
		{
			return new QIFReferenceType(value);
		}
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

        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
        public enum RefChoiceType
        {
            Id,
            Ids,
            XIds,
        }
    }
}
