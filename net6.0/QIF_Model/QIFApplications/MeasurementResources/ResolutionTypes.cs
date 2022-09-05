﻿/*! \file ResolutionTypes.cs
	\brief Defines the resolution for different measurement devices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The abstract ResolutionBaseType is the base type for types that
    /// define the resolution for different measurement devices. </remarks>
    public abstract class ResolutionBaseType
    {
    }

    /// <remarks> The LinearResolutionType defines the resolution for a
    /// measurement device that has one axis, and that axis is linear. </remarks>
    public class LinearResolutionType : ResolutionBaseType
    {
        /// <remarks> The LinearValue element is the resolution for a single linear axis. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? LinearValue { get; set; }
    }

    /// <remarks> The CartesianResolutionType gives the resolution of a device
    /// with 3D Cartesian coordinates as an overall resolution,
    /// or as a sequence of X, Y, and Z axis resolutions, or both. </remarks>
    public class CartesianResolutionType : ResolutionBaseType
    {
        /// <remarks> The choice is among:
        /// (1) CombinedCartesianResolution, 
        /// (2) XYZResolution, or 
        /// (3) both(with CombinedResolution coming first). 
        /// This choice structure is the normal XML schema language structure for 'one or both'. </remarks>
        #region Choice
        /// <remarks> The CombinedResolution element is the resolution of the device. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? CombinedCartesianResolution { get; set; }

        /// <remarks> The optional XYZResolution element gives the resolution
        /// of the device along each of the three coordinate axes. </remarks>
        [XmlElement]
        public XYZResolutionType XYZResolution { get; set; }
        #endregion
    }

    /// <remarks> The XYZResolutionType defines the resolution of a Cartesian CMM (or
    /// other device with 3D Cartesian coordinates) using separate values for the three axes. </remarks>
    public class XYZResolutionType
    {
        /// <remarks> The XResolution element is the resolution of the X axis. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? XResolution { get; set; }

        /// <remarks> The YResolution element is the resolution of the Y axis. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? YResolution { get; set; }

        /// <remarks> The ZResolution element is the resolution of the Z axis. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? ZResolution { get; set; }
    }

    /// <remarks> The SphericalResolutionType defines the resolution for a device
    /// with a 3D Spherical coordinate system as an overall resolution, or
    /// as a sequence of Radial, Azimuthal, and Polar resolutions, or both. </remarks>
    public class SphericalResolutionType : ResolutionBaseType
    {
        /// <remarks> The choice is among 
        /// (1) CombinedSphericalResolution, 
        /// (2) RAPResolution, or
        /// (3) both(with CombinedSphericalResolution coming first). 
        /// This choice structure is the normal XML schema language structure for 'one or both'. </remarks>
        #region Choice
        /// <remarks> The CombinedSphericalResolution element is the resolution in a spherical coordinate system. </remarks>
        [XmlElement]
        public CombinedSphericalResolutionType CombinedSphericalResolution { get; set; }

        /// <remarks> The RAPResolution element is the resolution for any device using spherical coordinate system. </remarks>
        [XmlElement]
        public RAPZResolutionType RAPZResolution { get; set; }
        #endregion
    }

    /// <remarks> The RAPZResolutionType defines resolution in each coordinate of a spherical coordinate system(Radial, Azimuthal and Polar).</remarks>
    public class RAPZResolutionType
    {
        /// <remarks> The RadialResolution element is the radial resolution for a
        /// spherical coordinate system(the resolution from the origin to the point being measured). </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? RadialResolution { get; set; }

        /// <remarks> The AzimuthalResolution element is the resolution for the
        /// Azimuthal angle of a spherical coordinate system. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? AzimuthalAngleResolution { get; set; }

        /// <remarks> The PolarAngleResolution element is the resolution for the
        /// Polar angle of a spherical coordinate system. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? PolarAngleResolution { get; set; }
    }


    /// <remarks> The CombinedSphericalResolution defines the combined resolution for
    /// each axis of a device with a spherical coordinate system. </remarks>
    public class CombinedSphericalResolutionType : ResolutionBaseType
    {
        /// <remarks> The CombinedRadialResolution element is the radial resolution of the device with a spherical coordinate system. </remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? CombinedRadialResolution { get; set; }

        /// <remarks> The CombinedAzimuthalResolution element is the Azimuthal resolution of the device with a spherical coordinate system. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? CombinedAzimuthalResolution { get; set; }

        /// <remarks> The CombinedPolarResolution element is the polar resolution of the device with a spherical coordinate system. </remarks>
        [XmlElement]
        public QIFLibrary.Units.AngularValueType? CombinedPolarResolution { get; set; }
    }

    /// <remarks> The UserDefinedResolutionType gives the resolution of a device with
    /// 3D coordinates as an overall resolution, or as a sequence of A, B,
    /// and C axis resolutions, or both. </remarks>
    public class UserDefinedResolutionType : ResolutionBaseType
    {
        /// <remarks> The choice is among 
        /// (1) CombinedUserDefinedResolution, 
        /// (2) ABCResolution, or
        /// (3) both (with CombinedUserDefinedResolution coming first). 
        /// This choice structure is the normal XML schema language structure for 'one or both' </remarks>
        #region Choice
        /// <remarks> The CombinedUserDefinedResolution element is the resolution of the device in each axis. </remarks>
        [XmlElement]
        public CombinedUserDefinedResolutionType CombinedUserDefinedResolution { get; set; }

        /// <remarks> The ABCResolution element gives the resolution of the device along each of the three coordinate axes(A, B, and C). </remarks>
        [XmlElement]
        public ABCResolutionType ABCResolution { get; set; }
        #endregion
    }

    /// <remarks> The ABCResolutionType gives the resolution of the device along each of the three coordinate axes. </remarks>
    public class ABCResolutionType
    {
        /// <remarks> The AAxisResolution element is the resolution along the A axis.This axis could be linear or rotary. </remarks>
        [XmlElement]
        public LinearOrRotaryAxisType AAxisResolution { get; set; }

        /// <remarks> The BAxisResolution element is the resolution along the B axis.This axis could be linear or rotary. </remarks>
        [XmlElement]
        public LinearOrRotaryAxisType BAxisResolution { get; set; }

        /// <remarks> The CAxisResolution element is the resolution along the C axis.This axis could be linear or rotary. </remarks>
        [XmlElement]
        public LinearOrRotaryAxisType CAxisResolution { get; set; }
    }

    /// <remarks> The CombinedUserDefinedResolutionType defines the combined user defined resolution of a measurement device. </remarks>
    public class CombinedUserDefinedResolutionType
    {
        /// <remarks> The ACombinedResolution element is the combined resolution along the A axis. </remarks>
        [XmlElement]
        public LinearOrRotaryAxisType ACombinedResolution { get; set; }

        /// <remarks> The BCombinedResolution element is the combined resolution along the B axis. </remarks>
        [XmlElement]
        public LinearOrRotaryAxisType BCombinedResolution { get; set; }

        /// <remarks> The CCombinedResolution element is the combined resolution along the C axis. </remarks>
        [XmlElement]
        public LinearOrRotaryAxisType CCombinedResolution { get; set; }
    }
}
