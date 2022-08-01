/*! \file MaxFeatureRulesType.cs
    \brief Defines a set of rules for selecting

        The MaxFeatureRulesType defines a set of rules for selecting (1)
        the number or density of hit points for a single feature, possibly
        with an associated characteristic and/or (2) a strategy for
        selecting the points, and/or (3) the substitute feature algorithm
        to use to fit the feature to the hit points. To evaluate a
        MaxFeatureRulesType, keep track of a current answer for point
        quantity, which is initially set to zero. Each IfThenFeatureRule
        should be considered in order. If the 'if' part of a rule evaluates
        to true, the 'then' part of the rule should be evaluated and if
        that value is greater than the current answer, the current answer
        should be set to that value. If the 'if' part of no
        IfThenFeatureRule evaluates to true, so that the current answer is
        still zero after all IfThenFeatureRules have been processed, then
        the 'then' part of the Else should be evaluated and the current
        answer set to that value. The returned value for point quantity is
        the final value of the current answer. In addition to keeping track
        of the current answer for point quantity, the evaluating system
        should collect all the strategies and substitute feature algorithms
        from the 'then' parts that were evaluated.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks Defines a set of rules for selecting/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MaxFeatureRulesType
    {
        /// <remarks Each IfThenFeatureRule element defines a conditional rule for
        /// selecting the number or density of hit points and/or a strategy
        /// for selecting the points, and/or a substitute feature algorithm./>
        [System.Xml.Serialization.XmlElementAttribute("IfThenFeatureRule")]
        [System.Xml.Serialization.XmlElementAttribute("IfThenCurveRule", typeof(IfThenCurveRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenSurfaceRule", typeof(IfThenSurfaceRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenCircleRule", typeof(IfThenCircleRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenCircularArcRule", typeof(IfThenCircularArcRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenConeRule", typeof(IfThenConeRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenConicalSegmentRule", typeof(IfThenConicalSegmentRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenCylinderRule", typeof(IfThenCylinderRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenCylindricalSegmentRule", typeof(IfThenCylindricalSegmentRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenEllipseRule", typeof(IfThenEllipseRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenEllipticalArcRule", typeof(IfThenEllipticalArcRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenElongatedCircleRule", typeof(IfThenElongatedCircleRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenElongatedCylinderRule", typeof(IfThenElongatedCylinderRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenExtrudedCrossSectionRule", typeof(IfThenExtrudedCrossSectionRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenLineRule", typeof(IfThenLineRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenOppositeAngledLinesRule", typeof(IfThenOppositeAngledLinesRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenOppositeAngledPlanesRule", typeof(IfThenOppositeAngledPlanesRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenOppositeParallelLinesRule", typeof(IfThenOppositeParallelLinesRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenOppositeParallelPlanesRule", typeof(IfThenOppositeParallelPlanesRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenPlaneRule", typeof(IfThenPlaneRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenPointDefinedCurveRule", typeof(IfThenPointDefinedCurveRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenPointDefinedSurfaceRule", typeof(IfThenPointDefinedSurfaceRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenPointRule", typeof(IfThenPointRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenSphereRule", typeof(IfThenSphereRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenSphericalSegmentRule", typeof(IfThenSphericalSegmentRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenSurfaceOfRevolutionRule", typeof(IfThenSurfaceOfRevolutionRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenToroidalSegmentRule", typeof(IfThenToroidalSegmentRuleType))]
        [System.Xml.Serialization.XmlElementAttribute("IfThenTorusRule", typeof(IfThenTorusRuleType))]
        public IfThenFeatureRuleType[] IfThenFeatureRules { get; set; }

        /// <remarks The optional Else element is an unconditional rule for selecting the number or density of hit points./>
        public ElseRuleType Else { get; set; }

        /// <remarks The required n attribute is the number of rules in this list,
        /// which is the number of if-then-rules plus one for the else-rule if present./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.IfThenFeatureRules.Length;
            set { }
        }
    }
}
