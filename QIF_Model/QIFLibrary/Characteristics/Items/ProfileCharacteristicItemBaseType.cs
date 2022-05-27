/*! \file ProfileCharacteristicItemBaseType.cs
    \brief abstract base type that defines a profile characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks The ProfileCharacteristicItemBaseType is the abstract base type that defines a profile characteristic item./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ProfileCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks TODO/>
    public class SurfaceProfileNonUniformCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class SurfaceProfileCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class PointProfileCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class LineProfileCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

}
