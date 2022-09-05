﻿/*! \file EdgePointFeatureNominalType.cs
    \brief The EdgePointFeatureNominalType defines the edge-point feature
        nominal information for an individual edge-point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The EdgePointFeatureNominalType defines the edge-point feature	nominal information for an individual edge-point feature.</remarks>
    public class EdgePointFeatureNominalType : PointFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal location of a point on the edge between two surfaces.</remarks>
        [XmlElement]
        public Primitives.PointType Location { get; set; }

        /// <remarks> The Normal element is the nominal unit normal vector of the edge surface.</remarks>
        [XmlElement]
        public Primitives.UnitVectorType Normal { get; set; }

        /// <remarks> The optional AdjacentNormal element is the nominal unit normal vector of the surface adjacent to the edge surface.</remarks>
        [XmlElement]
        public Primitives.UnitVectorType AdjacentNormal { get; set; }

        /// <remarks> The optional Constructed element signifies that the edge
        /// point is constructed and provides details of the construction method.</remarks>
        [XmlElement]
        public EdgePointConstructionMethodType Constructed { get; set; }
    }
}
