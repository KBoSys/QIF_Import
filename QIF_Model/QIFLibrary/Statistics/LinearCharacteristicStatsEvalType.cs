/*! \file LinearCharacteristicStatsEvalType.cs
    \brief 
        base type that defines the results of a statistical evaluation of
        measured values with linear units or their deviations from nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The LinearCharacteristicStatsEvalType is the base
    /// type that defines the results of a statistical evaluation of
    /// measured values with linear units or their deviations from nominal.
    /// The type itself can be used to accumulate summary statistics over
    /// different types of linear characteristics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatTaperCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalTaperCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChordCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalRadiusCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RadiusCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBetweenCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceFromCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThicknessCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DepthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HeightCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WidthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalDiameterCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiameterCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveLengthCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCoordinateCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsLinearType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolLinearType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[] ItemsElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FlatTaperCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalTaperCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ChordCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalRadiusCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RadiusCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistanceBetweenCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistanceFromCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SquareCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThicknessCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DepthCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HeightCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WidthCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LengthCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalDiameterCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DiameterCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CurveLengthCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearCoordinateCharacteristicStatsEvalType : LinearCharacteristicStatsEvalType
    {
    }
}
