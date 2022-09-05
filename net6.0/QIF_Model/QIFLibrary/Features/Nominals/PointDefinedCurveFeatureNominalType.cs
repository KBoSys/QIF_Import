/*! \file PointDefinedCurveFeatureNominalType.cs
    \brief Defines the point-defined curve feature nominal information for an individual point-defined curve feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The PointDefinedCurveFeatureNominalType defines the point-defined
    /// curve feature nominal information for an individual point-defined curve feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The DefiningPoints element gives a list of points which
        /// defines the nominal point-defined curve.The nominal
        /// point-defined curve passes through these points.</remarks>
        public DefiningPointsNominalType? DefiningPoints { get; set; }

        /// <remarks> The optional Plane element is the plane in which the point-defined curve feature lies.</remarks>
        public PlaneType? Plane { get; set; }

        /// <remarks> The optional Constructed element signifies that the point
        /// defined curve is constructed and provides details of the construction method.</remarks>
        public PointDefinedCurveConstructionMethodType? Constructed { get; set; }
    }

    /// <remarks> The DefiningPointsNominalType defines an ordered list of nominal feature defining points.</remarks>
    public partial class DefiningPointsNominalType : ArrayBaseType<DefiningPointNominalType>
    {
        /// <remarks> Each DefiningPoint element is a nominal point on a nominal point-defined curve or a nominal point-defined surface.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DefiningPoint")]
        public DefiningPointNominalType[] Items { get => base.itemsField; set => base.itemsField = value; }

        /// <remarks> The AttrPoint attribute group defines accuracies common to all measurement points for a feature.</remarks>
        #region ref="AttrPoint"
        private AttrPoint attr = new AttrPoint();

        [XmlAttribute("linearUnit", DataType = "token")]
        public string? LinearUnit { get => attr.LinearUnit; set => attr.LinearUnit = value; }

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