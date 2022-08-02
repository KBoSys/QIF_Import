/*! \file WeldCharacteristicDefinitionType.cs
    \brief Abstract base type that specifies welding information

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <remarks The WeldCharacteristicDefinitionBaseType is the abstract base type that specifies welding information that can be common
    /// to more than one welding characteristic./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldCompoundCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldEdgeCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSurfacingCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSeamCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldStudCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSpotCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSlotCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletCharacteristicDefinitionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class WeldCharacteristicDefinitionBaseType : CharacteristicDefinitionBaseType
    {
    }

    public class WeldFilletCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldPlugCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldSlotCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldSpotCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldStudCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldSeamCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldSurfacingCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldEdgeCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldSquareCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldBevelCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldVCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldUCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldJCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldFlareVCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldFlareBevelCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    public class WeldScarfCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
    }

    /// <remarks The WeldCompoundCharacteristicDefinitionType defines information that can be common to more than one compound weld characteristic./>
    public class WeldCompoundCharacteristicDefinitionType : WeldCharacteristicDefinitionBaseType
    {
        /// <remarks The WeldCharacteristicDefinitionIds element is a list of the QIF ids of the weld characteristic definitions./>
        public ArrayReferenceFullType WeldCharacteristicDefinitionIds { get; set; }
    }
}
