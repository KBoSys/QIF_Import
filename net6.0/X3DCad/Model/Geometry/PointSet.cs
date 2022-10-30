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
using X3DCad.Model.Nodes;

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

        /// <summary>
        /// If the color field is not NULL, it shall specify a node derived from X3DColorNode that contains at least the number of points contained in the coord node. 
        /// The results are undefined if the color field specifies any other type of node. 
        /// Colours shall be applied to each point in order.
        /// </summary>
        [XmlElement("Color", typeof(X3DCad.Model.Nodes.Color))]
        [XmlElement("ColorRGBA", typeof(X3DCad.Model.Nodes.ColorRGBA))]
        public X3DColorNode? Colors { get; set; }

        /// <summary>
        /// The coord field specifies an X3DCoordinateNode. The results are undefined if the coord field specifies any other type of node. 
        /// PointSet uses the coordinates in order. 
        /// If the coord field is NULL, the point set is considered empty.
        /// </summary>
        [XmlElement("Coordinate", typeof(Coordinates))]
        [XmlElement("CoordinateDouble", typeof(CoordinateDouble))]
        [XmlElement("GeoCoordinate", typeof(GeoCoordinate))]
        public object? Points { get; set; }

        #endregion
    }
}
