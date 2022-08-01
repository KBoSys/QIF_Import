/*! \file ProfileCharacteristicNominalBaseType.cs
    \brief The ProfileCharacteristicNominalBaseType is the abstract base type that defines a unique profile characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks The ProfileCharacteristicNominalBaseType is the abstract base type that defines a unique profile characteristic nominal.
    /// The TargetValue for a profile characteristic can be non-zero to
    /// indicate a target value offset from the nominal surface or curve./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileNonUniformCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointProfileCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ProfileCharacteristicNominalBaseType : GeometricCharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is a non-zero value to
        /// indicate a target value offset from the nominal surface or curve./>
        public LinearValueType TargetValue { get; set; }
    }

    /// <remarks The SurfaceProfileNonUniformCharacteristicNominalType defines a unique non-uniform surface profile characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SurfaceProfileNonUniformCharacteristicNominalType : ProfileCharacteristicNominalBaseType
    {
    }

    /// <remarks The SurfaceProfileCharacteristicNominalType defines a unique
    /// profile of a surface characteristic nominal.The target value for a
    /// profile of a surface characteristic can be non-zero to indicate a
    /// target value offset from the nominal surface./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceProfileCharacteristicNominalType : ProfileCharacteristicNominalBaseType
    {
    }

    /// <remarks The PointProfileCharacteristicNominalType defines a unique point profile characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointProfileCharacteristicNominalType : ProfileCharacteristicNominalBaseType
    {
    }

    /// <remarks The LineProfileCharacteristicNominalType defines a unique line
    /// profile characteristic nominal.The target value for a profile of a
    /// line characteristic can be non-zero to indicate a target value
    /// offset from the nominal curve./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineProfileCharacteristicNominalType : ProfileCharacteristicNominalBaseType
    {
        /// <remarks The vector element is a vector perpendicular to the plane in which the characteristic curve lies./>
        public UnitVectorType Vector { get; set; }

        /// <remarks The optional ProfileCurveId element is the QIF id of the curve feature./>
        public QIFReferenceFullType ProfileCurveId { get; set; }
    }
}
