/*! \file SceneType.cs
	\brief 
        Scene is the root element that contains an X3D scene graph, appearing after the head of an X3D model. 
        Add nodes, statements and comments to build an X3D model. Only one Scene root element is allowed per X3D file.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Nodes;
using X3DCad.Model.Metadata;
using X3DCad.Model.Abstract;

namespace X3DCad.Model
{
    /// <summary>
    /// Scene is the implicit root node of the X3D scene graph.
    /// </summary>
    public class SceneType : X3DStatement
    {
        #region xs:group ref="ChildContentModelCore"
        [System.Xml.Serialization.XmlElementAttribute("MetadataBoolean", typeof(MetadataBoolean))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataDouble", typeof(MetadataDouble))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataFloat", typeof(MetadataFloat))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataInteger", typeof(MetadataInteger))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataString", typeof(MetadataString))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataSet", typeof(MetadataSet))]
        #endregion

        /// Child-node content model corresponding to X3DChildNode.  
        /// GroupingNodeChildContentModel can contain most nodes, other Grouping nodes, Prototype declarations and ProtoInstances in any order and any combination.  
        /// When less that Full profile, the precise palette of legal nodes that are available depends on profile and components.
        #region xs:group ref="GroupingNodeChildContentModel"
        #region <xs:group ref="ChildContentModel" minOccurs="0" maxOccurs="unbounded"/>
        //<xs:group ref="ChildContentModelInterchange"/>
        //<xs:group ref="ChildContentModelInteractive"/>
        //<xs:group ref="ChildContentModelImmersive"/>
        //<xs:group ref="ChildContentModelFull"/>
        //<xs:group ref="ChildContentModelDIS"/>
        //<xs:group ref="ChildContentModelGeoSpatial"/>
        //<xs:group ref="ChildContentModelHumanoidAnimation"/>
        //<xs:group ref="ChildContentModelNurbs"/>
        //<xs:group ref="ChildContentModelProtoInstance"/>
        #region <xs:group name="ChildContentModelInterchange">
        //<xs:element ref="ColorInterpolator"/>
        //<xs:element ref="CoordinateInterpolator"/>
        //<xs:element ref="DirectionalLight"/>
        //<xs:element ref="Group"/>
        //<xs:element ref="NavigationInfo"/>
        //<xs:element ref="NormalInterpolator"/>
        //<xs:element ref="OrientationInterpolator"/>
        //<xs:element ref="PositionInterpolator"/>
        //<xs:element ref="ScalarInterpolator"/>
        //<xs:element ref="Shape"/>
        //<xs:element ref="TimeSensor"/>
        //<xs:element ref="Transform"/>
        [System.Xml.Serialization.XmlElementAttribute("Background", typeof(Background))]
        [System.Xml.Serialization.XmlElementAttribute("WorldInfo", typeof(WorldInfo))]
        [System.Xml.Serialization.XmlElementAttribute("Viewpoint", typeof(Viewpoint))]
        #endregion

        #endregion

        #region <xs:group ref="ChildContentModelSceneGraphStructure" minOccurs="0" maxOccurs="unbounded"/>
        #endregion
        #endregion

        /// <summary>
        /// At most one LayerSet can appear in a scene and must be a root node.
        /// </summary>
        #region xs:element ref="LayerSet" minOccurs="0"
        #endregion

        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("SceneItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SceneItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SceneItemsChoiceType[]? SceneItemsElementName { get; set; }
    }

    public enum SceneItemsChoiceType
    {
        // ChildContentModelCore
        MetadataBoolean,
        MetadataDouble,
        MetadataFloat,
        MetadataInteger,
        MetadataString,
        MetadataSet,

        // ChildContentModelInterchange
        Background,
        WorldInfo,
        Viewpoint,
    }
}
