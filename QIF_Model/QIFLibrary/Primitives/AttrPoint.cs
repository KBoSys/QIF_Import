/*! \file AttrPoint.cs
    \brief attributes for length unit and measures

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The AttrPoint attributeGroup provides attributes for length unit
    /// and measures of the accuracy of the coordinates or components of 3D
    /// points and vectors.Accuracy may be specified that applies to all
    /// three values(X, Y and Z) and/or accuracy may be specified
    /// individually for X, Y, and Z.If both types of accuracy are given,
    /// the individual values should be used, not the group value.
    /// </summary>
	[System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute()]
    public class AttrPoint
    {
        [XmlAttribute("linearUnit", DataType = "token")]
        public string LinearUnit { get; set; }

        [XmlAttribute("decimalPlaces")]
        public uint DecimalPlaces { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DecimalPlacesSpecified { get; set; }

        [XmlAttribute("significantFigures")]
        public uint SignificantFigures { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SignificantFiguresSpecified { get; set; }

        [XmlAttribute("validity")]
        public ValidityEnumType Validity { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValiditySpecified { get; set; }

        [XmlAttribute("xDecimalPlaces")]
        public uint XDecimalPlaces { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XDecimalPlacesSpecified { get; set; }

        [XmlAttribute("xSignificantFigures")]
        public uint XSignificantFigures { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSignificantFiguresSpecified { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("xValidity")]
        public ValidityEnumType XValidity { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XValiditySpecified { get; set; }

        [XmlAttribute("yDecimalPlaces")]
        public uint YDecimalPlaces { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YDecimalPlacesSpecified { get; set; }

        [XmlElement("ySignificantFigures")]
        public uint YSignificantFigures { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YSignificantFiguresSpecified { get; set; }

        [XmlAttribute("yValidity")]
        public ValidityEnumType YValidity { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YValiditySpecified { get; set; }

        [XmlAttribute("zDecimalPlaces")]
        public uint ZDecimalPlaces { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZDecimalPlacesSpecified { get; set; }

        [XmlAttribute("zSignificantFigures")]
        public uint ZSignificantFigures { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZSignificantFiguresSpecified { get; set; }

        [XmlAttribute("zValidity")]
        public ValidityEnumType ZValidity { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZValiditySpecified { get; set; }
    }

}
