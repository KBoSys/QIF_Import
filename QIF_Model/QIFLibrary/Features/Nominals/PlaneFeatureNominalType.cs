/*! \file PlaneFeatureNominalType.cs
    \brief defines the plane feature nominal information for an individual plane feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The PlaneFeatureNominalType defines the plane feature nominal information for an individual plane feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks The Location element is the nominal location of a point on the plane./>
        public PointType Location { get; set; }

        /// <remarks The Normal element is the nominal unit normal vector of the plane./>
        public UnitVectorType Normal { get; set; }

        /// <remarks This optional compositor provides a choice among methods of representing the extent and boundary of the plane./>
        [System.Xml.Serialization.XmlElementAttribute("Circle", typeof(CircleType))]
        [System.Xml.Serialization.XmlElementAttribute("PolyLine", typeof(PolyLineType))]
        [System.Xml.Serialization.XmlElementAttribute("Rectangle", typeof(RectangleType))]
        public object Item { get; set; }

        /// <remarks The optional Constructed element signifies that the plane is constructed and provides details of the construction method./>
        public PlaneConstructionMethodType Constructed { get; set; }
    }

    /// <remarks The PlaneConstructionMethodType defines the method for constructing a unique nominal or measured plane feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneConstructionMethodType
    {
        /// <remarks This optional compositor provides a choice of the construction method for the plane./>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(PlaneBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(PlaneCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(PlaneCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Extract", typeof(PlaneExtractType))]
        [System.Xml.Serialization.XmlElementAttribute("Midplane", typeof(PlaneMidplaneType))]
        [System.Xml.Serialization.XmlElementAttribute("Offset", typeof(PlaneOffsetType))]
        [System.Xml.Serialization.XmlElementAttribute("Parallel", typeof(PlaneParallelType))]
        [System.Xml.Serialization.XmlElementAttribute("Perpendicular", typeof(PlanePerpendicularType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(PlaneRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("TangentThrough", typeof(PlaneTangentThroughType))]
        [System.Xml.Serialization.XmlElementAttribute("Through", typeof(PlaneThroughType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(PlaneTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
