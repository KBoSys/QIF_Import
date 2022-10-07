/*! \file PointSet.cs
	\brief The PointSet node specifies a set of 3D points, in the local coordinate system, with associated colours at each point.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The PointSet node specifies a set of 3D points, in the local coordinate system, with associated colours at each point.
    /// </summary>
    public class PointSet : GeometryBase
    {
        /// <summary>
        /// ColorCoordinateContentModel is the child-node content model utilized by IndexedLineSet, LineSet and PointSet.  
        /// ColorCoordinateContentModel can contain any-order Coordinate (or CoordinateDouble) node with Color (or ColorRGBA) node.  
        /// No more than one instance of any single node type is allowed.
        /// </summary>
        #region <xs:group ref="ColorCoordinateContentModel" minOccurs="0"/>
        public ProtoInstance? ProtoInstance { get; set; }

        [XmlElement("Color", typeof(X3DCad.Model.Nodes.Color))]
        [XmlElement("ColorRGBA", typeof(X3DCad.Model.Nodes.ColorRGBA))]
        public object? Color { get; set; }

        // Coordinate
        // CoordinateDouble
        // GeoCoordinate
        public object? Coordinate { get; set; }

        #endregion
    }
}
