/*! \file EmployeeType.cs
	\brief The EmployeeType defines employee information.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class EmployeeType
    {
        public EmployeeType() { }

        /// <remarks The Name element is the name of the employee./>
        [XmlElement]
        public string Name { get; set; }

        /// <remarks The optional EmployeeId element is the company id number of the employee./>
        [XmlElement]
        public string EmployeeId { get; set; }

        /// <remarks The optional Shift element is the shift number of the employee./>
        [XmlElement]
        public string Shift { get; set; }
    }
}
