/*! \file UserDefinedUnits.cs
    \brief The UserDefinedUnitsType defines a set of user-defined units.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Units
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnitsType
    {
        /// <remarks Each UserDefinedUnit element describes a single user-defined unit./>
        [XmlElement("UserDefinedUnit", Type = typeof(UserDefinedUnitType))]
        public UserDefinedUnitType[] UserDefinedUnits { get; set; }

        /// <remarks The required n attribute is the number of user-defined units in the set./>
        [XmlAttribute("n")]
        public int Count
        {
            get => UserDefinedUnits.Length;
            set { }
        }
    }
}

