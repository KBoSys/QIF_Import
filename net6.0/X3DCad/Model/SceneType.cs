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
using System.Text.RegularExpressions;

namespace X3DCad.Model
{
    /// <summary>
    /// Scene is the implicit root node of the X3D scene graph.
    /// </summary>
    public class SceneType : X3DStatement
    {
        #region XML Serialization

        #region xs:group ref="ChildContentModelCore"
        [XmlElement("MetadataBoolean", typeof(MetadataBoolean))]
        [XmlElement("MetadataDouble", typeof(MetadataDouble))]
        [XmlElement("MetadataFloat", typeof(MetadataFloat))]
        [XmlElement("MetadataInteger", typeof(MetadataInteger))]
        [XmlElement("MetadataString", typeof(MetadataString))]
        [XmlElement("MetadataSet", typeof(MetadataSet))]
        #endregion

        /// Child-node content model corresponding to X3DChildNode.  
        /// GroupingNodeChildContentModel can contain most nodes, other Grouping nodes, Prototype declarations and ProtoInstances in any order and any combination.  
        /// When less that Full profile, the precise palette of legal nodes that are available depends on profile and components.
        #region xs:group ref="GroupingNodeChildContentModel"
        #region <xs:group ref="ChildContentModel" minOccurs="0" maxOccurs="unbounded"/>

        //TODO:
        #region <xs:group name="ChildContentModelInteractive">
        //<xs:element ref="Anchor"/>
        //<xs:element ref="BooleanFilter"/>
        //<xs:element ref="BooleanSequencer"/>
        //<xs:element ref="BooleanToggle"/>
        //<xs:element ref="BooleanTrigger"/>
        //<xs:element ref="CylinderSensor"/>
        //<xs:element ref="Inline"/>
        //<xs:element ref="IntegerSequencer"/>
        //<xs:element ref="IntegerTrigger"/>
        //<xs:element ref="KeySensor"/>
        //<xs:element ref="PlaneSensor"/>
        //<xs:element ref="PointLight"/>
        //<xs:element ref="ProximitySensor"/>
        //<xs:element ref="SphereSensor"/>
        //<xs:element ref="SpotLight"/>
        //<xs:element ref="StringSensor"/>
        //<xs:element ref="Switch"/>
        //<xs:element ref="TimeTrigger"/>
        //<xs:element ref="TouchSensor"/>
        #endregion <xs:group name="ChildContentModelInteractive">

        //TODO:
        #region <xs:group name="ChildContentModelImmersive">
        //<xs:element ref="AudioClip"/>
        //<xs:element ref="Billboard"/>
        //<xs:element ref="Collision"/>
        //<xs:element ref="Fog"/>
        //<xs:element ref="LoadSensor"/>
        //<xs:element ref="LocalFog"/>
        //<xs:element ref="LOD"/>
        //<xs:element ref="Script"/>
        //<xs:element ref="Sound"/>
        //<xs:element ref="VisibilitySensor"/>
        #endregion <xs:group name="ChildContentModelImmersive">

        //TODO:
        #region <xs:group name="ChildContentModelDIS">
        //<xs:element ref="EspduTransform"/>
        //<xs:element ref="ReceiverPdu"/>
        //<xs:element ref="SignalPdu"/>
        //<xs:element ref="TransmitterPdu"/>
        //<xs:element ref="DISEntityManager"/>
        #endregion <xs:group name="ChildContentModelDIS">

        //TODO:
        #region <xs:group name="ChildContentModelGeoSpatial">
        //<xs:element ref="GeoLocation"/>
        //<xs:element ref="GeoLOD"/>
        //<xs:element ref="GeoMetadata"/>
        //<!-- GeoOrigin has type X3DNode, not X3DChildNode -->
        //<xs:element ref="GeoPositionInterpolator"/>
        //<xs:element ref="GeoProximitySensor"/>
        //<xs:element ref="GeoTouchSensor"/>
        //<xs:element ref="GeoViewpoint"/>
        //<xs:element ref="GeoTransform"/>
        #endregion <xs:group name="ChildContentModelGeoSpatial">

