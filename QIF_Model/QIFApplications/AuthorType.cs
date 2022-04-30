/*! \file AuthorType.cs
    \brief The AuthorType contains information about the author.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AuthorType
    {
        /// <remarks The optional Author element is the name of the person./>
        [XmlElement]
        public string Name { get; set; }

        /// <remarks The optional Organization element is the name of author's organization./>
        [XmlElement]
        public string Organization { get; set; }
    }
}
