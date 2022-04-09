/*! \file DigitalModelFormatType.cs
    \brief The DigitalModelFormatType defines the format of a digital model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFDocument.Primitives;
using QIF_Model.QIFDocument.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.PrimitivesPMI
{
    //! The DigitalModelFormatEnumType enumerates values that describe the format of a digital model.
    public enum DigitalModelFormatEnumType
    {
      STEPAP203,
      STEPAP203E2,
      STEPAP214,
      STEPAP242,
      JTOPEN,
      RPC,
      PDPMI,
      ACIS,
      PARASOLID,
      AUTODESK,
      PTC,
      NX,
      SOLIDWORKS,
      CATIA,
      NOTDEFINED,
	}

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DigitalModelFormatType
	{
        public DigitalModelFormatType() { }

        //! The DigitalModelFormatEnum element describes an often-used format of a digital model.
        [XmlElement]
        public DigitalModelFormatEnumType DigitalModelFormatEnum { get; set; }

        //! The OtherDigitalModelFormat element describes the format of a digital model in natural language.
        [XmlElement]
        public string OtherDigitalModelFormat { get; set; }
    }
}
