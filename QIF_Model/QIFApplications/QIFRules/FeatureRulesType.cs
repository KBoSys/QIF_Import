/*! \file FeatureRulesType.cs
    \brief Defines two methods of setting the quantity of hit points

          The FeatureRulesType defines two methods of setting the quantity
        of hit points to use for a feature and/or a strategy to use for
        selecting the hit points and/or the substitute feature algorithm to
        use to fit the feature to the hit points. If the
        IfThenElseFeatureRules and MaxFeatureRules are both used to find
        the quantity of points for a feature, both sets of rules should be
        applied and the maximum value should be used. Also if both are used
        and they give different point sampling strategies or different
        substitute feature algorithms, the evaluating system may use any of
        those strategies or algorithms.

          Since a given feature F may be associated with zero to many
        characteristics C1 ... Cn, if there is any characteristic
        associated with F, the rules should be evaluated for each FCi pair,
        and the number or density of hit points to use for F should be set
        to the maximum value.

          If a number of hit points must be compared with a density of hit
        points, the evaluating system should find and use the area of the
        feature to convert density values to numbers of points.

          So that a single rules file may be used in different situations,
        the rules include a SamplingCategoryIs Boolean expression that
        tests whether the sampling category is equal to a particular value.
        If a set of rules includes one or more rules containing a
        SamplingCategoryIs test, the rules are to be evaluated in an
        environment in which the sampling category has been set to some
        positive integer. The meaning of a sampling category is determined
        by whoever writes the rules. For example, 1 might mean first
        article inspection while 5 means process control. As another
        example, Sampling categories 1 through 3 might represent LOW,
        MEDIUM, and HIGH, respectively. An alternative to using rules
        containing SamplingCategoryIs tests is to write a separate rules
        file for each category.

          Numerical quantities that are constants, feature parameters, or
        characteristic parameters may be used in conditions.

          The numerical quantities FeatureLength and FeatureArea may also
        be used in conditions. The evaluating system must set the value of
        FeatureLength for the feature being processed if FeatureLength is
        used in any condition. The evaluating system must set the value of
        FeatureArea for the feature being processed if FeatureArea is used
        in any condition.

          The rules are not intended for picking the quantity of points or
        point sampling strategy to use for measuring a characteristic that
        is not associated with any feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks Defines two methods of setting the quantity of hit points/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureRulesType
    {
        /// <remarks The optional IfThenElseFeatureRules element is a set of rules
        /// for selecting the number or density of hit points for a feature
        /// and/or a strategy to use for selecting the hit points and/or a
        /// substitute feature algorithm.The first rule that applies is
        /// used to set the quantity of hit points and/or the strategy and/or the algorithm./>
        public IfThenElseFeatureRulesType IfThenElseFeatureRules { get; set; }

        /// <remarks The optional MaxFeatureRules element is a set of rules for
        /// selecting the number or density of hit points for a feature
        /// and/or a strategy to use for selecting the hit points and/or a
        /// substitute feature algorithm.The largest value returned by all
        /// rules that apply is used to set the quantity of hit points.If
        /// the rules that apply give different point sampling strategies
        /// or substitute feature algorithms, the evaluating system may use
        /// any of those strategies or algorithms./>
        public MaxFeatureRulesType MaxFeatureRules { get; set; }
    }

    /// <remarks The IfThenElseFeatureRulesType defines a set of rules for selecting
    /// (1) the number or density of hit points for a single feature,
    /// possibly with an associated characteristic, and/or 
    /// (2) a strategy for selecting the points, and/or(3) the substitute feature
    /// algorithm to use to fit the feature to the hit points.
    /// To evaluate an IfThenElseFeatureRulesType, each IfThenFeatureRule should be
    /// considered in order until the 'if' part of one of them evaluates to
    /// true, at which point the 'then' part of the rule should be
    /// evaluated and the value of the point quantity and or point sampling
    /// strategy returned. In this case, the remainder of the
    /// IfThenFeatureRules should be ignored. If the 'if' part of no
    /// IfThenFeatureRule evaluates to true, then the 'then' part of the
    /// Else should be evaluated and returned./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenElseFeatureRulesType
    {
        /// <remarks Each IfThenFeatureRule element defines a conditional rule for selecting the number or density of hit points./>
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
        public IfThenFeatureRuleType[] IfThenFeatureRule { get; set; }

        /// <remarks The optional Else element is an unconditional rule for selecting the number or density of hit points./>
        public ElseRuleType Else { get; set; }

        /// <remarks The required n attribute is the number of rules in this list,
        /// which is the number of if-then-rules plus one for the else-rule if present./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get
            {
                uint cnt = this.IfThenFeatureRule != null ? (uint)this.IfThenFeatureRule.Length : 0;
                if (this.Else != null)
                {
                    ++cnt;
                }
                return cnt;
            }
            set { }
        }
    }
}
