/*! \file X3DGroupingNode.cs
	\brief Grouping nodes can contain other nodes as children, thus making up the backbone of a scene graph.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //<xs:element ref="ColorInterpolator"/>
        //<xs:element ref="CoordinateInterpolator"/>
        //<xs:element ref="DirectionalLight"/>
        //<xs:element ref="NavigationInfo"/>
        //<xs:element ref="NormalInterpolator"/>
        //<xs:element ref="OrientationInterpolator"/>
        //<xs:element ref="PositionInterpolator"/>
        //<xs:element ref="ScalarInterpolator"/>
        //<xs:element ref="TimeSensor"/>
        #endregion

        #region <xs:group ref="ChildContentModelInteractive"/>
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
        #endregion

        #region <xs:group ref="ChildContentModelImmersive"/>
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
        #endregion

        #region <xs:group ref="ChildContentModelDIS"/>
        //<xs:element ref="EspduTransform"/>
        //<xs:element ref="ReceiverPdu"/>
        //<xs:element ref="SignalPdu"/>
        //<xs:element ref="TransmitterPdu"/>
        //<xs:element ref="DISEntityManager"/>
        #endregion

        #region <xs:group ref="ChildContentModelGeoSpatial"/>
        //<xs:element ref="GeoLocation"/>
        //<xs:element ref="GeoLOD"/>
        //<xs:element ref="GeoMetadata"/>
        //<!-- GeoOrigin has type X3DNode, not X3DChildNode -->
        //<xs:element ref="GeoPositionInterpolator"/>
        //<xs:element ref="GeoProximitySensor"/>
        //<xs:element ref="GeoTouchSensor"/>
        //<xs:element ref="GeoViewpoint"/>
        //<xs:element ref="GeoTransform"/>
        #endregion

        #region <xs:group ref="ChildContentModelHumanoidAnimation"/>
        //<xs:element ref="HAnimHumanoid"/>
        //<xs:element ref="HAnimJoint"/>
        //<xs:element ref="HAnimSegment"/>
        //<xs:element ref="HAnimSite"/>
        //<xs:element ref="HAnimMotion"/>
        #endregion

        /// <summary>
        /// Child-node content model corresponding to X3DChildNode for Nurbs component.
        /// </summary>
        #region <xs:group ref="ChildContentModelNurbs"/>
        //<xs:element ref="NurbsOrientationInterpolator"/>
        //<xs:element ref="NurbsPositionInterpolator"/>
        //<xs:element ref="NurbsSurfaceInterpolator"/>
        //<xs:element ref="NurbsSet"/>
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
