﻿/*! \file ArrayReferenceFullType.cs
	\brief The ArrayReferenceFullType is an array of references to object IDs.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ArrayReferenceFullType
	{
		public ArrayReferenceFullType() { }
		/// <remarks The Id element is a reference to a QIF id that may include an AsmPath./>
		[XmlElement(ElementName = "Id", Type = typeof(QIFReferenceFullType))]
		public List<QIFReferenceFullType> References { get; set; }

		/// <remarks The required n attribute is the number of full reference types in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.References.Count;
			set { }
		}
    }

    /// <remarks The ArrayBinaryQIFReferenceFullType defines a binary array of the
    /// QIF ids of other objects with an optional assembly path to define a
    /// 'full' reference which is used for locating entities within an assembly./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayBinaryQIFReferenceFullType : ArrayBinaryQIFReferenceType
    {
        /// <remarks The optional asmPathId attribute is a reference used for
        /// locating the id of an assembly path.If the asmPathXId
        /// attribute is not used, the asmPathId is a reference to an
        /// assembly path in the AsmPaths of the local document.If the
        /// asmPathXId is used, the asmPathId is the local id of an
        /// external QIF document, and the asmPathXId is a reference to
        /// an assembly path in the external QIF document. The assembly
        /// path(instantiation chain) unambiguously identifies a model
        /// entity within an assembly./>
        [System.Xml.Serialization.XmlAttributeAttribute("asmPathId")]
        public QIFReferenceSimpleType AsmPathId { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AsmPathIdSpecified { get; set; }

        /// <remarks The optional asmPathXId attribute, if used, is a reference to
        /// the id of an assembly path in the external document
        /// identified by the asmPathId.The asmPathXId must not be used
        /// if the asmPathId is not used./>
        [System.Xml.Serialization.XmlAttributeAttribute("asmPathXId")]
        public QIFReferenceSimpleType AsmPathXId { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AsmPathXIdSpecified { get; set; }
    }
}
