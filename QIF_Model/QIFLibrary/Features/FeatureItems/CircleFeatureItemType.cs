﻿/*! \file CircleFeatureItemType.cs
    \brief Defines an individual circle feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks The CircleFeatureItemType defines an individual circle feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks The DeterminationMode element is the means by which the circle feature measurement is determined./>
        public CircleMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks The CircleMeasurementDeterminationType defines how the circle
    /// measurement is determined, either by being set or by being checked (directly measured or constructed)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CircleMeasurementDeterminationType
    {
        /// <remarks The Checked element signifies that the circle is checked from measured data, either directly measured or constructed./>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(CircleCheckedFeatureType))]
        /// <remarks The Set element signifies that the circle measurement is set to its nominal value../>
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks The CircleCheckedFeatureType defines that a circle feature is checked./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CircleCheckedFeatureType
    {
        /// <remarks/>
        public CircleCheckedType CheckDetails { get; set; }
    }

    /// <remarks The optional CheckDetails element gives details about the circle check(measurement or construction)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleCheckedType
    {
        /// <remarks The Measured element signifies that the circle is directly measured./>
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        /// <remarks The Constructed element signifies that the circle is constructed./>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(Nominals.CircleConstructionMethodType))]
        public object Item { get; set; }
    }
}
