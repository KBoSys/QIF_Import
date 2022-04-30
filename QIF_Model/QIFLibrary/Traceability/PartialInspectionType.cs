/*! \file PartialInspectionType.cs
    \brief The PartialInspectionType defines the rationale for a partial inspection. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Traceability
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PartialInspectionType
	{
        public PartialInspectionType() { }

        /// <summary>
        /// The BaselineProductNumber element gives an identifier of a
        /// product that has had a previous inspection(such as FAI) and is
        /// of the same type as the one being subjected to partial inspection.
        /// </summary>
        [XmlElement]
        public string BaselineProductNumber { get; set; }

        /// <summary>
        /// The optional BaselineProductVersion element is the version of
        /// the product that had a previous inspection.
        /// </summary>
        [XmlElement]
        public string BaselineProductVersion { get; set; }

        /// <summary>
        /// The ReasonForPartialInspection element is the reason for a
        /// partial inspection, for example, changes in design, process,
        /// manufacturing location, etc.
        /// </summary>
        [XmlElement]
        public string ReasonForPartialInspection { get; set; }
    }
}
