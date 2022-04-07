/*! \file ApplicationType.cs
    \brief The ApplicationType contains information about the application.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ApplicationType
    {
        /// <summary>
        /// The Name element is the name of the software application.
        /// </summary>
        [XmlElement]
        public string Name { get; set; }

        /// <summary>
        /// The optional Organization element is the name of the
        /// organization that created the software application.
        /// </summary>
        [XmlElement]
        public string Organization { get; set; }

        /// <summary>
        /// The optional AddonName element is the name of the software
        /// add-on application.
        /// </summary>
        [XmlElement]
        public string AddonName { get; set; }

        /// <summary>
        /// The optional AddonOrganization element is the name of the
        /// organization that created the software add-on application.
        /// </summary>
        [XmlElement]
        public string AddonOrganization { get; set; }
    }
}
