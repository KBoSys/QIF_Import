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
using System.ComponentModel;
using System.Xml.Linq;
using System.Xml.Serialization;

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

        [XmlElement("Background", typeof(Background))]
        [XmlElement("WorldInfo", typeof(WorldInfo))]
        [XmlElement("Viewpoint", typeof(Viewpoint))]
        #endregion

        #region <xs:group ref="ChildContentModelFull"/>
        //<xs:element ref="CoordinateInterpolator2D"/>
        //<xs:element ref="PositionInterpolator2D"/>
        //<xs:element ref="ClipPlane"/>
        //<xs:element ref="EaseInEaseOut"/>
        //<!--xs:element ref="EnvironmentLight"/ -->
        //<xs:element ref="LinePickSensor"/>
        //<xs:element ref="PickableGroup"/>
        //<xs:element ref="PointPickSensor"/>
        //<xs:element ref="PrimitivePickSensor"/>
        //<xs:element ref="VolumePickSensor"/>
        //<xs:element ref="SplinePositionInterpolator"/>
        //<xs:element ref="SplinePositionInterpolator2D"/>
        //<xs:element ref="SplineScalarInterpolator"/>
        //<xs:element ref="SquadOrientationInterpolator"/>
        //<xs:element ref="StaticGroup"/>
        //<xs:element ref="TextureProjector"/>
        //<xs:element ref="TextureProjectorParallel"/>
        //<xs:element ref="CADLayer"/>
        //<xs:element ref="CADPart"/>
        //<xs:element ref="OrthoViewpoint"/>
        //<xs:element ref="ViewpointGroup"/>
        //<xs:element ref="ColorChaser"/>
        //<xs:element ref="ColorDamper"/>
        //<xs:element ref="CoordinateChaser"/>
        //<xs:element ref="CoordinateDamper"/>
        //<xs:element ref="OrientationChaser"/>
        //<xs:element ref="OrientationDamper"/>
        //<xs:element ref="PositionChaser"/>
        //<xs:element ref="PositionChaser2D"/>
        //<xs:element ref="PositionDamper"/>
        //<xs:element ref="PositionDamper2D"/>
        //<xs:element ref="ScalarChaser"/>
        //<xs:element ref="ScalarDamper"/>
        //<xs:element ref="TexCoordChaser2D"/>
        //<xs:element ref="TexCoordDamper2D"/>
        //<xs:element ref="TextureBackground"/>
        //<xs:element ref="CollidableShape"/>
        //<xs:element ref="CollisionSensor"/>
        //<xs:element ref="RigidBodyCollection"/>
        //<xs:element ref="ParticleSystem"/>
        //<xs:element ref="TransformSensor"/>
        //<xs:element ref="IsoSurfaceVolumeData"/>
        //<xs:element ref="SegmentedVolumeData"/>
        //<xs:element ref="VolumeData"/>
        //<!-- X3D4 Sound Component nodes can also appear with other children nodes to facilitate audio graph construction -->
        //<xs:element ref="Analyser"/>
        //<xs:element ref="AudioDestination"/>
        //<xs:element ref="BiquadFilter"/>
        //<xs:element ref="BufferAudioSource"/>
        //<xs:element ref="ChannelMerger"/>
        //<xs:element ref="ChannelSelector"/>
        //<xs:element ref="ChannelSplitter"/>
        //<xs:element ref="Convolver"/>
        //<xs:element ref="Delay"/>
        //<xs:element ref="DynamicsCompressor"/>
        //<xs:element ref="Gain"/>
        //<xs:element ref="ListenerPointSource"/>
        //<xs:element ref="MicrophoneSource"/>
        //<xs:element ref="OscillatorSource"/>
        //<xs:element ref="SpatialSound"/>
        //<xs:element ref="StreamAudioDestination"/>
        //<xs:element ref="StreamAudioSource"/>
        //<xs:element ref="WaveShaper"/>
        [XmlElement("CADAssembly", typeof(CADAssembly))]
        #endregion

        #endregion

        #region <xs:group ref="ChildContentModelSceneGraphStructure" minOccurs="0" maxOccurs="unbounded"/>
        //<xs:element ref="ROUTE"/>
        //<xs:element ref="ExternProtoDeclare"/>
        //<xs:element ref="ProtoDeclare"/>
        //<xs:element ref="IMPORT"/>
        //<xs:element ref="EXPORT"/>
        #endregion
        #endregion

        /// <summary>
        /// At most one LayerSet can appear in a scene and must be a root node.
        /// </summary>
        #region xs:element ref="LayerSet" minOccurs="0"
        #endregion

        public List<object> Items { get; set; } = new List<object>();
    }
}
