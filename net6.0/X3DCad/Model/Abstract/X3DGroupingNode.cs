/*! \file X3DGroupingNode.cs
	\brief Grouping nodes can contain other nodes as children, thus making up the backbone of a scene graph.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        /// <summary>
        /// Child-node content model corresponding to X3DChildNode for Interchange profile.
        /// </summary>
        #region <xs:group name="ChildContentModelInterchange">
        [XmlElement("WorldInfo", typeof(WorldInfo))]
        [XmlElement("Viewpoint", typeof(Viewpoint))]
        [XmlElement("Background", typeof(Background))]

        [XmlElement("Transform", typeof(Transform))]
        [XmlElement("Shape", typeof(Shape))]
        [XmlElement("Group", typeof(CADGroup))]

        [XmlElement("NavigationInfo", typeof(NavigationInfo))]

        //TODO:
        //[XmlElement("ColorInterpolator", typeof(ColorInterpolator))]
        //[XmlElement("CoordinateInterpolator", typeof(CoordinateInterpolator))]
        //[XmlElement("DirectionalLight", typeof(DirectionalLight))]
        //[XmlElement("NormalInterpolator", typeof(NormalInterpolator))]
        //[XmlElement("OrientationInterpolator", typeof(OrientationInterpolator))]
        //[XmlElement("PositionInterpolator", typeof(PositionInterpolator))]
        //[XmlElement("ScalarInterpolator", typeof(ScalarInterpolator))]
        //[XmlElement("TimeSensor", typeof(TimeSensor))]
        #endregion

        #region <xs:group ref="ChildContentModelInteractive"/>
        //TODO:
        //[XmlElement("Anchor", typeof(Anchor))]
        //[XmlElement("BooleanFilter", typeof(BooleanFilter))]
        //[XmlElement("BooleanSequencer", typeof(BooleanSequencer))]
        //[XmlElement("BooleanToggle", typeof(BooleanToggle))]
        //[XmlElement("BooleanTrigger", typeof(BooleanTrigger))]
        //[XmlElement("CylinderSensor", typeof(CylinderSensor))]
        //[XmlElement("Inline", typeof(Inline))]
        //[XmlElement("IntegerSequencer", typeof(IntegerSequencer))]
        //[XmlElement("IntegerTrigger", typeof(IntegerTrigger))]
        //[XmlElement("KeySensor", typeof(KeySensor))]
        //[XmlElement("PlaneSensor", typeof(PlaneSensor))]
        //[XmlElement("PointLight", typeof(PointLight))]
        //[XmlElement("ProximitySensor", typeof(ProximitySensor))]
        //[XmlElement("SphereSensor", typeof(SphereSensor))]
        //[XmlElement("SpotLight", typeof(SpotLight))]
        //[XmlElement("StringSensor", typeof(StringSensor))]
        //[XmlElement("Switch", typeof(Switch))]
        //[XmlElement("TimeTrigger", typeof(TimeTrigger))]
        //[XmlElement("TouchSensor", typeof(TouchSensor))]
        #endregion

        #region <xs:group ref="ChildContentModelImmersive"/>
        [XmlElement("Billboard", typeof(Billboard))]

        //TODO:
        //[XmlElement("AudioClip", typeof(AudioClip))]
        //[XmlElement("Collision", typeof(Collision))]
        //[XmlElement("Fog", typeof(Fog))]
        //[XmlElement("LoadSensor", typeof(LoadSensor))]
        //[XmlElement("LocalFog", typeof(LocalFog))]
        //[XmlElement("LOD", typeof(LOD))]
        //[XmlElement("Script", typeof(Script))]
        //[XmlElement("Sound", typeof(Sound))]
        //[XmlElement("VisibilitySensor", typeof(VisibilitySensor))]
        #endregion

        #region <xs:group ref="ChildContentModelDIS"/>
        //TODO:
        //[XmlElement("EspduTransform", typeof(EspduTransform))]
        //[XmlElement("ReceiverPdu", typeof(ReceiverPdu))]
        //[XmlElement("SignalPdu", typeof(SignalPdu))]
        //[XmlElement("TransmitterPdu", typeof(TransmitterPdu))]
        //[XmlElement("DISEntityManager", typeof(DISEntityManager))]
        #endregion

        #region <xs:group ref="ChildContentModelGeoSpatial"/>
        //TODO:
        //[XmlElement("GeoLocation", typeof(GeoLocation))]
        //[XmlElement("GeoLOD", typeof(GeoLOD))]
        //[XmlElement("GeoMetadata", typeof(GeoMetadata))]
        //[XmlElement("GeoPositionInterpolator", typeof(GeoPositionInterpolator))]
        //[XmlElement("GeoProximitySensor", typeof(GeoProximitySensor))]
        //[XmlElement("GeoTouchSensor", typeof(GeoTouchSensor))]
        //[XmlElement("GeoViewpoint", typeof(GeoViewpoint))]
        //[XmlElement("GeoTransform", typeof(GeoTransform))]
        #endregion

        #region <xs:group ref="ChildContentModelHumanoidAnimation"/>
        //TODO:
        //[XmlElement("HAnimHumanoid", typeof(HAnimHumanoid))]
        //[XmlElement("HAnimJoint", typeof(HAnimJoint))]
        //[XmlElement("HAnimSegment", typeof(HAnimSegment))]
        //[XmlElement("HAnimSegment", typeof(HAnimSegment))]
        //[XmlElement("HAnimSite", typeof(HAnimSite))]
        //[XmlElement("HAnimMotion", typeof(HAnimMotion))]
        #endregion

        /// <summary>
        /// Child-node content model corresponding to X3DChildNode for Nurbs component.
        /// </summary>
        #region <xs:group ref="ChildContentModelNurbs"/>
        //TODO:
        //[XmlElement("NurbsOrientationInterpolator", typeof(NurbsOrientationInterpolator))]
        //[XmlElement("NurbsPositionInterpolator", typeof(NurbsPositionInterpolator))]
        //[XmlElement("NurbsSurfaceInterpolator", typeof(NurbsSurfaceInterpolator))]
        //[XmlElement("NurbsSet", typeof(NurbsSet))]
        #endregion

        /// <summary>
        /// Child-node content model corresponding to ProtoInstance in Immersive profile.
        /// </summary>
        #region <xs:group ref="ChildContentModelProtoInstance"/>
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        #endregion

        /// <summary>
        /// Child-node content model corresponding to X3DChildNode for Full profile.
        /// </summary>
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
        //[XmlElement("PositionDamper", typeof(PositionDamper))]
        //[XmlElement("PositionChaser2D", typeof(PositionChaser2D))]
        //[XmlElement("PositionDamper2D", typeof(PositionDamper2D))]
        //[XmlElement("ScalarChaser2D", typeof(ScalarChaser2D))]
        //[XmlElement("ScalarDamper2D", typeof(ScalarDamper2D))]
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

        [XmlElement("CADAssembly", typeof(CADAssembly))]
        [XmlElement("CADLayer", typeof(CADLayer))]
        [XmlElement("CADPart", typeof(CADPart))]
        #endregion

        #endregion
        #region <xs:group ref="ChildContentModelSceneGraphStructure" minOccurs="0" maxOccurs="unbounded"/>
        #endregion
        public List<object> Children { get; set; } = new List<object>();

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
