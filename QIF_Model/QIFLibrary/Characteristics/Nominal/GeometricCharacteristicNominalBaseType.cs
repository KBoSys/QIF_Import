/*! \file GeometricCharacteristicNominalBaseType.cs
    \brief an abstract base type that defines a geometric characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks The GeometricCharacteristicNominalBaseType is the abstract base type that defines a geometric characteristic nominal./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileCharacteristicNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileNonUniformCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointProfileCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RunoutCharacteristicNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalRunoutCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularRunoutCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationCharacteristicNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SymmetryCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcentricityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoaxialityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FormCharacteristicNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherFormCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidicityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatnessCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StraightnessCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientationCharacteristicNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelismCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerpendicularityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class GeometricCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
    }
}
