/*! \file DimensionalCharacteristicItemBaseType.cs
    \brief abstract base type that defines a linear characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks> The LinearCharacteristicItemBaseType is the abstract base type that defines a linear characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatTaperCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalTaperCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChordCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalRadiusCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RadiusCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBetweenCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceFromCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThicknessCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DepthCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HeightCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WidthCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalDiameterCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiameterCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveLengthCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedLinearCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LinearCharacteristicItemBaseType : DimensionalCharacteristicItemBaseType
    {
    }

    /// <remarks> The FlatTaperCharacteristicItemType defines a flat taper characteristic item.</remarks>
    public class FlatTaperCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The ConicalTaperCharacteristicItemType defines a conical taper characteristic item.</remarks>
    public class ConicalTaperCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The ChordCharacteristicItemType defines a chord characteristic item.</remarks>
    public class ChordCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The SphericalRadiusCharacteristicItemType defines a spherical radius characteristic item.</remarks>
    public class SphericalRadiusCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The RadiusCharacteristicItemType defines a radius characteristic item.</remarks>
    public class RadiusCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The DistanceBetweenCharacteristicItemType defines a distance-between characteristic item.</remarks>
    public class DistanceBetweenCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The DistanceFromCharacteristicItemType defines a distance-from characteristic item.</remarks>
    public class DistanceFromCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The SquareCharacteristicItemType defines a square characteristic item.</remarks>
    public class SquareCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The ThicknessCharacteristicItemType defines a thickness characteristic item.</remarks>
    public class ThicknessCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The DepthCharacteristicItemType defines a depth characteristic item.</remarks>
    public class DepthCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The HeightCharacteristicItemType defines a height characteristic item.</remarks>
    public class HeightCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The WidthCharacteristicItemType defines a width characteristic item.</remarks>
    public class WidthCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The LengthCharacteristicItemType defines a length characteristic item.</remarks>
    public class LengthCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The SphericalDiameterCharacteristicItemType defines a spherical diameter characteristic item.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SphericalDiameterCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The DiameterCharacteristicItemType defines a diameter characteristic item.</remarks>
    public class DiameterCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The CurveLengthCharacteristicItemType defines a curve length characteristic item.</remarks>
    public class CurveLengthCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }

    /// <remarks> The UserDefinedLinearCharacteristicItemType is a characteristic
    /// item specified by the user that is measured in linear units.This
    /// user defined type is not to be used where an appropriate type
    /// already exists. In particular it is not to be used for: angularity,
    /// chord, circularity, circular-runout, concentricity, conical taper,
    /// conicity, curve-length, cylindricity, depth, diameter, distance-
    /// between, distance-from, ellipticity, flatness, flat taper, height,
    /// length, linear-coordinate, line-profile, (other) form, parallelism,
    /// perpendicularity, point-profile, position, radius, sphericity,
    /// square, straightness, surface-profile, surface-texture, symmetry,
    /// thickness, toroidicity, total-runout or width.</remarks>
    public class UserDefinedLinearCharacteristicItemType : LinearCharacteristicItemBaseType
    {

    }
}
