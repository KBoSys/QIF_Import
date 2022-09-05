/*! \file OrientationCharacteristicNominalBaseType.cs
    \brief Abstract base type that defines a unique orientation characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks> The OrientationCharacteristicNominalBaseType is the abstract base type that defines a unique orientation characteristic nominal.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelismCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerpendicularityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class OrientationCharacteristicNominalBaseType : GeometricCharacteristicNominalBaseType
    {
    }

    /// <remarks> The ParallelismCharacteristicNominalType defines a unique parallelism characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelismCharacteristicNominalType : OrientationCharacteristicNominalBaseType
    {
    }

    /// <remarks> The PerpendicularityCharacteristicNominalType defines a unique perpendicularity characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PerpendicularityCharacteristicNominalType : OrientationCharacteristicNominalBaseType
    {
    }

    /// <remarks> The AngularityCharacteristicNominalType defines a unique angularity characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularityCharacteristicNominalType : OrientationCharacteristicNominalBaseType
    {
        /// <remarks></remarks>
        public AngularValueType? Angle { get; set; }
    }
}
