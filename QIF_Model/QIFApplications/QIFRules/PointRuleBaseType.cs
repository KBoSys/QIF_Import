/*! \file PointRuleBaseType.cs
    \brief defines the base type for rules for selecting the number or density of hit points and/or a strategy for selecting the points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks defines the base type for rules for selecting the number or density of hit points and/or a strategy for selecting the points./>
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
    public abstract partial class PointRuleBaseType : QIFRuleBaseType
    {
    }
}
