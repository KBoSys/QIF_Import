/*! \file FormCharacteristicItemBaseType.cs
    \brief abstract base type that defines a form characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks The FormCharacteristicItemBaseType is the abstract base type that defines a form characteristic item./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherFormCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidicityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatnessCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StraightnessCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FormCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks The OtherFormCharacteristicItemType defines a form characteristic item. 
    /// This characteristic is used when a specific form type is not
    /// applicable.This characteristic is not to be used for circularity,
    /// cylindricity, conicity, ellipticity, flatness, sphericity, straightness or toroidicity./>
    public class OtherFormCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The ToroidicityCharacteristicItemType defines a toroidicity characteristic item./>
    public class ToroidicityCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The SphericityCharacteristicItemType defines a sphericity characteristic item./>
    public class SphericityCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The EllipticityCharacteristicItemType defines an ellipticity characteristic item./>
    public class EllipticityCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The CylindricityCharacteristicItemType defines a cylindricity characteristic item./>
    public class CylindricityCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The CylindricityCharacteristicItemType defines a cylindricity characteristic item./>
    public class ConicityCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The CircularityCharacteristicItemType defines a circularity or roundness characteristic item./>
    public class CircularityCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The FlatnessCharacteristicItemType defines a flatness characteristic item./>
    public class FlatnessCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }

    /// <remarks The StraightnessCharacteristicItemType defines a straightness characteristic item./>
    public class StraightnessCharacteristicItemType : FormCharacteristicItemBaseType
    {

    }
}
