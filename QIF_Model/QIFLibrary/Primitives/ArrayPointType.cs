/*! \file ArrayPointType.cs
    \brief an array of doubles representing a specific number of ordered 3D points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The ArrayPointType is an array of doubles representing a specific number of ordered 3D points. 
    /// Each successive group of three entries in the array represents the X, Y, and Z coordinates of a point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayPointType
    {
        PointSimpleType[] points;

        [System.Xml.Serialization.XmlIgnore]
        public PointSimpleType[] Points { get => this.points; set => this.points = value; }

        #region Serialization
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Text
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

        public void FromString(string value)
        {
            var parts = Regex.Split(value, @"\s+");

            int cnt = parts.Length;
            if (cnt >= 3)
            {
                int numPoints = cnt / 3;
                List<PointSimpleType> pointsList = new List<PointSimpleType>();

                for (int i = 0; i < cnt; )
                {
                    double[] pt = new double[3] { 0.0, 0.0, 0.0 };

                    int j = 0;
                    for (; j < 3 && i < cnt; ++i) 
                    {
                        if (double.TryParse(parts[i], out pt[j]))
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
        #endregion
    }

    /// <remarks The PolyLineType defines a polyline as an ordered list of points.
    /// The polyline is a continuous path consisting of line segments from
    /// point 1 to point 2, point 2 to point 3, etc.A polyline is not
    /// necessarily closed.To make a closed polyline, the last point
    /// should be the same as the first./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class PolyLineType : ArrayPointType
    {
    }
}
