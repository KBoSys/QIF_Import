/*! \file VersionBaseType.cs

        The SignOffsType defines a list of one or more employees who have
        signed off on a particular version of something.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SignOffsType : ArrayBaseType<EmployeeType>
    {
        /// <remarks> Each Employee element is employee information for one employee involved in the sign off.</remarks>
        [XmlElement(ElementName = "Employee", Type = typeof(EmployeeType))]
        public EmployeeType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
