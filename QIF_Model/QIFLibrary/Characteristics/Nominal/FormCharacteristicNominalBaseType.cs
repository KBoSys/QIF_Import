/*! \file FormCharacteristicNominalBaseType.cs
    \brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherFormCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidicityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularityCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatnessCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StraightnessCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FormCharacteristicNominalBaseType : GeometricCharacteristicNominalBaseType
    {
    }

    /// <remarks The OtherFormCharacteristicNominalType defines a unique form characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherFormCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The ToroidicityCharacteristicNominalType defines a unique toroidicity characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidicityCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The SphericityCharacteristicNominalType defines a unique sphericity characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericityCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The EllipticityCharacteristicNominalType defines a unique ellipticity characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticityCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The CylindricityCharacteristicNominalType defines a unique cylindricity characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricityCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The ConicityCharacteristicNominalType defines a unique conicity characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicityCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The CircularityCharacteristicNominalType defines a unique circularity or roundness characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularityCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
        /// <remarks The optional ProfileCurveId element is the QIF id of the curve feature./>
        public QIFReferenceFullType ProfileCurveId { get; set; }
    }

    /// <remarks The FlatnessCharacteristicNominalType defines a unique flatness characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FlatnessCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
    }

    /// <remarks The StraightnessCharacteristicNominalType defines a unique straightness characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StraightnessCharacteristicNominalType : FormCharacteristicNominalBaseType
    {
        /// <remarks The optional DirectionCurveId element is the QIF id of the curve feature./>
        public QIFReferenceFullType DirectionCurveId { get; set; }
    }
}
