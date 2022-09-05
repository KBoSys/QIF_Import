/*! \file UserDefinedUnits.cs
    \brief The UserDefinedUnitsType defines a set of user-defined units.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Units
{
    /// <remarks></remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnitsType : ArrayBaseType<UserDefinedUnitType>
    {
        /// <remarks> Each UserDefinedUnit element describes a single user-defined unit.</remarks>
        [XmlElement("UserDefinedUnit", Type = typeof(UserDefinedUnitType))]
        public UserDefinedUnitType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}

