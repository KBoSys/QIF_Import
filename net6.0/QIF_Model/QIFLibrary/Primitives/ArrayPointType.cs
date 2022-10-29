/*! \file ArrayPointType.cs
    \brief an array of doubles representing a specific number of ordered 3D points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The ArrayPointType is an array of doubles representing a specific number of ordered 3D points. 
    /// Each successive group of three entries in the array represents the X, Y, and Z coordinates of a point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayPointNoCountType
    {
        PointSimpleType[]? points;

        [System.Xml.Serialization.XmlIgnore]
        public PointSimpleType[]? Points { get => this.points; set => this.points = value; }

        #region Serialization
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string? Text
        {
            get => this.ToString();
            set => this.FromString(value);
        }

        public override string ToString()
        {
            string text = "";
            if (this.points != null)
            {
                text = "\n\t";
                text += string.Join<PointSimpleType>("\n\t", this.points);
                text += "\n\t";
            }
            return text;
        }

        public void FromString(string? value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var parts = Regex.Split(value, @"\s+");

                int cnt = parts.Length;
                if (cnt >= 3)
                {
                    int numPoints = cnt / 3;
                    List<PointSimpleType> pointsList = new List<PointSimpleType>();

                    for (int i = 0; i < cnt;)
                    {
                        //double[] pt = new double[3] { 0.0, 0.0, 0.0 };
                        PointSimpleType pt = new PointSimpleType();

                        int j = 0;
                        for (; j < 3 && i < cnt; ++i)
                        {
                            if (double.TryParse(parts[i], out pt.Value[j]))
                            {
                                ++j;
                            }
                        }
                        if (j == 3)
                        {
                            pointsList.Add(pt);
                        }
                    }

                    this.points = pointsList.ToArray();
                }
            }
        }
        #endregion

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

    public class ArrayPointType : ArrayPointNoCountType
    {
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint Count
        {
            get => base.Points != null ? (uint)base.Points.Length : 0;
            set { }
        }

    }

    /// <remarks> The PolyLineType defines a polyline as an ordered list of points.
    /// The polyline is a continuous path consisting of line segments from
    /// point 1 to point 2, point 2 to point 3, etc.A polyline is not
    /// necessarily closed.To make a closed polyline, the last point
    /// should be the same as the first.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class PolyLineType : ArrayPointType
    {
    }
}
