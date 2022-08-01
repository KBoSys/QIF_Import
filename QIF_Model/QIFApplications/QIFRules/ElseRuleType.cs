/*! \file ElseRuleType.cs
    \brief defines a rule containing an optional 'then points' part which always applies.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The ElseRuleType defines a rule containing an optional 'then points' part which always applies./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElseRuleType : PointRuleBaseType
    {
        /// <remarks The ThenPoints element gives (only) the quantity of points to use./>
        public ThenPointsType ThenPoints { get; set; }
    }

    /// <remarks The ThenPointsType defines an optional choice of four alternative methods for specifying the quantity of hit points to be used. 
    /// In the two density alternatives: 
    /// (1) for curves, the value is in points per unit length in linear units; 
    /// (2) for surfaces, the value is in points per unit area in area units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThenPointsType
    {
        /// <remarks
        /// The NumberOfPoints element is the number of points to be used. 
        /// A larger or smaller number of points must not be used. This element is in an optional choice.
        /// 
        /// The MinPoints element is the minimum number of points to be used. 
        /// A smaller number of points must not be used. 
        /// A larger number of points may be used.This element is in an optional choice.
        /// 
        /// The PointDensity element is the density of points to be used.
        /// A larger or smaller point density must not be used, except as
        /// is unavoidable because the number of points is an integer.
        /// This element is in an optional choice.
        /// 
        /// The MinPointDensity element is the minimum density of points
        /// to be used.A smaller point density must not be used.A larger
        /// point density may be used. This element is in an optional choice./>
        [System.Xml.Serialization.XmlElementAttribute("MinPointDensity", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("MinPoints", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("NumberOfPoints", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("PointDensity", typeof(decimal))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ThenPointsChoiceType ItemElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ThenPointsChoiceType
    {

        /// <remarks/>
        MinPointDensity,

        /// <remarks/>
        MinPoints,

        /// <remarks/>
        NumberOfPoints,

        /// <remarks/>
        PointDensity,
    }
}
