/*! \file QIFReferenceFullType.cs

        The QIFReferenceFullType defines a 'full' reference which is used
        for locating an entity within an assembly.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
	public class QIFReferenceFullType : QIFReferenceType
    {
        private QIFReferenceSimpleType asmPathIdField = new QIFReferenceSimpleType();
        private QIFReferenceSimpleType asmPathXIdField = new QIFReferenceSimpleType();

        public QIFReferenceFullType() { }

        /// <summary>
        /// The optional asmPathId attribute is a reference used for
        /// locating the id of an assembly path.If the asmPathXId
        /// attribute is not used, the asmPathId is a reference to an
        /// assembly path in the AsmPaths of the local document.If the
        /// asmPathXId is used, the asmPathId is the local id of an
        /// external QIF document, and the asmPathXId is a reference to
        /// an assembly path in the external QIF document. The assembly
        /// path(instantiation chain) unambiguously identifies a model
        /// entity within an assembly.
		/// </summary>
        [XmlAttribute("asmPathId")]
        public uint AsmPathId { get => this.asmPathIdField; set => this.asmPathIdField = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AsmPathIdSpecified { get; set; }

        /// <summary>
        /// The optional asmPathXId attribute, if used, is a reference to
        /// the id of an assembly path in the external document
        /// identified by the asmPathId.The asmPathXId must not be used
        /// if the asmPathId is not used.
        /// </summary>
        [XmlAttribute("asmPathXId")]
        public uint AsmPathXId { get => this.asmPathXIdField; set => this.asmPathXIdField = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AsmPathXIdSpecified { get; set; }
    }

    /// <remarks The ListQIFReferenceFullType defines a list of unsigned integers
    /// with no leading zeros referencing the QIF ids of other objects with
    /// an optional assembly path to define a 'full' reference which is
    /// used for locating entities within an assembly./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListQIFReferenceFullType : ListQIFReferenceType
    {
        private QIFReferenceSimpleType asmPathIdField = new QIFReferenceSimpleType();
        private QIFReferenceSimpleType asmPathXIdField = new QIFReferenceSimpleType();

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
        public uint AsmPathId { get => this.asmPathIdField; set => this.asmPathIdField = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AsmPathIdSpecified { get; set; }

        /// <remarks The optional asmPathXId attribute, if used, is a reference to
        /// the id of an assembly path in the external document
        /// identified by the asmPathId.The asmPathXId must not be used if the asmPathId is not used./>
        [System.Xml.Serialization.XmlAttributeAttribute("asmPathXId")]
        public uint AsmPathXId { get => this.asmPathXIdField; set => this.asmPathXIdField = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AsmPathXIdSpecified { get; set; }
    }
}
