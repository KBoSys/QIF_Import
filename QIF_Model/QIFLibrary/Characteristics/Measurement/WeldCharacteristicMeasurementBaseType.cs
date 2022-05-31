/*! \file WeldCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured welding characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The WeldCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured welding characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldCompoundCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldGrooveCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldEdgeCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSurfacingCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSeamCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldStudCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSpotCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSlotCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class WeldCharacteristicMeasurementBaseType : CharacteristicMeasurementBaseType
    {
    }
}
