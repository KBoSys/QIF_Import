/*! \file SimplePrimitives.cs
    \brief Defines Simple geometric primitives

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
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
    /// The AttrPoint attributeGroup provides attributes for length unit
    /// and measures of the accuracy of the coordinates or components of 3D
    /// points and vectors.Accuracy may be specified that applies to all
    /// three values(X, Y and Z) and/or accuracy may be specified
    /// individually for X, Y, and Z.If both types of accuracy are given,
    /// the individual values should be used, not the group value.
    /// </summary>
	[System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class AttrPoint
	{
        [XmlElement("linearUnit", DataType = "token")]
        public System.String LinearUnit { get; set; }
    
        [XmlElement("decimalPlaces")]
        public NonNegativeInteger DecimalPlaces { get; set; }

        [XmlElement("significantFigures")]
        public NonNegativeInteger SignificantFigures { get; set; }

        [XmlElement("validity")]
        public ValidityEnumType Validity { get; set; }

        [XmlElement("xDecimalPlaces")]
        public NonNegativeInteger XDecimalPlaces { get; set; }

        [XmlElement("xSignificantFigures")]
        public NonNegativeInteger XSignificantFigures { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("xValidity")]
        public ValidityEnumType XValidity { get; set; }

        [XmlElement("yDecimalPlaces")]
        public NonNegativeInteger YDecimalPlaces { get; set; }

        [XmlElement("ySignificantFigures")]
        public NonNegativeInteger YSignificantFigures { get; set; }

        [XmlElement("yValidity")]
        public ValidityEnumType YValidity { get; set; }

        [XmlElement("zDecimalPlaces")]
        public NonNegativeInteger ZDecimalPlaces { get; set; }

        [XmlElement("zSignificantFigures")]
        public NonNegativeInteger ZSignificantFigures { get; set; }

        [XmlElement("zValidity")]
        public ValidityEnumType ZValidity { get; set; }
    }

    /// <summary>
    /// The PointType defines an XYZ location in which the length units and
    /// accuracy of the coordinates may be specified.
    /// </summary>
    [XmlRoot]
    public class PointType : PointSimpleType
	{
        public PointType() { }
        [XmlElement("AttrPoint")]
        public AttrPoint AttrPoint { get; set; }
    }

    /// <summary>
    /// The VectorType defines a vector in which the length units and
    /// accuracy of the components may be specified.
    /// </summary>
    [XmlRoot]
    public class VectorType : VectorSimpleType
    {
        public VectorType() { }

        [XmlElement("AttrPoint")]
        public AttrPoint AttrPoint { get; set; }
    }

    /// <summary>
    /// The UnitVectorType is a unit vector in which the accuracy of the
    /// components may be specified.The linearUnit attribute included in
    /// AttrPoint must not be used since unit vectors do not have length units.
    /// </summary>
    [XmlRoot]
    public class UnitVectorType : UnitVectorSimpleType
    {
        public UnitVectorType() { }

        [System.Xml.Serialization.XmlAttributeAttribute("AttrPoint")]
        public AttrPoint AttrPoint { get; set; }
    }

    /// <summary>
    /// The ArrayPointType is an array of doubles representing a specific
    /// number of ordered 2D points.Each successive group of two entries
    /// in the array represents the X, and Y coordinates of a point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayPoint2dType : ListDoubleType
    {
        public ArrayPoint2dType(uint numPoints) : base(2 * numPoints) { }

        /// <summary>
        /// The required count attribute is the number of points
        /// represented by the array.The number of entries in the array must be 2*count.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public UInt32 Count 
        { 
            get => (UInt32)Value.Length / 2; 
            set => base.Value = new double[2 * value]; 
        }
    }

    /// <summary>
    /// The ArrayPointType is an array of doubles representing a specific
    /// number of ordered 3D points.Each successive group of three entries
    /// in the array represents the X, Y, and Z coordinates of a point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayPointType : ListDoubleType
    {
        public ArrayPointType(uint numPoints) : base(3 * numPoints) { }

        /// <summary>
        /// The required count attribute gives the number of points
        /// represented by the array.The number of entries in the array
        /// must be 3*count.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public UInt32 Count
        {
            get => (UInt32)Value.Length / 3;
            set => base.Value = new double[3 * value];
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayUnitVectorType : ListDoubleType
    {
        public ArrayUnitVectorType(uint numPoints) : base(3 * numPoints) { }

        /// <summary>
        /// The required count attribute gives the number of points
        /// represented by the array.The number of entries in the array
        /// must be 3*count.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public UInt32 Count
        {
            get => (UInt32)Value.Length / 3;
            set => base.Value = new double[3 * value];
        }
    }
}
