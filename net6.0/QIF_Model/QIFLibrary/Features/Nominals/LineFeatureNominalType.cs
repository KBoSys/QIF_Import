/*! \file LineFeatureNominalType.cs
    \brief Defines the line feature nominal information for an individual line feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The LineFeatureNominalType defines the line feature nominal information for an individual line feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal location of the start point of the line.</remarks>
        public PointType? Location { get; set; }

        /// <remarks> The Direction element is the nominal unit vector representing the direction of the line.</remarks>
        public UnitVectorType? Direction { get; set; }

        /// <remarks> The optional Length element is the nominal length of the line from the starting point in the line direction.</remarks>
        public LinearValueType? Length { get; set; }

        /// <remarks> The optional Normal element is the nominal unit normal of the surface in which the line lies.</remarks>
        public UnitVectorType? Normal { get; set; }

        /// <remarks> The optional Constructed element signifies that the line is constructed and provides details of the construction method.</remarks>
        public LineConstructionMethodType? Constructed { get; set; }
    }

    /// <remarks> The LineConstructionMethodType defines the method for constructing a unique nominal or measured line feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineConstructionMethodType
    {
        /// <remarks> This optional compositor provides a choice of the construction method for the line.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(LineBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(LineCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(LineCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Extract", typeof(LineExtractType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(LineFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersection", typeof(LineIntersectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Midline", typeof(LineMidlineType))]
        [System.Xml.Serialization.XmlElementAttribute("Parallel", typeof(LineParallelType))]
        [System.Xml.Serialization.XmlElementAttribute("Perpendicular", typeof(LinePerpendicularType))]
        [System.Xml.Serialization.XmlElementAttribute("Projection", typeof(LineProjectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(LineRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("TangentThrough", typeof(LineTangentThroughType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(LineTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
