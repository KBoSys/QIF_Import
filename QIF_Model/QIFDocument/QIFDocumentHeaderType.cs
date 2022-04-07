/*! \file QIFDocumentHeaderType.cs
    \brief The HeaderType contains information about the generation of this QIF document.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentHeaderType
    {
        /// <summary>
        /// The optional Application element is the information about the
        /// software application wherein the QIF document was most recently edited.
        /// </summary>
        [XmlElement]
        public ApplicationType Application { get; set; }

        /// <summary>
        /// The optional Author element is the author who generating this QIF document.
        /// </summary>
        [XmlElement]
        public AuthorType Author { get; set; }

        /// <summary>
        /// The optional ApplicationSource element is the information about
        /// the software application wherein the QIF document was created.
        /// </summary>
        [XmlElement]
        public ApplicationType ApplicationSource { get; set; }

        /// <remarks The optional Description element is a description of this QIF document./>
        [XmlElement]
        public string Description { get; set; }

        /// <summary>
        /// The optional Scope element defines the scope of this QIF
        /// document.Examples include: "Results","Plan", "Plan+Results",
        /// "MBD", "MBD+Plan+Results+Statistics", "Plan+External Product
        /// Definition". The scope of a QIF document can be determined from
        /// the optional elements that are present. This element allows for
        /// a concise, human-readable summary of the scope to appear near
        /// the beginning of a QIF document.
        /// </summary>
        [XmlElement]
        public string Scope { get; set; }
    }
}
