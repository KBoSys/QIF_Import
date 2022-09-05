/*! \file LocationCharacteristicNominalBaseType.cs
    \brief Abstract base type that defines a unique location characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks> The LocationCharacteristicNominalBaseType is the abstract base type that defines a unique location characteristic nominal.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SymmetryCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcentricityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoaxialityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LocationCharacteristicNominalBaseType : GeometricCharacteristicNominalBaseType
    {
    }

    /// <remarks> The SymmetryCharacteristicNominalType defines a unique symmetry characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SymmetryCharacteristicNominalType : LocationCharacteristicNominalBaseType
    {
    }

    /// <remarks> The ConcentricityCharacteristicNominalType defines a unique concentricity characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConcentricityCharacteristicNominalType : LocationCharacteristicNominalBaseType
    {
    }

    /// <remarks> The CoaxialityCharacteristicNominalType defines a unique coaxiality characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoaxialityCharacteristicNominalType : LocationCharacteristicNominalBaseType
    {
    }

    /// <remarks> The PositionCharacteristicNominalType defines a unique position characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PositionCharacteristicNominalType : LocationCharacteristicNominalBaseType
    {
        /// <remarks> The optional CoordinateMethod element defines the coordinate method for bidirectional positional tolerancing.</remarks>
        public PositionCoordinateMethodType? CoordinateMethod { get; set; }
    }

    /// <remarks> The PositionCoordinateMethodType defines a polar or a rectangular coordinate method.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PositionCoordinateMethodType
    {
        /// <remarks> The Method element defines the type of the coordinate method.</remarks>
        public PositionCoordinateMethodEnumType Method { get; set; }

        /// <remarks> The optional SupplementalGeometryIds element is a list of the
        /// QIF ids of the instances derived from FeatureZoneBaseType
        /// defining the direction of a rectangular or a polar coordinate tolerance zone.</remarks>
        public ArrayReferenceFullType? FeatureZoneIds { get; set; }
    }

    /// <remarks> The PositionCoordinateMethodEnumType enumerates values that describe coordinate methods for the position characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum PositionCoordinateMethodEnumType
    {
        /// <remarks></remarks>
        RECTANGULAR,

        /// <remarks></remarks>
        POLAR,
    }

}
