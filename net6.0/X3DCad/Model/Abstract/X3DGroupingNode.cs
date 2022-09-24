/*! \file X3DGroupingNode.cs
	\brief Grouping nodes can contain other nodes as children, thus making up the backbone of a scene graph.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;

namespace X3DCad.Model.Abstract
{
    #region <xs:group ref="ChildContentModelFull"/>
    [XmlInclude(typeof(CADAssembly))]
    #endregion
    /// <summary>
    /// Grouping nodes can contain other nodes as children, thus making up the backbone of a scene graph.
    /// </summary>
    public abstract class X3DGroupingNode : X3DChildNode
    {
        #region Properties
        [XmlIgnore]
        public SFVec3f? BboxCenter { get; set; }

        [XmlIgnore]
        public bboxSizeType? BboxSizeType { get; set; }
        #endregion

        #region <xs:group ref="ChildContentModel" minOccurs="0" maxOccurs="unbounded"/>
        //<xs:group ref="ChildContentModelInterchange"/>
        //<xs:group ref="ChildContentModelInteractive"/>
        //<xs:group ref="ChildContentModelImmersive"/>
        //<xs:group ref="ChildContentModelDIS"/>
        //<xs:group ref="ChildContentModelGeoSpatial"/>
        //<xs:group ref="ChildContentModelHumanoidAnimation"/>
        //<xs:group ref="ChildContentModelNurbs"/>
        //<xs:group ref="ChildContentModelProtoInstance"/>

        #region <xs:group ref="ChildContentModelFull"/>
        [XmlElement("CADAssembly", typeof(CADAssembly))]
        [XmlElement("CADPart", typeof(CADPart))]
        #endregion

        #endregion
        #region <xs:group ref="ChildContentModelSceneGraphStructure" minOccurs="0" maxOccurs="unbounded"/>
        #endregion
        public object[]? Children { get; set; }

        [XmlAttribute("bboxCenter")]
        public string? BboxCenterText 
        { 
            get => BboxCenter?.ToString();
            set => BboxCenter = SFVec3f.CreateFromString(value);
        }

        [XmlAttribute("bboxSize")]
        public string? BboxSizeText 
        { 
            get => BboxSizeType?.ToString(); 
            set => BboxSizeType = bboxSizeType.CreateFromString(value); 
        }

        [XmlAttribute("bboxDisplay")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BboxDisplay { get; set; } = false;

        [XmlAttribute("visible")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Visible { get; set; } = true;
    }
}