        //TODO:
        #region <xs:group name="ChildContentModelHumanoidAnimation">
        //<xs:element ref="HAnimHumanoid"/>
        //<xs:element ref="HAnimJoint"/>
        //<xs:element ref="HAnimSegment"/>
        //<xs:element ref="HAnimSite"/>
        //<xs:element ref="HAnimMotion"/>
        #endregion <xs:group name="ChildContentModelHumanoidAnimation">

        //TODO:
        #region <xs:group name="ChildContentModelNurbs">
        //[XmlElement("NurbsOrientationInterpolator", typeof(NurbsOrientationInterpolator))]
        //[XmlElement("NurbsPositionInterpolator", typeof(NurbsPositionInterpolator))]
        //[XmlElement("NurbsSurfaceInterpolator", typeof(NurbsSurfaceInterpolator))]
        //[XmlElement("NurbsSet", typeof(NurbsSet))]
        #endregion <xs:group name="ChildContentModelNurbs">

        #region <xs:group name="ChildContentModelProtoInstance">
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        #endregion <xs:group name="ChildContentModelProtoInstance">

        #region <xs:group name="ChildContentModelInterchange">
        //TODO:
        //[XmlElement("ColorInterpolator", typeof(ColorInterpolator))]
        //[XmlElement("CoordinateInterpolator", typeof(CoordinateInterpolator))]
        [XmlElement("DirectionalLight", typeof(DirectionalLight))]
        [XmlElement("Group", typeof(CADGroup))]
        //[XmlElement("NormalInterpolator", typeof(NormalInterpolator))]
        //[XmlElement("OrientationInterpolator", typeof(OrientationInterpolator))]
        //[XmlElement("PositionInterpolator", typeof(PositionInterpolator))]
        //[XmlElement("ScalarInterpolator", typeof(ScalarInterpolator))]
        //[XmlElement("TimeSensor", typeof(TimeSensor))]

        [XmlElement("WorldInfo", typeof(WorldInfo))]
        [XmlElement("NavigationInfo", typeof(NavigationInfo))]
        [XmlElement("Background", typeof(Background))]
        [XmlElement("Viewpoint", typeof(Viewpoint))]
        [XmlElement("Transform", typeof(Transform))]
        [XmlElement("Shape", typeof(Shape))]
        #endregion <xs:group name="ChildContentModelInterchange">

