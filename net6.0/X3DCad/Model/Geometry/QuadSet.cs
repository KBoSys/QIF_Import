/*! \file QuadSet.cs
	\brief QuadSet is a geometry node that defines quadrilaterals.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// QuadSet is a geometry node that defines quadrilaterals.
    /// </summary>
    public class QuadSet : ComposedGeometryBase
    {
    }

    /// <summary>
    /// IndexedQuadSet is a geometry node that defines quadrilaterals.
    /// IndexedQuadSet uses the indices in its index field to specify the vertices of each quad from the coord field.
    /// Each quad is formed from a set of four vertices of the X3DCoordinateNode node identified by four consecutive indices from the index field. 
    /// If the index field does not contain a multiple of four coordinate values, the remaining vertices shall be ignored.
    /// </summary>
    public class IndexedQuadSet : QuadSet
    {
        [XmlIgnore]
        public MFInt32 Index { get; set; } = new MFInt32();

        [XmlAttribute("index")]
        public string? IndexAsText { get => Index.ToString(); set => Index.FromString(value); }
    }
}
