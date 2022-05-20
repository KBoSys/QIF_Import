/*! \file VersionBaseType.cs

        The SignOffsType defines a list of one or more employees who have
        signed off on a particular version of something.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class SignOffsType
	{
		public SignOffsType() { }

		/// <remarks Each Employee element is employee information for one employee involved in the sign off./>
		[XmlElement(ElementName = "Employee", Type = typeof(EmployeeType))]
		public EmployeeType[] Employees { get; set; }

		/// <remarks The required n attribute is the number of employees in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Employees.Length;
			set { }
		}
	}
}
