/*! \file CurveCoreBaseType.cs
	\brief abstract base type for all mathematical cores of 2D and 3D curves present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The CurveCoreBaseType is the abstract base type for all mathematical
    /// cores of 2D and 3D curves present in the CAD scene.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline13CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate13CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline13CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs13CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular13CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic13CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment12CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment13CoreType))]
    public abstract class CurveCoreBaseType
    {
        private ParameterRangeType rangeField = new ParameterRangeType();

        /// <remarks> The required domain attribute is the domain of the parameterization of the curve.</remarks>
        [System.Xml.Serialization.XmlAttribute("domain")]
        public double[] Domain { get => rangeField.Value; set => rangeField.Value = value; }
    }

    /// <remarks> The Curve13CoreType represents a container for a single 3D curve.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Curve13CoreType
    {
        /// <remarks> The Curve13 element is a 3D curve (curve(t):R1->R3).</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Segment13Core", typeof(Segment13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("ArcConic13Core", typeof(ArcConic13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("ArcCircular13Core", typeof(ArcCircular13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Nurbs13Core", typeof(Nurbs13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Spline13Core", typeof(Spline13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Aggregate13Core", typeof(Aggregate13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Polyline13Core", typeof(Polyline13CoreType))]
        public CurveCoreBaseType? Curve13Core { get; set; }
    }
}
