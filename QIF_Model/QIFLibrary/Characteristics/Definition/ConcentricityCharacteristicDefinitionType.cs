/*! \file ConcentricityCharacteristicDefinitionType.cs
    \brief The ConcentricityCharacteristicDefinitionType defines information
        that can be common to more than one concentricity characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The ConcentricityCharacteristicDefinitionType defines information that can be common to more than one concentricity characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConcentricityCharacteristicDefinitionType : LocationCharacteristicDefinitionBaseType
    {
        /// <remarks The ZoneShape element describes the shape of the tolerance zone./>
        public ConcentricityZoneShapeType ZoneShape { get; set; }
    }

    /// <remarks The ConcentricityZoneShapeType defines the shape of the tolerance zone for a concentricity characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConcentricityZoneShapeType
    {
        /// <remarks
        /// This compositor provides a choice of the zone shape for a
        /// concentricity characteristic.The zone shape is indicated by any
        /// symbols preceding the tolerance value in the feature control frame./>
        [System.Xml.Serialization.XmlElementAttribute("DiametricalZone", typeof(ConcentricityDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("NonDiametricalZone", typeof(ConcentricityNonDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalZone", typeof(ConcentricitySphericalZoneType))]
        public object Item { get; set; }
    }

    /// <remarks The ConcentricityDiametricalZoneType defines the shape of a
    /// tolerance zone as diametrical(a diameter symbol precedes the
    /// tolerance value in the feature control frame)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConcentricityDiametricalZoneType
    {
    }

    /// <remarks The ConcentricityNonDiametricalZoneType defines the shape of a
    /// tolerance zone as neither diametrical nor spherical(no symbol
    /// precedes the tolerance value in the feature control frame)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConcentricityNonDiametricalZoneType
    {
    }

    /// <remarks The ConcentrictySphericalZoneType defines the shape of a tolerance
    /// zone as spherical(a spherical diameter symbol precedes the
    /// tolerance value in the feature control frame)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ConcentricitySphericalZoneType
    {
    }
}
