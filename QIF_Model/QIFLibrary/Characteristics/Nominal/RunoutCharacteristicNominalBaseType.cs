/*! \file RunoutCharacteristicNominalBaseType.cs
    \brief The RunoutCharacteristicNominalBaseType is the abstract base type that defines a unique runout characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks The RunoutCharacteristicNominalBaseType is the abstract base type that defines a unique runout characteristic nominal./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalRunoutCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularRunoutCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class RunoutCharacteristicNominalBaseType : GeometricCharacteristicNominalBaseType
    {
    }

    /// <remarks The TotalRunoutCharacteristicNominalType defines a unique total runout characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TotalRunoutCharacteristicNominalType : RunoutCharacteristicNominalBaseType
    {
    }

    /// <remarks The CircularRunoutCharacteristicNominalType defines a unique circular runout characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularRunoutCharacteristicNominalType : RunoutCharacteristicNominalBaseType
    {
        /// <remarks The optional ZoneDirection element gives the direction for
        /// the tolerance zone width when it is not normal to the product surface./>
        public UnitVectorType ZoneDirection { get; set; }

        /// <remarks The optional ProfileCurveId element is the QIF id of the curve feature./>
        public QIFReferenceFullType ProfileCurveId { get; set; }
    }
}
