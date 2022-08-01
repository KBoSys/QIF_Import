/*! \file QIFRuleBaseType.cs
    \brief The abstract QIFRuleBaseType defines the base type for all QIF rules.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The abstract QIFRuleBaseType defines the base type for all QIF rules./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenDMERuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointRuleBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElseRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenFeatureRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCurveRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSurfaceRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenTorusRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenToroidalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSurfaceOfRevolutionRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSphericalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSphereRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPointRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPointDefinedSurfaceRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPointDefinedCurveRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPlaneRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeParallelPlanesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeParallelLinesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeAngledPlanesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeAngledLinesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenLineRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenExtrudedCrossSectionRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenElongatedCylinderRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenElongatedCircleRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenEllipticalArcRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenEllipseRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCylindricalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCylinderRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenConicalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenConeRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCircularArcRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCircleRuleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class QIFRuleBaseType
    {
        /// <remarks The optional UUID element is a persistent identifier for the rule.
        /// If used, it should be generated using a widely accepted UUID generator./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public QIFLibrary.Primitives.QPIdType UUID { get; set; }

        /// <remarks The optional name attribute is the name of the rule./>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }
    }
}
