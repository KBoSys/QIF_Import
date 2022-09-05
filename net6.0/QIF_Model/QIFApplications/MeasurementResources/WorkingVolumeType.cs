﻿/*! \file WorkingVolumeBaseType.cs
	\brief The base type for more precisely defined types of working volumes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> 
    /// The abstract WorkingVolumeBaseType is the base type for more
    /// precisely defined types of working volumes.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class WorkingVolumeBaseType
    {
    }

    /// <remarks> 
    /// The ClosedShellSetWorkingVolumeType defines a working volume
    /// consisting of a set of closed outer shells.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ClosedShellSetWorkingVolumeType : WorkingVolumeBaseType
    {
        /// <remarks> 
        /// The ClosedShellSet element is the closed shells that
        /// define the working volume. </remarks>
        [XmlElement]
        public ClosedShellSetType? WorkingClosedShellSet { get; set; }
    }

    /// <remarks> 
    /// The global WorkingClosedShellSet element gives information about a closed shell set.
    /// Each key in this element requires each item in a collection of
    /// items of the same type to have an id that is unique within the collection. 
    /// 
    /// The ClosedShellSetType defines a set of closed outer shells,
    /// including the geometry and topology of the components of the shells.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ClosedShellSetType
    {
        /// <remarks> 
        /// The optional PointSet element is a collection of all instances
        /// of PointEntityType present in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Geometry.PointSetType? PointSet { get; set; }

        /// <remarks> 
        /// The optional Curve12Set element is a collection of all 2D
        /// curves(curve(t):R1->R2) present in the shell set.These curves
        /// are defined in the parametric space of a surface. </remarks>
        [XmlElement]
        public QIFLibrary.Geometry.Curve12SetType? Curve12Set { get; set; }

        /// <remarks> 
        /// The optional Curve13Set element is a collection of all 3D
        /// curves(curve(t):R1->R3) present in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Geometry.Curve13SetType? Curve13Set { get; set; }

        /// <remarks> 
        /// The optional SurfaceSet element is a collection of all surfaces present in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Geometry.SurfaceSetType? SurfaceSet { get; set; }

        /// <remarks> 
        /// The optional CurveMeshSet element is a collection of all mesh curves present in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Geometry.CurveMeshSetType? CurveMeshSet { get; set; }

        /// <remarks> 
        /// The optional SurfaceMeshSet element is a collection of all mesh surfaces present in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Geometry.SurfaceMeshSetType? SurfaceMeshSet { get; set; }

        /// <remarks> 
        /// The optional VertexSet element is a collection of all vertices used in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Topology.VertexSetType? VertexSet { get; set; }

        /// <remarks> 
        /// The optional EdgeSet element is a collection of all edges used in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Topology.EdgeSetType? EdgeSet { get; set; }

        /// <remarks> 
        /// The optional LoopSet element is a collection of all loops used in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Topology.LoopSetType? LoopSet { get; set; }

        /// <remarks> 
        /// The optional FaceSet element is a collection of all faces used in the shell set. </remarks>
        [XmlElement]
        public QIFLibrary.Topology.FaceSetType? FaceSet { get; set; }

        /// <remarks> 
        /// The ShellSet element gives the set of boundary representation shells that define the working volume. </remarks>
        [XmlElement]
        public QIFLibrary.Topology.ShellSetType? ShellSet { get; set; }
    }

    /// <remarks> 
    /// The CartesianWorkingVolumeType defines a box-shaped working volume
    /// whose sides are aligned with the axes of a 3D Cartesian	coordinate system.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CartesianWorkingVolumeType : WorkingVolumeBaseType
    {
        /// <remarks> 
        /// The optional XAxisLength element is the length of the Cartesian working volume in the X direction. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? XAxisLength { get; set; }

        /// <remarks> 
        /// The optional YAxisLength element is the length of the Cartesian working volume in the Y direction. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? YAxisLength { get; set; }

        /// <remarks> 
        /// The optional ZAxisLength element is the length of the Cartesian working volume in the Z direction. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? ZAxisLength { get; set; }
    }

    /// <remarks> 
    /// The SphericalWorkingVolumeType defines a spherical working volume.
    /// A spherical working volume is defined based on a spherical
    /// coordinate system.Some measurement devices, such as laser tracker,
    /// operate based on a spherical coordinate system.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SphericalWorkingVolumeType : WorkingVolumeBaseType
    {
        /// <remarks> 
        /// The RadialAxisLength element is the radius of the spherical working volume. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? RadialAxisLength { get; set; }

        /// <remarks> 
        /// The MinAzimuthalAxisAngle element is the start value of the range of azimuthal angle in a spherical working volume. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? MinAzimuthalAxisAngle { get; set; }

        /// <remarks> 
        /// The MaxAzimuthalAxisAngle element is the end value of the range of azimuthal angle in a spherical working volume. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? MaxAzimuthalAxisAngle { get; set; }

        /// <remarks> 
        /// The MinPolarAxisRange element is the start value of the range of the polar angle for a spherical working volume. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? MinPolarAxisAngle { get; set; }

        /// <remarks> 
        /// The MaxPolarAxisRange element is the end value of the range of the polar angle for a spherical working volume. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? MaxPolarAxisAngle { get; set; }
    }

    /// <remarks> 
    /// The CylindricalWorkingVolumeType defines a cylindrical working volume.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CylindricalWorkingVolumeType : WorkingVolumeBaseType
    {
        /// <remarks> 
        /// The RadialAxisLength element is the radial axis length of a cylindrical working volume. </remarks>
        public LinearValueType? RadialAxisLength { get; set; } = new LinearValueType();

        /// <remarks> 
        /// The MinAzimuthalAxisAngle element is the start value of the range of azimuthal angle in a cylindrical working volume. </remarks>
        public AngularValueType? MinAzimuthalAxisAngle { get; set; } = new AngularValueType();

        /// <remarks> 
        /// The MaxAzimuthalAxisAngle element is the end value of the range of azimuthal angle in a cylindrical working volume. </remarks>
        public AngularValueType? MaxAzimuthalAxisAngle { get; set; } = new AngularValueType();

        /// <remarks> 
        /// The ZAxisLength element is the Z axis length of a cylindrical working volume. </remarks>
        public LinearValueType? ZAxisLength { get; set; } = new LinearValueType();
    }

    /// <remarks> 
    /// The UserDefinedWorkingVolumeType defines a 3 dimensional working volume by three user defined axes.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedWorkingVolumeType : WorkingVolumeBaseType
    {
        /// <remarks> 
        /// The FirstAxis element gives the axis length or angle and
        /// other details for the first axis of a user defined working volume. </remarks>
        [XmlElement]
        public UserDefinedAxisType FirstAxis { get; set; } = new UserDefinedAxisType();

        /// <remarks> 
        /// The SecondAxis element gives the axis length or angle and
        /// other details for the second axis of a user defined working volume. </remarks>
        [XmlElement]
        public UserDefinedAxisType SecondAxis { get; set; } = new UserDefinedAxisType();

        /// <remarks> 
        /// The ThirdAxis element gives the axis length or angle and
        /// other details for the third axis of a user defined working volume. </remarks>
        [XmlElement]
        public UserDefinedAxisType ThirdAxis { get; set; } = new UserDefinedAxisType();
    }
}
