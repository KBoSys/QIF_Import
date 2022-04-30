﻿/*! \file PrimitivesPMI.cs
    
    PrimitivesPMI file defines a large number of
    miscellaneous types used in other QIF files.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <summary>
    /// The RectangularUnitAreaType defines a rectangular region.
    /// </summary>
  	[System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class RectangularUnitAreaType
    {
        /// <summary>
        /// The RectangularUnitAreaLength element is the length in linear
        /// units of the rectangular region.
        /// </summary>
        [XmlElement]
        LinearValueType RectangularUnitAreaLength { get; set; }

        /// <summary>
        /// The RectangularUnitAreaWidth element is the width in linear
        /// units of the rectangular region.
        /// </summary>
        [XmlElement]
        LinearValueType RectangularUnitAreaWidth { get; set; }

        /// <summary>
        /// The optional RectangularUnitAreaOrientation element is the
        /// direction of the rectangle's axis along the length of the rectangle.
        /// </summary>
        [XmlElement]
        UnitVectorType RectangularUnitAreaOrientation { get; set; }
    }
/*
  <xs:complexType name = "CircularUnitAreaType" >
    < xs:annotation>
      <xs:documentation>
        The CircularUnitAreaType defines a circular region.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "CircularUnitAreaDiameter"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The CircularUnitAreaDiameter element is the length in linear
            units of the diameter of the circular region.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:attributeGroup name = "AttrMeasuredPoint" >
    < xs:annotation>
      <xs:documentation>
        The AttrMeasuredPoint attributeGroup provides attributes for the
        combined uncertainty and mean error of measured 3D points and
        vectors.Uncertainty and/or error may be specified that applies to
        all three values (X, Y and Z) and/or uncertainty and/or error may
        be specified individually for X, Y, and Z.If both types of
        accuracy are given, the individual values should be used, not the
        group value.
      </xs:documentation>
    </xs:annotation>
    <xs:attribute name = "combinedUncertainty"
      type= "xs:decimal" />
    < xs:attribute name = "meanError"
      type= "xs:decimal" />
    < xs:attribute name = "xCombinedUncertainty"
      type= "xs:decimal" />
    < xs:attribute name = "xMeanError"
      type= "xs:decimal" />
    < xs:attribute name = "yCombinedUncertainty"
      type= "xs:decimal" />
    < xs:attribute name = "yMeanError"
      type= "xs:decimal" />
    < xs:attribute name = "zCombinedUncertainty"
      type= "xs:decimal" />
    < xs:attribute name = "zMeanError"
      type= "xs:decimal" />
  </ xs:attributeGroup>

  <xs:complexType name = "MeasuredPointType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredPointType defines an XYZ location in which the length
        units, accuracy, uncertainty and error of the coordinates may be
        specified.
      </xs:documentation>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base="PointType">
        <xs:attributeGroup ref= "AttrMeasuredPoint" />
      </ xs:extension>
    </xs:simpleContent>
  </xs:complexType>

  <xs:complexType name = "MeasuredUnitVectorType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredUnitVectorType is a unit vector in which the accuracy,
        uncertainty and error of the components may be specified.The
        linearUnit attribute included in AttrPoint must not be used since
        unit vectors do not have length units.
      </xs:documentation>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base="UnitVectorType">
        <xs:attributeGroup ref= "AttrMeasuredPoint" />
      </ xs:extension>
    </xs:simpleContent>
  </xs:complexType>

  <xs:complexType name = "MeasuredPlaneType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredPlaneType defines a measured plane by means of the plane
        unit normal vector and a point on the plane.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "Point"
        type= "MeasuredPointType" >
        < xs:annotation>
          <xs:documentation>
            The Point element is a measured point on the plane.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Normal"
        type= "MeasuredUnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Normal element is the measured unit normal vector of the
            plane.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "MeasuredAxisType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredAxisType defines a measured feature axis.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "AxisPoint"
        type= "MeasuredPointType" >
        < xs:annotation>
          <xs:documentation>
            The AxisPoint element is the measured location of a point on the
            axis.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Direction"
        type= "MeasuredUnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Direction element is the measured unit vector direction of
            the axis.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "MeasuredZoneAxisType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredZoneAxisType defines a measured axis with a length.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="MeasuredAxisType">
        <xs:sequence>
          <xs:element name = "Length"
            type= "MeasuredLinearValueType" >
            < xs:annotation>
              <xs:documentation>
                The Length element is the length of an axis or line.A
                positive value means in the direction of the associated
                vector and a negative value means in the opposite
                direction.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:simpleType name = "BottomEnumType" >
    < xs:annotation>
      <xs:documentation>
        The BottomEnumType enumerates values that describe the bottom type
        for a 3D internal feature type, a feature created by removing
        material.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "BLIND" />
      < xs:enumeration value = "THROUGH" />
 
       < xs:enumeration value = "UNDEFINED" />
  
      </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "BottomType" >
    < xs:annotation>
      <xs:documentation>
        The BottomType defines the bottom type for a 3D internal feature
        type, a feature created by removing material.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "BottomEnum"
        type="BottomEnumType">
        <xs:annotation>
          <xs:documentation>
            The BottomEnum element describes an often-used bottom type for
            a 3D internal feature type.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherBottom"
        type= "xs:string" >
        < xs:annotation>
          <xs:documentation>
            The OtherBottom element describes the bottom type for a 3D
            internal feature type in natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:complexType name = "BoundingBoxType" >
    < xs:annotation>
      <xs:documentation>
        The BoundingBoxType defines the dimensions of a box that
        usually bounds a shape object.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "Length"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Length element gives the length of the box.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Width"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Width element gives the width of the box.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Height"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Height element gives the height of the box.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:simpleType name = "ShapeClassEnumType" >
    < xs:annotation>
      <xs:documentation>
        The ShapeClassEnumType enumerates values that describe the shape
        class of a part.FREEFORM includes curved shapes such as turbine
        blades. PRISMATIC parts are non-rotational.THINWALLED is also
        known as sheet metal.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "GEAR" />
      < xs:enumeration value = "FREEFORM" />
      < xs:enumeration value = "PRISMATIC" />
      < xs:enumeration value = "ROTATIONAL" />
      < xs:enumeration value = "THINWALLED" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "ShapeClassType" >
    < xs:annotation>
      <xs:documentation>
        The ShapeClassType defines the shape class of a part.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "ShapeClassEnum"
        type= "ShapeClassEnumType" >
        < xs:annotation>
          <xs:documentation>
            The ShapeClassEnum element describes an often-used shape class.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherShapeClass"
        type="xs:string">
        <xs:annotation>
          <xs:documentation>
            The OtherShapeClass element describes a shape class in
            natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:simpleType name = "ManufacturingMethodEnumType" >
    < xs:annotation>
      <xs:documentation>
        The ManufacturingMethodEnumType enumerates values that describe the
        methods of manufacturing a part. ADDITIVE means additive
        manufacturing. COMPOSITE manufacturing includes lay-up and filament
        winding. FABRICATION fabricates existing components. FORMING
        includes forging, rolling, extrusion, pressing, bending, and
        shearing. JOINING includes welding, brazing, sintering, bonding,
        fastening, and press fitting.MACHINING includes all operations
        that may be done on a machining center or other machine that
        subtracts material such as milling, turning, drilling, reaming,
        boring, sawing, hobbing, and electron beam machining. MOLDING
        includes injection molding.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "ADDITIVE" />
      < xs:enumeration value = "CASTING" />
      < xs:enumeration value = "COMPOSITE" />
      < xs:enumeration value = "FABRICATION" />
      < xs:enumeration value = "FORMING" />
      < xs:enumeration value = "JOINING" />
      < xs:enumeration value = "MACHINING" />
      < xs:enumeration value = "MOLDING" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "ManufacturingMethodType" >
    < xs:annotation>
      <xs:documentation>
        The ManufacturingMethodType defines a manufacturing method for a
        part.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "ManufacturingMethodEnum"
        type= "ManufacturingMethodEnumType" >
        < xs:annotation>
          <xs:documentation>
            The ManufacturingMethodEnum element describes an often-used
            manufacturing method.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherManufacturingMethod"
        type= "xs:string" >
        < xs:annotation>
          <xs:documentation>
            The OtherManufacturingMethod element describes a manufacturing
            method in natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:simpleType name = "DimensionCountEnumType" >
    < xs:annotation>
      <xs:documentation>
        The DimensionCountEnumType enumerates values that describe whether
        a feature or a characteristic is two dimensional or three
        dimensional.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "TWODIMENSIONAL" />
      < xs:enumeration value = "THREEDIMENSIONAL" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:simpleType name = "ZoneOrientationEnumType" >
    < xs:annotation>
      <xs:documentation>
        The ZoneOrientationEnumType enumerates values that describe the
        orientation of a tolerance zone with respected to a feature or
        coordinate system characteristic.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "LENGTH" />
      < xs:enumeration value = "WIDTH" />
      < xs:enumeration value = "RADIAL" />
      < xs:enumeration value = "ANGULAR" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:simpleType name = "CoordinateEnumType" >
    < xs:annotation>
      <xs:documentation>
        The CoordinateEnumType enumerates values that describe a
        coordinate system.
          CARTESIAN_2D is a two dimensional Cartesian coordinate system
            with orthogonal X and Y axes.
          POLAR_2D is a two dimensional polar coordinate system with a
            radius from the origin and an angle from a starting direction.
          CARTESIAN_3D is a three dimensional right handed Cartesian
            coordinate system with orthogonal X, Y, and Z axes.
          CYLINDRICAL_3D is a three dimensional cylindrical coordinate
            system with a polar coordinate system where the XY Cartesian
            plane would be plus height.
          SPHERICAL_3D is a three dimensional spherical coordinate system
            with an axis perpendicular to a plane at the origin. It has a
            radius extending from the origin, an angle that is the angle
            between the radius and the axis, and an angle that is the angle
            between a starting direction in the plane and the projection of
            the radius on the plane.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "CARTESIAN_2D" />
      < xs:enumeration value = "POLAR_2D" />
      < xs:enumeration value = "CARTESIAN_3D" />
      < xs:enumeration value = "CYLINDRICAL_3D" />
      < xs:enumeration value = "SPHERICAL_3D" />
      < xs:enumeration value = "UNDEFINED" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "TypeOfCoordinatesType" >
    < xs:annotation>
      <xs:documentation>
        The TypeOfCoordinatesType defines a coordinate system type.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "CoordinateEnum"
        type= "CoordinateEnumType" >
        < xs:annotation>
          <xs:documentation>
            The CoordinateEnum element describes an often-used coordinate
            system type.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherCoordinate"
        type= "xs:string" >
        < xs:annotation>
          <xs:documentation>
            The OtherCoordinate element describes a coordinate system type
            in natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:complexType name = "RectangleType" >
    < xs:annotation>
      <xs:documentation>
        The RectangleType defines a rectangle to be used as a datum target
        or a rectangular zone limit. It is not a feature.ASME Y14.5 - 2009
        Section 3.3.3.3, Figure 3-6
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "Length"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Length element is the length of the rectangle.One of the
            two sides of the rectangle whose length is Length proceeds from
            the CornerPoint in the direction of the LengthDirection.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "CornerPoint"
        type= "PointType" >
        < xs:annotation>
          <xs:documentation>
            The CornerPoint element is the location of a corner of the
            rectangle.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Width"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Width element is the width of the rectangle.One of the two
            sides of the rectangle whose length is Width proceeds from the
            CornerPoint in the direction of the WidthDirection.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "WidthDirection"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The WidthDirection element is a unit vector that gives the
            direction of the width of the rectangle.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "LengthDirection"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The LengthDirection element is a unit vector that gives the
            direction of the length of the rectangle.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "CircleType" >
    < xs:annotation>
      <xs:documentation>
        The CircleType defines a circle to be used as a circular
        DatumTarget or a circular zone limit. It is not a feature.ASME
        Y14.5 - 2009 Section 3.3.3.3, Figure 3-6, Figure 3-9
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "CenterPoint"
        type= "PointType" >
        < xs:annotation>
          <xs:documentation>
            The CenterPoint element is the center of the circle.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Diameter"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Diameter element is the diameter of the circle.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Normal"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Normal element is the unit vector that gives the normal to
            the plane of the circle.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "CylinderType" >
    < xs:annotation>
      <xs:documentation>
        The CylinderType defines a cylinder to be used as a cylindrical
        area DatumTarget. It is not a feature.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "CenterPoint"
        type= "PointType" >
        < xs:annotation>
          <xs:documentation>
            The CenterPoint element is the center of the cylinder
            at one end.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Diameter"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Diameter element is the diameter of the cylinder.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Axis"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Axis element is the unit vector that gives the axis of the
            cylinder pointing from the end at which the center point is
            defined to the other end.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Length"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Length element is the length of the cylinder along its axis
            vector.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "SphereType" >
    < xs:annotation>
      <xs:documentation>
        The SphereType defines a sphere to be used as a spherical
        DatumTarget.It is not a feature.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "CenterPoint"
        type= "PointType" >
        < xs:annotation>
          <xs:documentation>
            The CenterPoint element is the center of the sphere.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Diameter"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The Diameter element is the diameter of the sphere.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "PointAndVectorType" >
    < xs:annotation>
      <xs:documentation>
        The PointAndVectorType defines a line by its starting point and
        direction vector.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "StartPoint"
        type= "PointType" >
        < xs:annotation>
          <xs:documentation>
            The StartPoint element is the starting point of the line.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Vector"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Vector element is a unit vector giving the direction of the
            line.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "MeasuredPointAndVectorType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredPointAndVectorType defines a line by its starting point
        and direction vector.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "StartPoint"
        type= "MeasuredPointType" >
        < xs:annotation>
          <xs:documentation>
            The StartPoint element is the measured starting point of the
            line.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Vector"
        type= "MeasuredUnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Vector element is a unit vector giving the measured
            direction of the line.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:simpleType name = "SlotEndEnumType" >
    < xs:annotation>
      <xs:documentation>
        The SlotEndEnumType enumerates values that describe whether a slot
        has a round, flat (square), or open end.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "ROUND" />
      < xs:enumeration value = "FLAT" />
      < xs:enumeration value = "OPEN" />
      < xs:enumeration value = "UNDEFINED" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "EndRadiusType" >
    < xs:annotation>
      <xs:documentation>
        The EndRadiusType defines the radius of the end of a slot.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "EndRadius"
        type= "LinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The EndRadius element describes the end radius of the slot.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Expanded"
        type= "xs:boolean"
        minOccurs= "0" >
        < xs:annotation>
          <xs:documentation>
            The optional Expanded element when set to "true" indicates that
            the round end of a slot expands to be larger than the width
            like the end of a dumbbell.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "MeasuredEndRadiusType" >
    < xs:annotation>
      <xs:documentation>
        The MeasuredEndRadiusType defines the measured radius of the end of
        a slot.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "EndRadius"
        type= "MeasuredLinearValueType" >
        < xs:annotation>
          <xs:documentation>
            The EndRadius element describes the measured end radius of the
            slot.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Expanded"
        type= "xs:boolean"
        minOccurs= "0" >
        < xs:annotation>
          <xs:documentation>
            The optional Expanded element when set to "true" indicates that
            the round end of a slot expands to be larger than the width
            like the end of a dumbbell.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "SlotEndType" >
    < xs:annotation>
      <xs:documentation>
        The SlotEndType defines the shape of the end of a slot.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "SlotEndEnum"
        type= "SlotEndEnumType" >
        < xs:annotation>
          <xs:documentation>
            The SlotEndEnum element describes an often-used shape of the
            end of a slot.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherSlotEnd"
        type= "xs:string" >
        < xs:annotation>
          <xs:documentation>
            The OtherSlotEnd element describes the shape of the end of a
            slot in natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:simpleType name = "ThreadSeriesEnumType" >
    < xs:annotation>
      <xs:documentation>
        The ThreadSeriesEnumType enumerates values that describe a standard
        thread series. Thread series enumerations are designated in ASME
        B1.7-2006, Table 3 - Thread Series Designations and Table 4 - ISO
        Thread Series Designations. Note: Table 4 references ISO 228-1, ISO
        7-1, ISO/R1501, ISO 2901, ISO 2902, ISO 2903, and ISO 2904.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "ACME" />
      < xs:enumeration value = "ACME_C" />
      < xs:enumeration value = "ACME_G" />
      < xs:enumeration value = "AMO" />
      < xs:enumeration value = "ANPT" />
      < xs:enumeration value = "BUTT" />
      < xs:enumeration value = "PUSH_BUTT" />
      < xs:enumeration value = "F_PTF" />
      < xs:enumeration value = "M" />
      < xs:enumeration value = "MJ" />
      < xs:enumeration value = "MJS" />
      < xs:enumeration value = "NC5_HF" />
      < xs:enumeration value = "NC5_CSF" />
      < xs:enumeration value = "NC5_ONF" />
      < xs:enumeration value = "NC5_IF" />
      < xs:enumeration value = "NC5_INF" />
      < xs:enumeration value = "NGO" />
      < xs:enumeration value = "NGS" />
      < xs:enumeration value = "NGT" />
      < xs:enumeration value = "NH" />
      < xs:enumeration value = "NHR" />
      < xs:enumeration value = "NPSC" />
      < xs:enumeration value = "NPSF" />
      < xs:enumeration value = "NPSH" />
      < xs:enumeration value = "NPSI" />
      < xs:enumeration value = "NPSL" />
      < xs:enumeration value = "NPSM" />
      < xs:enumeration value = "NPT" />
      < xs:enumeration value = "NPTF" />
      < xs:enumeration value = "PTF_SAE_SHORT" />
      < xs:enumeration value = "PTF_SPL_SHORT" />
      < xs:enumeration value = "PTF_SPL_EXTRA_SHORT" />
      < xs:enumeration value = "SGT" />
      < xs:enumeration value = "SPL_PTF" />
      < xs:enumeration value = "STUB_ACME" />
      < xs:enumeration value = "UN" />
      < xs:enumeration value = "UNC" />
      < xs:enumeration value = "UNF" />
      < xs:enumeration value = "UNEF" />
      < xs:enumeration value = "UNJ" />
      < xs:enumeration value = "UNJC" />
      < xs:enumeration value = "UNJF" />
      < xs:enumeration value = "UNJEF" />
      < xs:enumeration value = "UNR" />
      < xs:enumeration value = "UNRC" />
      < xs:enumeration value = "UNRF" />
      < xs:enumeration value = "UNREF" />
      < xs:enumeration value = "UNM" />
      < xs:enumeration value = "UNS" />
      < xs:enumeration value = "G" />
      < xs:enumeration value = "R" />
      < xs:enumeration value = "RC" />
      < xs:enumeration value = "RP" />
      < xs:enumeration value = "S" />
      < xs:enumeration value = "TR" />
      < xs:enumeration value = "UNDEFINED" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "ThreadSeriesType" >
    < xs:annotation>
      <xs:documentation>
        The ThreadSeriesType defines a thread series.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "ThreadSeriesEnum"
        type= "ThreadSeriesEnumType" >
        < xs:annotation>
          <xs:documentation>
            The ThreadSeriesEnum element describes an often-used thread
            series.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherThreadSeries"
        type= "xs:string" >
        < xs:annotation>
          <xs:documentation>
            The OtherThreadSeries element describes a thread series in
            natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:complexType name = "ThreadClassType" >
    < xs:annotation>
      <xs:documentation>
        The ThreadClassType defines a thread class.
      </xs:documentation>
    </xs:annotation>
    <xs:choice>
      <xs:element name = "ThreadClassEnum"
        type="ThreadClassEnumType">
        <xs:annotation>
          <xs:documentation>
            The ThreadClassEnum element describes an often-used thread
            class.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "OtherThreadClass"
        type="xs:string">
        <xs:annotation>
          <xs:documentation>
            The OtherThreadClass element describes a thread class in
            natural language.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:choice>
  </xs:complexType>

  <xs:simpleType name = "ThreadClassEnumType" >
    < xs:annotation>
      <xs:documentation>
        The ThreadClassEnumType enumerates values that describe a standard
        thread class or a thread tolerance class for the thread fit.Thread
        tolerance class enumerations are designated in ASME B1.1-2003,
        Section 4.1 and ISO 965-1. ISO external thread tolerance classes
        such as "3e" are implemented as "EXT_3E" in QIF.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "1A" />
      < xs:enumeration value = "1B" />
 
       < xs:enumeration value = "2A" />
  
        < xs:enumeration value = "2AG" />
   
         < xs:enumeration value = "2B" />
    
          < xs:enumeration value = "3A" />
     
           < xs:enumeration value = "3B" />
      
            < xs:enumeration value = "EXT_3E" />
       
             < xs:enumeration value = "EXT_3F" />
        
              < xs:enumeration value = "EXT_3G" />
         
               < xs:enumeration value = "EXT_3H" />
          
                < xs:enumeration value = "EXT_4E" />
           
                 < xs:enumeration value = "EXT_4F" />
            
                  < xs:enumeration value = "EXT_4G" />
             
                   < xs:enumeration value = "EXT_4H" />
              
                    < xs:enumeration value = "4G" />
               
                     < xs:enumeration value = "4H" />
                
                      < xs:enumeration value = "EXT_5E" />
                 
                       < xs:enumeration value = "EXT_5F" />
                  
                        < xs:enumeration value = "EXT_5G" />
                   
                         < xs:enumeration value = "EXT_5H" />
                    
                          < xs:enumeration value = "5G" />
                     
                           < xs:enumeration value = "5H" />
                      
                            < xs:enumeration value = "EXT_6E" />
                       
                             < xs:enumeration value = "EXT_6F" />
                        
                              < xs:enumeration value = "EXT_6G" />
                         
                               < xs:enumeration value = "EXT_6H" />
                          
                                < xs:enumeration value = "6G" />
                           
                                 < xs:enumeration value = "6H" />
                            
                                  < xs:enumeration value = "EXT_7E" />
                             
                                   < xs:enumeration value = "EXT_7F" />
                              
                                    < xs:enumeration value = "EXT_7G" />
                               
                                     < xs:enumeration value = "EXT_7H" />
                                
                                      < xs:enumeration value = "7G" />
                                 
                                       < xs:enumeration value = "7H" />
                                  
                                        < xs:enumeration value = "EXT_8E" />
                                   
                                         < xs:enumeration value = "EXT_8F" />
                                    
                                          < xs:enumeration value = "EXT_8G" />
                                     
                                           < xs:enumeration value = "EXT_8H" />
                                      
                                            < xs:enumeration value = "8G" />
                                       
                                             < xs:enumeration value = "8H" />
                                        
                                              < xs:enumeration value = "EXT_9E" />
                                         
                                               < xs:enumeration value = "EXT_9F" />
                                          
                                                < xs:enumeration value = "EXT_9G" />
                                           
                                                 < xs:enumeration value = "EXT_9H" />
                                            
                                                  < xs:enumeration value = "INT" />
                                             
                                                   < xs:enumeration value = "EXT" />
                                              
                                                    < xs:enumeration value = "SE" />
                                               
                                                     < xs:enumeration value = "G" />
                                                
                                                      < xs:enumeration value = "UNDEFINED" />
                                                 
                                                     </ xs:restriction>
  </xs:simpleType>

  <xs:complexType name = "StatsWithReferenceBaseType"
    abstract="true">
    <xs:annotation>
      <xs:documentation>
        A StatsWithReferenceBaseType is the abstract base type for
        statistical types that include a reference to an algorithm,
        software or standard.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:choice
        minOccurs = "0" >
        < xs:annotation>
          <xs:documentation>
            This optional compositor provides a choice between a reference
            to software, a particular algorithm, or a standard.
          </xs:documentation>
        </xs:annotation>
        <xs:element name = "SoftwareId"
          type="QIFReferenceType">
          <xs:annotation>
            <xs:documentation>
              The SoftwareId element defines the software reference.
            </xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element name = "StandardId"
          type="QIFReferenceType">
          <xs:annotation>
            <xs:documentation>
              The StandardId element defines the standard or specification
              reference.
            </xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element name = "AlgorithmId"
          type="QIFReferenceType">
          <xs:annotation>
            <xs:documentation>
              The AlgorithmId element defines the algorithm reference.
            </xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:sequence>
  </xs:complexType>

  <xs:simpleType name = "StatsValuesEnumType" >
    < xs:annotation>
      <xs:documentation>
        The StatsEnumType enumerates the various statistical values that
        can be accumulated.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "TOTNUM" />
      < xs:enumeration value = "EFFNUM" />
 
       < xs:enumeration value = "NUMSUB" />
  
        < xs:enumeration value = "AVG" />
   
         < xs:enumeration value = "DIFF" />
    
          < xs:enumeration value = "RMS" />
     
           < xs:enumeration value = "MAX" />
      
            < xs:enumeration value = "MIN" />
       
             < xs:enumeration value = "RANGE" />
        
              < xs:enumeration value = "AVGRNG" />
         
               < xs:enumeration value = "STDDEV" />
          
                < xs:enumeration value = "SKEW" />
           
                 < xs:enumeration value = "KURT" />
            
                  < xs:enumeration value = "NORM" />
             
                   < xs:enumeration value = "PROVAR" />
              
                    < xs:enumeration value = "ESTSTDV" />
               
                     < xs:enumeration value = "UCL" />
                
                      < xs:enumeration value = "LCL" />
                 
                       < xs:enumeration value = "UCLRNG" />
                  
                        < xs:enumeration value = "LCLRNG" />
                   
                         < xs:enumeration value = "NUMOOC" />
                    
                          < xs:enumeration value = "NUMOOT" />
                     
                           < xs:enumeration value = "NOOTHI" />
                      
                            < xs:enumeration value = "NOOTLO" />
                       
                             < xs:enumeration value = "CP" />
                        
                              < xs:enumeration value = "CPK" />
                         
                               < xs:enumeration value = "PP" />
                          
                                < xs:enumeration value = "PPK" />
                           
                                 < xs:enumeration value = "CM" />
                            
                                  < xs:enumeration value = "CMK" />
                             
                                   < xs:enumeration value = "CPM" />
                              
                                    < xs:enumeration value = "AV" />
                               
                                     < xs:enumeration value = "REL_AV" />
                                
                                      < xs:enumeration value = "EV" />
                                 
                                       < xs:enumeration value = "REL_EV" />
                                  
                                        < xs:enumeration value = "INTERACTION" />
                                   
                                         < xs:enumeration value = "REL_INTERACTION" />
                                    
                                          < xs:enumeration value = "RANDR" />
                                     
                                           < xs:enumeration value = "REL_RANDR" />
                                      
                                            < xs:enumeration value = "PV" />
                                       
                                             < xs:enumeration value = "REL_PV" />
                                        
                                              < xs:enumeration value = "TV" />
                                         
                                               < xs:enumeration value = "REL_TV" />
                                          
                                                < xs:enumeration value = "LNRTY" />
                                           
                                                 < xs:enumeration value = "BIAS" />
                                            
                                                  < xs:enumeration value = "REL_LNRTY" />
                                             
                                                   < xs:enumeration value = "REL_BIAS" />
                                              
                                                    < xs:enumeration value = "R_SQR" />
                                               
                                                     < xs:enumeration value = "SLOPE" />
                                                
                                                      < xs:enumeration value = "INTCPT" />
                                                 
                                                       < xs:enumeration value = "UPRCONFLIM" />
                                                  
                                                        < xs:enumeration value = "LWRCONFLIM" />
                                                   
                                                         < xs:enumeration value = "TDIST" />
                                                    
                                                        </ xs:restriction>
  </xs:simpleType>

  <xs:simpleType name = "ListAccumulatedStatsValuesListType" >
    < xs:annotation>
      <xs:documentation>
        The ListAccumulatedStatsValuesListType defines a list of the
        statistical values to be accumulated.
      </xs:documentation>
    </xs:annotation>
    <xs:list itemType = "StatsValuesEnumType" />
  </ xs:simpleType>

  <xs:complexType name = "ListAccumulatedStatsValuesType" >
    < xs:annotation>
      <xs:documentation>
        A ListAccumulatedStatsValuesType defines a list of the statistical
        values to be accumulated and optionally defines the software,
        standard or specification, or algorithm to be used to evaluate the
        values.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Stats"
            type= "ListAccumulatedStatsValuesListType" >
            < xs:annotation>
              <xs:documentation>
                The Stats element is a list of one or more statistical
                values to be accumulated.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:simpleType name = "SubgroupStatsValuesEnumType" >
    < xs:annotation>
      <xs:documentation>
        The SubgroupStatsValuesEnumType enumerates the various statistical
        values that can be accumulated on a per-subgroup basis.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "TOTNUM" />
      < xs:enumeration value = "EFFNUM" />
      < xs:enumeration value = "AVG" />
      < xs:enumeration value = "DIFF" />
      < xs:enumeration value = "MAX" />
      < xs:enumeration value = "MIN" />
      < xs:enumeration value = "RANGE" />
      < xs:enumeration value = "NUMOOT" />
      < xs:enumeration value = "NOOTHI" />
      < xs:enumeration value = "NOOTLO" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:simpleType name = "ListSubgroupStatsValuesListType" >
    < xs:annotation>
      <xs:documentation>
        The ListSubgroupStatsValuesListType defines a list of the
        statistical values to be accumulated on a per-subgroup basis.
      </xs:documentation>
    </xs:annotation>
    <xs:list itemType = "SubgroupStatsValuesEnumType" />
  </ xs:simpleType>

  <xs:complexType name = "ListSubgroupStatsValuesType" >
    < xs:annotation>
      <xs:documentation>
        A ListSubgroupStatsValuesType defines a list of the statistical
        values to be accumulated on a per-subgroup basis and optionally
        defines the software, standard or specification, or algorithm to be
        used to evaluate the values.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Stats"
            type= "ListSubgroupStatsValuesListType" >
            < xs:annotation>
              <xs:documentation>
                The Stats element is a list of one or more statistical
                values to be accumulated.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "StatsMeasuredDecimalType" >
    < xs:annotation>
      <xs:documentation>
        The StatsMeasuredDecimalType defines a numeric statistical result
        and optionally defines the software, standard or specification, or
        algorithm used to evaluate the value.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Value"
            type= "MeasuredDecimalType" >
            < xs:annotation>
              <xs:documentation>
                The Value element is the numeric statistical result.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "StatsMeasuredDecimalWithReferenceType" >
    < xs:annotation>
      <xs:documentation>
        The StatsMeasuredDecimalWithReferenceType defines a numeric
        statistical result with an optional QIF id reference.For example,
        a maximum value may optionally reference the characteristic with
        the maximum value.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsMeasuredDecimalType">
        <xs:sequence>
          <xs:element name = "Id"
            type= "QIFReferenceType"
            minOccurs= "0" >
            < xs:annotation>
              <xs:documentation>
                The optional Id element is a reference to a QIF id
                associated with this statistical result.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "SubgroupDecimalType" >
    < xs:annotation>
      <xs:documentation>
        A SubgroupDecimalType defines an MeasuredDecimalType associated with
        a particular subgroup id.
      </xs:documentation>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base="MeasuredDecimalType">
        <xs:attribute name = "subgroupId"
          type= "QIFIdType"
          use= "required" >
          < xs:annotation>
            <xs:documentation>
              The required subgroupId attribute references the id of the
              subgroup with which this decimal value is associated.
            </xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>

  <xs:complexType name = "SubgroupDecimalArrayType" >
    < xs:annotation>
      <xs:documentation>
        A SubgroupDecimalArrayType defines a list of SubgroupDecimalType.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "SubgroupDecimal"
        type= "SubgroupDecimalType"
        maxOccurs= "unbounded" >
        < xs:annotation>
          <xs:documentation>
            Each SubgroupDecimal element in the list defines a decimal
            value associated with a subgroup id.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute name = "n"
      type= "NaturalType"
      use= "required" >
      < xs:annotation>
        <xs:documentation>
          The required n attribute is the number of values in the list.
        </xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>

  <xs:complexType name = "SubgroupDecimalsType" >
    < xs:annotation>
      <xs:documentation>
        The SubgroupDecimalsType defines a list of SubgroupDecimalType and
        optionally defines the software, standard or specification, or
        algorithm to be used to determine the array of measured values.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Values"
            type= "SubgroupDecimalArrayType" >
            < xs:annotation>
              <xs:documentation>
                The Values element is the array of measured values
                associated with subgroup ids.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "StatsNonNegativeIntegerType" >
    < xs:annotation>
      <xs:documentation>
        The StatsNonNegativeIntegerType defines a non negative integer
        statistical result and optionally defines the software, standard
        or specification, or algorithm to be used to determine the non
        negative integer statistical result.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Value"
            type= "xs:nonNegativeInteger" >
            < xs:annotation>
              <xs:documentation>
                The Value element is the non negative integer statistical
                result.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "StatsNonNegativeIntegerWithReferencesType" >
    < xs:annotation>
      <xs:documentation>
        The StatsNonNegativeIntegerWithReferencesType defines a non
        negative integer statistical result and optionally defines a list
        of references to QIF ids associated with this value.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsNonNegativeIntegerType">
        <xs:sequence>
          <xs:element name = "Ids"
            type= "ArrayReferenceType"
            minOccurs= "0" >
            < xs:annotation>
              <xs:documentation>
                The optional Ids element is the array of QIF id references.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "SubgroupIntegerType" >
    < xs:annotation>
      <xs:documentation>
        A SubgroupIntegerType defines an xs:positiveInteger type associated
        with a particular subgroup id.
      </xs:documentation>
    </xs:annotation>
    <xs:simpleContent>
      <xs:extension base="xs:nonNegativeInteger">
        <xs:attribute name = "subgroupId"
          type= "QIFIdType"
          use= "required" >
          < xs:annotation>
            <xs:documentation>
              The required subgroupId attribute references the id of the
              subgroup with which this integer value is associated.
            </xs:documentation>
          </xs:annotation>
        </xs:attribute>
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>

  <xs:complexType name = "SubgroupIntegerArrayType" >
    < xs:annotation>
      <xs:documentation>
        A SubgroupIntegerArrayType defines a list of xs:positiveInteger
        types associated with particular subgroup ids.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "SubgroupInteger"
        type= "SubgroupIntegerType"
        maxOccurs= "unbounded" >
        < xs:annotation>
          <xs:documentation>
            Each SubgroupInteger element in the list defines an integer
            value associated with a subgroup id.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute name = "n"
      type= "NaturalType"
      use= "required" >
      < xs:annotation>
        <xs:documentation>
          The required n attribute is the number of values in the list.
        </xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>

  <xs:complexType name = "SubgroupIntegersType" >
    < xs:annotation>
      <xs:documentation>
        The SubgroupIntegersType defines a list of SubgroupIntegerType and
        optionally defines the software, standard or specification, or
        algorithm to be used to determine the list of integers.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Values"
            type= "SubgroupIntegerArrayType" >
            < xs:annotation>
              <xs:documentation>
                The Values element is the array of integer values
                associated with subgroup ids.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:simpleType name = "SummaryStatsValuesEnumType" >
    < xs:annotation>
      <xs:documentation>
        The SummaryStatsValuesEnumType enumerates the various statistical
        values that can be accumulated on statistical values.
      </xs:documentation>
    </xs:annotation>
    <xs:restriction base="xs:NMTOKEN">
      <xs:enumeration value = "AVG" />
      < xs:enumeration value = "MAX" />
      < xs:enumeration value = "MIN" />
      < xs:enumeration value = "RANGE" />
      < xs:enumeration value = "STDDEV" />
    </ xs:restriction>
  </xs:simpleType>

  <xs:simpleType name = "ListSummaryStatsValuesListType" >
    < xs:annotation>
      <xs:documentation>
        The ListSummaryStatsValuesListType defines a list of the statistical
        values to be used in a summary.
      </xs:documentation>
    </xs:annotation>
    <xs:list itemType = "StatsValuesEnumType" />
  </ xs:simpleType>

  <xs:complexType name = "ListSummaryStatsValuesType" >
    < xs:annotation>
      <xs:documentation>
        A ListSummaryStatsValuesType defines a list of the statistical
        values to be used in a summary and optionally defines the software,
        standard or specification, or algorithm to be used to evaluate the
        values.
      </xs:documentation>
    </xs:annotation>
    <xs:complexContent>
      <xs:extension base="StatsWithReferenceBaseType">
        <xs:sequence>
          <xs:element name = "Stats"
            type= "ListSummaryStatsValuesListType" >
            < xs:annotation>
              <xs:documentation>
                The Stats element is a list of one or more statistical
                values to be accumulated.
              </xs:documentation>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>

  <xs:complexType name = "SummaryStatsValuesType" >
    < xs:annotation>
      <xs:documentation>
        The SummaryStatsValuesType defines the summary values to be
        accumulated for a statistical value.For example, the average Cpk
        and the worst (minimum) Cpk value over all characteristics may be
        summarized.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "SummaryType"
        type= "SummaryStatsValuesEnumType" >
        < xs:annotation>
          <xs:documentation>
            The SummaryType element defines the type of summary value to
            which the list of accumulated statistics applies.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "SummaryStats"
        type= "ListSummaryStatsValuesType" >
        < xs:annotation>
          <xs:documentation>
            The SummaryStats element defines a list of statistical values
            to be included in the summary of a statistical value.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "SummaryStatsValuesListType" >
    < xs:annotation>
      <xs:documentation>
        The SummaryStatsValuesListType collects a list of summary stats
        values.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "SummaryStatsValues"
        type= "SummaryStatsValuesType"
        maxOccurs= "unbounded" >
        < xs:annotation>
          <xs:documentation>
            Each SummaryStatsValues element in the list defines the summary
            values to be accumulated for a statistical value.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute name = "n"
      type= "NaturalType"
      use= "required" >
      < xs:annotation>
        <xs:documentation>
          The required n attribute is the number of summaries in the list.
        </xs:documentation>
      </xs:annotation>
    </xs:attribute>
  </xs:complexType>

  <xs:complexType name = "UniformScaleType" >
    < xs:annotation>
      <xs:documentation>
        The UniformScaleType defines a scale factor applied uniformly in
        all directions.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "ScaleFactor"
        type= "xs:decimal" >
        < xs:annotation>
          <xs:documentation>
            The ScaleFactor element is the scale factor, a scale factor of
            1.0 indicates no change.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "RadialDifferentialScaleType" >
    < xs:annotation>
      <xs:documentation>
        The RadialDifferentialScaleType defines two scale factors applied
        parallel and perpendicular to a specified direction.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "PerpendicularScaleFactor"
        type= "xs:decimal" >
        < xs:annotation>
          <xs:documentation>
            The PerpendicularScaleFactor element is the scale factor
            applied perpendicular to the specified direction, a scale
            factor of 1.0 indicates no change.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "ParallelScaleFactor"
        type= "xs:decimal" >
        < xs:annotation>
          <xs:documentation>
            The ParallelScaleFactor element is the scale factor applied
            parallel to the specified direction, a scale factor of 1.0
            indicates no change.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "Direction"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The Direction element specifies the direction for the
            differential scaling.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "AxialDifferentialScaleType" >
    < xs:annotation>
      <xs:documentation>
        The AxialDifferentialScaleType defines three scale factors applied
        along three specified orthogonal directions.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "XScaleFactor"
        type= "xs:decimal" >
        < xs:annotation>
          <xs:documentation>
            The XScaleFactor element is the scale factor applied in the
            specified X direction, a scale factor of 1.0 indicates no
            change.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "XaxisDirection"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The XaxisDirection element specifies the direction of the X
            axis for differential scaling.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "YScaleFactor"
        type= "xs:decimal" >
        < xs:annotation>
          <xs:documentation>
            The YScaleFactor element is the scale factor applied in the
            specified Y direction, a scale factor of 1.0 indicates no
            change.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "YaxisDirection"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The YaxisDirection element specifies the direction of the Y
            axis for differential scaling.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "ZScaleFactor"
        type= "xs:decimal" >
        < xs:annotation>
          <xs:documentation>
            The ZScaleFactor element is the scale factor applied in the
            specified Z direction, a scale factor of 1.0 indicates no
            change.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name = "ZaxisDirection"
        type= "UnitVectorType" >
        < xs:annotation>
          <xs:documentation>
            The ZaxisDirection element specifies the direction of the Z
            axis for differential scaling.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>

  <xs:complexType name = "ScaleType" >
    < xs:annotation>
      <xs:documentation>
        The ScaleType defines scaling about an origin point.
      </xs:documentation>
    </xs:annotation>
    <xs:sequence>
      <xs:element name = "Origin"
        type= "PointType" >
        < xs:annotation>
          <xs:documentation>
            The Origin element is the origin for the scaling.
          </xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:choice>
        <xs:element name = "UniformScale"
          type= "UniformScaleType" >
          < xs:annotation>
            <xs:documentation>
              The UniformScale element signifies uniform scaling about the
              origin point.
            </xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element name = "RadialDifferentialScale"
          type= "RadialDifferentialScaleType" >
          < xs:annotation>
            <xs:documentation>
              The RadialDifferentialScale element signifies radial
              differential scaling about the origin point
            </xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element name = "AxialDifferentialScale"
          type= "AxialDifferentialScaleType" >
          < xs:annotation>
            <xs:documentation>
              The AxialDifferentialScale element signifies axial
              differential scaling about the origin point
            </xs:documentation>
          </xs:annotation>
        </xs:element>
      </xs:choice>
    </xs:sequence>
  </xs:complexType>
*/
}