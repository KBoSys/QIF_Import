/*! \file SimplePrimitives.cs
    \brief Defines Simple geometric primitives

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.ComponentModel;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The Point2dSimpleType is an array of two double values used to
    /// represent a 2D point.The first entry in the list is the X value
    /// and the second entry is the Y value.
    /// </summary>
	public class Point2dSimpleType : D2Type
    {
        public Point2dSimpleType() { }
    }

    /// <summary>
    /// The UnitVector2dSimpleType is an array of two double values.used
    /// to represent a 2D unit vector. The first entry in the list is the X
    /// component(I) and the second entry is the Y component (J). A
    /// UnitVector2dSimpleType should be of unit length to the limits of
    /// accuracy of the executing system, and in any event must not be less
    /// than 0.99999999 or greater than 1.00000001.
    /// </summary>
	public class UnitVector2dSimpleType : D2Type
    {
        public UnitVector2dSimpleType() { }
    }

    /// <summary>
    /// The ParameterRangeBoundsType is an array of two double values used
    /// to represent parameter bounds.The first entry in the list is the
    /// first bound of the parameter, and the second entry is the second
    /// bound.The second entry must be larger or smaller than the first.
    /// </summary>
    public class ParameterRangeType : D2Type
    {
        public ParameterRangeType() { }
    }

    /// <summary>
    /// The PointSimpleType is an array of three double values used to
    /// represent the Cartesian three-dimensional coordinates.The first
    /// entry in the list is the X value, the second entry is the Y value,
    /// and the third entry is the Z value.
    /// </summary>
    public class PointSimpleType : D3Type
    {
        public PointSimpleType() { }

        #region Point Accessors
        [XmlIgnore]
        public double X { get => base.Value[0]; set => base.Value[0] = value; }
        [XmlIgnore]
        public double Y { get => base.Value[1]; set => base.Value[1] = value; }
        [XmlIgnore]
        public double Z { get => base.Value[2]; set => base.Value[2] = value; }
        #endregion Point Accessors
    }

    /// <summary>
    /// The VectorSimpleType is an array of three double values used to
    /// represent a 3D vector.The first entry in the list is the X
    /// component(I), the second entry is the Y component(J), and the
    /// third entry is the Z component(K).
    /// </summary>
    public class VectorSimpleType : D3Type
    {
        public VectorSimpleType() { }
    }

    /// <summary>
    /// The UnitVectorSimpleType is an array of three double values.used
    /// to represent a 3D unit vector. The first entry in the list is the X
    /// component(I), the second entry is the Y component (J), and the
    /// third entry is the Z component (K). A UnitVectorSimpleType should
    /// be of unit length to the limits of accuracy of the executing
    /// system, and in any event must not be less than 0.99999999 or
    /// greater than 1.00000001.
    /// </summary>
    public class UnitVectorSimpleType : D3Type
    {
        public UnitVectorSimpleType() { }
    }


    /// <summary>
    /// The ValidityEnumType enumerates values that describe the validity
    /// of a coordinate or set of coordinates.A coordinate can be present
    /// and correct in a report(REPORTED). A coordinate may be missing
    /// from a report but will have a value determined by one of several
    /// means: it may be an arbitrary value(DUMMY), it may be an arbitrary
    /// value that is meaningless such as the third coordinate in
    /// two-dimensional measurement(MOOT), it may be derived(calculated)
    /// from other values(DERIVED), or it may be set to a value(SET)
    /// typically the nominal value.
    /// </summary>
    public enum ValidityEnumType
    {
        [Description("REPORTED")]
        REPORTED,
        [Description("DUMMY")]
        DUMMY,
        [Description("MOOT")]
        MOOT,
        [Description("DERIVED")]
        DERIVED,
        [Description("SET")]
        SET,
    }

    /// <summary>
    /// The PointType defines an XYZ location in which the length units and
    /// accuracy of the coordinates may be specified.
    /// </summary>
    [XmlRoot]
    public class PointType : PointSimpleType
    {
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

    /// <summary>
    /// The VectorType defines a vector in which the length units and
    /// accuracy of the components may be specified.
    /// </summary>
    [XmlRoot]
    public class VectorType : VectorSimpleType
    {
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

    /// <summary>
    /// The UnitVectorType is a unit vector in which the accuracy of the
    /// components may be specified.The linearUnit attribute included in
    /// AttrPoint must not be used since unit vectors do not have length units.
    /// </summary>
    [XmlRoot]
    public class UnitVectorType : UnitVectorSimpleType
    {
        public AttrPoint? AttrPoint { get; set; }
    }

    /// <summary>
    /// The ArrayPointType is an array of doubles representing a specific number of ordered 2D points.
    /// Each successive group of two entries in the array represents the X, and Y coordinates of a point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayPoint2dType : ListDoubleType
    {
        public ArrayPoint2dType() { }

        /// <summary>
        /// The required count attribute is the number of points
        /// represented by the array.The number of entries in the array must be 2*count.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public override uint Count
        {
            get => base.Value != null ? (uint)base.Value.Length / 2 : 0;
            set { } // => base.Value = new double[2 * value]; 
        }
    }

    /// <summary>
    /// The ArrayUnitVectorType is an array of doubles representing a
    /// specific number of ordered unit vectors.Each successive group of
    /// three entries in the array represents the X, Y, and Z components of
    /// a unit vector.The linearUnit attribute included in AttrPoint must
    /// not be used since unit vectors do not have length units.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayUnitVectorType : ListDoubleType
    {
        public ArrayUnitVectorType() { }

        /// <summary>
        /// The required count attribute gives the number of points
        /// represented by the array.The number of entries in the array
        /// must be 3*count.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public override uint Count
        {
            get => base.Value != null ? (uint)base.Value.Length / 3 : 0;
            set { } // => base.Value = new double[3 * value];
        }
    }
}
