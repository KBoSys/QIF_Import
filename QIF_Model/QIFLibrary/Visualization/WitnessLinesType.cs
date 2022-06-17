/*! \file WitnessLinesType.cs
	\brief defines a pair of witness lines or a circular witness line.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The WitnessLinesType defines a pair of witness lines or a circular witness line.
    /// The circular witness line must be less than a semicircle./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WitnessLinesType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BeginPoint", typeof(Point2dSimpleType))]
        [System.Xml.Serialization.XmlElementAttribute("CircleCenter", typeof(Point2dSimpleType))]
        [System.Xml.Serialization.XmlElementAttribute("CircleRadius", typeof(double))]
        [System.Xml.Serialization.XmlElementAttribute("EndPoint", typeof(Point2dSimpleType))]
        [System.Xml.Serialization.XmlElementAttribute("Segment1", typeof(LineSegment2dType))]
        [System.Xml.Serialization.XmlElementAttribute("Segment2", typeof(LineSegment2dType))]
        [System.Xml.Serialization.XmlElementAttribute("ZextensionPoint1", typeof(PointSimpleType))]
        [System.Xml.Serialization.XmlElementAttribute("ZextensionPoint2", typeof(PointSimpleType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("WitnessLinesElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public WitnessLinesChoiceType[] WitnessLinesElementName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double width { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum WitnessLinesChoiceType
    {
        /// <remarks The BeginPoint element is the begin point of the circular witness line./>
        BeginPoint,

        /// <remarks The CircleCenter element is the center of the circular witness line./>
        CircleCenter,

        /// <remarks The CircleRadius element is the radius of the circular witness line./>
        CircleRadius,

        /// <remarks The EndPoint element is the end point of the circular witness line./>
        EndPoint,

        /// <remarks The Segment1 element is the first witness line./>
        Segment1,

        /// <remarks The Segment2 element is the second witness line./>
        Segment2,

        /// <remarks The optional ZextensionPoint1 element is an extension point
        /// of the first witness line, it lies on the feature in cases
        /// when the annotation plane does not intersect the feature./>
        ZextensionPoint1,

        /// <remarks The optional ZextensionPoint2 element is an extension point
        /// of the second witness line, it lies on the feature in cases
        /// when the annotation plane does not intersect the feature./>
        ZextensionPoint2,
    }
}
