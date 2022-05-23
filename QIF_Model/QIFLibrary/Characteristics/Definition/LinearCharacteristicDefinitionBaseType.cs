﻿/*! \file LinearCharacteristicDefinitionBaseType.cs
    \brief The LinearCharacteristicDefinitionBaseType is the abstract base type that defines a linear characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The LinearCharacteristicDefinitionBaseType is the abstract base type that defines a linear characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class LinearCharacteristicDefinitionBaseType : DimensionalCharacteristicDefinitionBaseType
    {
        /// <remarks This compositor provides a choice between a toleranced
        /// characteristic and a non-toleranced characteristic that still needs to be tracked and/or reported./>
        [System.Xml.Serialization.XmlElementAttribute("NonTolerance", typeof(IntermediatesPMI.NonToleranceEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Tolerance", typeof(IntermediatesPMI.LinearToleranceType))]
        public object Item { get; set; }
    }

    /// <summary>
    /// The DistanceBetweenCharacteristicDefinitionType defines information
    /// that can be common to more than one distance-between
    /// characteristic.The DistanceBetweenCharacteristicDefinitionType is used to tolerance between two features.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DistanceBetweenCharacteristicDefinitionType : LinearCharacteristicDefinitionBaseType
    {
    }
}
