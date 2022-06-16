/*! \file TransformMatrixType.cs
	\brief Defines a three dimensional transformation matrix

        For any point, if:
        1. The coordinates of the point in the "before" coordinate system
           are x, y, and z.
        2. The coordinates of the point in the "after" coordinate system
           are X, Y, and Z.
        3. The components of the XDirection are Xi, Xj, and Xk.
        4. The components of the YDirection are Yi, Yj, and Yk.
        5. The components of the ZDirection are Zi, Zj, and Zk.
        6. The Cartesian coordinates of the Origin are Ox, Oy, and Oz.
        Then the following transformation equations hold.
          X = (Xi)x + (Yi)y + (Zi)z + Ox
          Y = (Xj)x + (Yj)y + (Zj)z + Oy
          Z = (Xk)x + (Yk)y + (Zk)z + Oz

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
	/// <summary>
	/// The TransformMatrixType defines a three dimensional
	/// transformation that may include rotation and translation, but
	/// not scaling.The vectors of the Rotation are unit vectors.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class TransformMatrixType : CoordinateSystemCoreType
    {
		public TransformMatrixType() { }

        /// <summary>
        /// The optional AttrPoint attribute gives attributes of the
        /// point that is the Origin.This may include a linearUnit, an
        /// accuracy, etc.
        /// </summary>
        #region ref="AttrPoint"
        private AttrPoint attr = new AttrPoint();

        [XmlAttribute("linearUnit", DataType = "token")]
        public string LinearUnit { get => attr.LinearUnit; set => attr.LinearUnit = value; }

        [XmlAttribute("decimalPlaces")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint DecimalPlaces { get => attr.DecimalPlaces; set => attr.DecimalPlaces = value; }

        [XmlAttribute("significantFigures")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint SignificantFigures { get => attr.SignificantFigures; set => attr.SignificantFigures = value; }

        [XmlAttribute("validity")]
        public ValidityEnumType Validity { get => attr.Validity; set => attr.Validity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValiditySpecified { get; set; }

        [XmlAttribute("xDecimalPlaces")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint XDecimalPlaces { get => attr.XDecimalPlaces; set => attr.XDecimalPlaces = value; }

        [XmlAttribute("xSignificantFigures")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint XSignificantFigures { get => attr.XSignificantFigures; set => attr.XSignificantFigures = value; }

        [System.Xml.Serialization.XmlAttributeAttribute("xValidity")]
        public ValidityEnumType XValidity { get => attr.XValidity; set => attr.XValidity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XValiditySpecified { get; set; }

        [XmlAttribute("yDecimalPlaces")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint YDecimalPlaces { get => attr.YDecimalPlaces; set => attr.YDecimalPlaces = value; }

        [XmlElement("ySignificantFigures")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint YSignificantFigures { get => attr.YSignificantFigures; set => attr.YSignificantFigures = value; }

        [XmlAttribute("yValidity")]
        public ValidityEnumType YValidity { get => attr.YValidity; set => attr.YValidity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YValiditySpecified { get; set; }

        [XmlAttribute("zDecimalPlaces")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint ZDecimalPlaces { get => attr.ZDecimalPlaces; set => attr.ZDecimalPlaces = value; }

        [XmlAttribute("zSignificantFigures")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint ZSignificantFigures { get => attr.ZSignificantFigures; set => attr.ZSignificantFigures = value; }

        [XmlAttribute("zValidity")]
        public ValidityEnumType ZValidity { get => attr.ZValidity; set => attr.ZValidity = value; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZValiditySpecified { get; set; }
        #endregion
    }
}