        #region <xs:group ref="ChildContentModelFull"/>
        //TODO:
        //[XmlElement("CoordinateInterpolator2D", typeof(CoordinateInterpolator2D))]
        //[XmlElement("PositionInterpolator2D", typeof(PositionInterpolator2D))]
        //[XmlElement("ClipPlane", typeof(ClipPlane))]
        //[XmlElement("EaseInEaseOut", typeof(EaseInEaseOut))]
        //[XmlElement("LinePickSensor", typeof(LinePickSensor))]
        //[XmlElement("PickableGroup", typeof(PickableGroup))]
        //[XmlElement("PointPickSensor", typeof(PointPickSensor))]
        //[XmlElement("PrimitivePickSensor", typeof(PrimitivePickSensor))]
        //[XmlElement("VolumePickSensor", typeof(VolumePickSensor))]
        //[XmlElement("SplinePositionInterpolator", typeof(SplinePositionInterpolator))]
        //[XmlElement("SplinePositionInterpolator2D", typeof(SplinePositionInterpolator2D))]
        //[XmlElement("SplineScalarInterpolator", typeof(SplineScalarInterpolator))]
        //[XmlElement("SquadOrientationInterpolator", typeof(SquadOrientationInterpolator))]
        //[XmlElement("StaticGroup", typeof(StaticGroup))]
        //[XmlElement("TextureProjector", typeof(TextureProjector))]
        //[XmlElement("TextureProjectorParallel", typeof(TextureProjectorParallel))]
        //[XmlElement("OrthoViewpoint", typeof(OrthoViewpoint))]
        //[XmlElement("ViewpointGroup", typeof(ViewpointGroup))]
        //[XmlElement("ColorChaser", typeof(ColorChaser))]
        //[XmlElement("ColorDamper", typeof(ColorDamper))]
        //[XmlElement("CoordinateChaser", typeof(CoordinateChaser))]
        //[XmlElement("CoordinateDamper", typeof(CoordinateDamper))]
        //[XmlElement("OrientationChaser", typeof(OrientationChaser))]
        //[XmlElement("OrientationDamper", typeof(OrientationDamper))]
        //[XmlElement("PositionChaser", typeof(PositionChaser))]
        //[XmlElement("PositionChaser2D", typeof(PositionChaser2D))]
        //[XmlElement("PositionDamper", typeof(PositionDamper))]
        //[XmlElement("PositionDamper2D", typeof(PositionDamper2D))]
        //[XmlElement("ScalarChaser", typeof(ScalarChaser))]
        //[XmlElement("ScalarDamper", typeof(ScalarDamper))]
        //[XmlElement("TexCoordChaser2D", typeof(TexCoordChaser2D))]
        //[XmlElement("TexCoordDamper2D", typeof(TexCoordDamper2D))]
        //[XmlElement("TextureBackground", typeof(TextureBackground))]
        //[XmlElement("CollidableShape", typeof(CollidableShape))]
        //[XmlElement("CollisionSensor", typeof(CollisionSensor))]
        //[XmlElement("RigidBodyCollection", typeof(RigidBodyCollection))]
        //[XmlElement("ParticleSystem", typeof(ParticleSystem))]
        //[XmlElement("TransformSensor", typeof(TransformSensor))]

        //[XmlElement("IsoSurfaceVolumeData", typeof(IsoSurfaceVolumeData))]
        //[XmlElement("SegmentedVolumeData", typeof(SegmentedVolumeData))]
        //[XmlElement("VolumeData", typeof(VolumeData))]
        //[XmlElement("Analyser", typeof(Analyser))]
        //[XmlElement("AudioDestination", typeof(AudioDestination))]
        //[XmlElement("BiquadFilter", typeof(BiquadFilter))]
        //[XmlElement("BufferAudioSource", typeof(BufferAudioSource))]
        //[XmlElement("ChannelMerger", typeof(ChannelMerger))]
        //[XmlElement("ChannelSelector", typeof(ChannelSelector))]
        //[XmlElement("ChannelSplitter", typeof(ChannelSplitter))]
        //[XmlElement("Convolver", typeof(Convolver))]
        //[XmlElement("Delay", typeof(Delay))]
        //[XmlElement("DynamicsCompressor", typeof(DynamicsCompressor))]
        //[XmlElement("Gain", typeof(Gain))]
        //[XmlElement("ListenerPointSource", typeof(ListenerPointSource))]
        //[XmlElement("MicrophoneSource", typeof(MicrophoneSource))]
        //[XmlElement("OscillatorSource", typeof(OscillatorSource))]
        //[XmlElement("SpatialSound", typeof(SpatialSound))]
        //[XmlElement("StreamAudioDestination", typeof(StreamAudioDestination))]
        //[XmlElement("StreamAudioSource", typeof(StreamAudioSource))]
        //[XmlElement("WaveShaper", typeof(WaveShaper))]

        [XmlElement("CADLayer", typeof(CADLayer))]
        [XmlElement("CADAssembly", typeof(CADAssembly))]
        [XmlElement("CADPart", typeof(CADPart))]
        #endregion <xs:group ref="ChildContentModelFull"/>

        #endregion

        #region <xs:group ref="ChildContentModelSceneGraphStructure" minOccurs="0" maxOccurs="unbounded"/>
        //TODO:
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
        #endregion XML Serialization
    }
}
