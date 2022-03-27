/*! \file UserDefinedUnits.cs
    \brief An array with all user defined units

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument.FileUnits
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnits
    {

        private UserDefinedUnit[] userDefinedUnitField;
        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnit")]
        public UserDefinedUnit[] UserDefinedUnit
        {
            get => this.userDefinedUnitField;
            set => this.userDefinedUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte n
        {
            get => this.nField;
            set => this.nField = value;
        }
    }
}

