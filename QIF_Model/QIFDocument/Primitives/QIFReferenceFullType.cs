/*! \file QIFReferenceFullType.cs

        The QIFReferenceFullType defines a 'full' reference which is used
        for locating an entity within an assembly.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
{
	public class QIFReferenceFullType //: QIFReferenceType
	{
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
        [XmlIgnore]
        public QIFReferenceSimpleType AsmPathId { get; set; }
        [XmlAttribute("asmPathId")]
		public System.UInt32 AsmPathIdUInt { get => this.AsmPathId; set => this.AsmPathId=value; }

        /// <summary>
        /// The optional asmPathXId attribute, if used, is a reference to
        /// the id of an assembly path in the external document
        /// identified by the asmPathId.The asmPathXId must not be used
        /// if the asmPathId is not used.
        /// </summary>
        [XmlIgnore]
        public QIFReferenceSimpleType AsmPathXId { get; set; }
        [XmlAttribute("asmPathXId")]
        public System.UInt32 AsmPathXIdUInt { get => this.AsmPathXId; set => this.AsmPathXId = value; }
    }
}
