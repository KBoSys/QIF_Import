/*! \file X3D.cs
	\brief X3D is the root node for an Extensible 3D (X3D) Graphics model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Linq;
using System;
using System.Xml.Serialization;
using System.Xml.Schema;
using X3DCad.Model.Abstract;

namespace X3DCad.Model
{
    /// <summary>
    /// x3dVersionChoices enumeration string constants are used to identify the allowed versions for an X3D scene graph. This list is bounded, no additional values are allowed.
    /// </summary>
    public enum X3dVersionChoices
    {
        [XmlEnumAttribute("3.0")]
        VER_3_0, /*! X3D version 3.0 approved by ISO in 2004. */

        [XmlEnumAttribute("3.1")]
        VER_3_1, /*! X3D version 3.1 Amendment 1 approved by ISO in 2005.  Backwards compatibility maintained with version 3.0. */

        [XmlEnumAttribute("3.2")]
        VER_3_2, /*! X3D version 3.2 Amendment 2 approved by ISO in 2007.  Backwards compatibility maintained with versions 3.0 and 3.1. */

        [XmlEnumAttribute("3.3")]
        VER_3_3, /*! X3D version 3.3 approved by ISO in 2013 as International Standard (IS).  Backwards compatibility maintained with versions 3.0, 3.1 and 3.2. */

        [XmlEnumAttribute("4.0")]
        VER_4_0, /*! X3D version 4.0 under final development by Web3D Consortium.  Backwards compatibility maintained with versions 3.0, 3.1, 3.2 and 3.3. */
    }

    /// <summary>
    /// profileNameChoices enumeration constants are used to identify the profile for each scene-graph node, and also utilized by X3D element to identify the profile of a contained Scene.
    /// Profiles correspond primarily to subsets of allowed X3D nodes.Some nodes in Interchange profile include fields that are ignored unless Immersive or Full profile is active.
    /// This list is bounded, no additional values are allowed.
    /// </summary>
    public enum ProfileNameChoices
    {
        /// <summary>
        /// Core Profile includes no nodes and is provided as the basis for custom componentization. 
        /// Allowed X3D statements for all profiles are: connect ExternProtoDeclare EXPORT field fieldValue 
        /// IMPORT IS ProtoBody ProtoDeclare ProtoInterface ProtoInstance ROUTE X3D.
        /// Allowed X3D nodes for this profile are: MetadataBoolean MetadataDouble MetadataFloat MetadataInteger MetadataSet MetadataString.
        /// </summary>
        Core,

        /// <summary>
        /// Interchange Profile equals the minimum subset of nodes needed to display lightweight compelling content. 
        /// Allowed X3D nodes for this profile are: Appearance Background Box Color ColorInterpolator ColorRGBA 
        /// Cone Coordinate CoordinateInterpolator Cylinder DirectionalLight Group ImageTexture IndexedFaceSet IndexedLineSet 
        /// IndexedTriangleFanSet IndexedTriangleSet IndexedTriangleStripSet LineSet Material MetadataBoolean MetadataDouble 
        /// MetadataFloat MetadataInteger MetadataSet MetadataString MultiTexture MultiTextureCoordinate MultiTextureTransform
        /// NavigationInfo Normal NormalInterpolator OrientationInterpolator PixelTexture PointSet PositionInterpolator ScalarInterpolator 
        /// Shape Sphere TextureCoordinate TextureCoordinateGenerator TextureTransform TimeSensor Transform TriangleFanSet TriangleSet 
        /// TriangleStripSet Viewpoint WorldInfo.
        /// </summary>
        Interchange,

        /// <summary>
        /// CADInterchange Profile adds support for CADGeometry component nodes to Interchange Profile. 
        /// Allowed X3D nodes for this profile are: Anchor Appearance CADAssembly CADFace CADLayer CADPart Billboard Collision Color ColorRGBA Coordinate 
        /// DirectionalLight FragmentShader Group ImageTexture IndexedLineSet IndexedQuadSet IndexedTriangleFanSet IndexedTriangleSet IndexedTriangleStripSet 
        /// Inline LineProperties LineSet LOD Material MetadataBoolean MetadataDouble MetadataFloat MetadataInteger MetadataSet MetadataString MultiShader 
        /// MultiTexture MultiTextureCoordinate MultiTextureTransform NavigationInfo Normal PixelTexture PointSet QuadSet Shader ShaderAppearance Shape 
        /// TextureCoordinate TextureCoordinateGenerator TextureTransform Transform TriangleFanSet TriangleSet TriangleStripSet Viewpoint VertexShader WorldInfo.
        /// </summary>
        CADInterchange,

        /// <summary>
        /// Interactive Profile adds interaction nodes (Anchor, KeySensor) to the minimum subset of nodes needed to display lightweight compelling content. 
        /// Allowed X3D nodes for this profile are: Anchor Appearance Background BooleanFilter BooleanSequencer BooleanToggle BooleanTrigger Box Color 
        /// ColorInterpolator ColorRGBA Cone Coordinate CoordinateInterpolator Cylinder CylinderSensor DirectionalLight ElevationGrid Group ImageTexture 
        /// IndexedFaceSet IndexedLineSet IndexedTriangleFanSet IndexedTriangleSet IndexedTriangleStripSet Inline IntegerSequencer IntegerTrigger KeySensor 
        /// LineSet Material MetadataBoolean MetadataDouble MetadataFloat MetadataInteger MetadataSet MetadataString MultiTexture MultiTextureCoordinate 
        /// MultiTextureTransform NavigationInfo Normal NormalInterpolator OrientationInterpolator IndexedTriangleStripSet Inline IntegerSequencer IntegerTrigger 
        /// KeySensor LineSet Material MetadataBoolean MetadataDouble MetadataFloat MetadataInteger MetadataSet MetadataString MultiTexture MultiTextureCoordinate 
        /// MultiTextureTransform NavigationInfo Normal NormalInterpolator OrientationInterpolator PixelTexture PlaneSensor PointLight PointSet PositionInterpolator 
        /// ProximitySensor ScalarInterpolator Shape Sphere SphereSensor SpotLight StringSensor Switch TextureCoordinate TextureCoordinateGenerator TextureTransform 
        /// TimeSensor TimeTrigger TouchSensor Transform TriangleFanSet TriangleSet TriangleStripSet Viewpoint VisibilitySensor WorldInfo.
        /// </summary>
        Interactive,

        /// <summary>
        /// Immersive Profile equals all of the nodes in the VRML97 Specification, plus various X3D node additions including KeySensor, StringSensor and Scene. 
        /// Allowed X3D nodes for this profile are: Anchor Appearance AudioClip Background Billboard BooleanFilter BooleanSequencer BooleanToggle BooleanTrigger 
        /// Box Collision Color ColorInterpolator ColorRGBA Cone Coordinate CoordinateInterpolator Cylinder CylinderSensor DirectionalLight ElevationGrid Extrusion 
        /// Fog FontStyle Group ImageTexture IndexedFaceSet IndexedLineSet IndexedTriangleFan IndexedTriangleSet IndexedTriangleStripSet Inline IntegerSequencer 
        /// IntegerTrigger KeySensor LineProperties LineSet LoadSensor LOD Material MetadataBoolean MetadataDouble MetadataFloat MetadataInteger MetadataSet 
        /// MetadataString MovieTexture MultiTexture MultiTextureCoordinate MultiTextureTransform NavigationInfo Normal NormalInterpolator OrientationInterpolator 
        /// PixelTexture PlaneSensor PointLight PointSet Polyline2D Polypoint2D PositionInterpolator ProximitySensor Rectangle2D ScalarInterpolator Script Shape Sound 
        /// Sphere SphereSensor SpotLight StringSensor Switch Text TextureCoordinate TextureCoordinateGenerator TextureTransform TimeSensor TimeTrigger TouchSensor 
        /// TriangleFanSet TriangleSet TriangleSet2D TriangleStripSet Transform Viewpoint VisibilitySensor WorldInfo.
        /// </summary>
        Immersive,

        /// <summary>
        /// The MedicalInterchange profile adds support for VolumeRendering component to Interchange profile. 
        /// Allowed X3D nodes for this profile are: Anchor Arc2D ArcClose2D Appearance Background Billboard BlendedVolumeStyle BooleanFilter BooleanSequencer 
        /// BooleanToggle BooleanTrigger BoundaryEnhancementVolumeStyle Box CartoonVolumeStyle Circle2D ClipPlane Collision Color ColorInterpolator 
        /// ColorRGBA ComposedVolumeStyle CompositeTexture3D Cone Coordinate CoordinateDouble CoordinateInterpolator Cylinder DirectionalLight Disk2D 
        /// EdgeEnhancementVolumeStyle FillProperties FontStyle Group ImageTexture ImageTexture3D IndexedFaceSet IndexedLineSet IndexedTriangleFanSet 
        /// IndexedTriangleSet IndexedTriangleStripSet Inline IntegerSequencer IntegerTrigger IsoSurfaceVolumeData LineProperties LineSet LOD Material 
        /// MetadataBoolean MetadataDouble MetadataFloat MetadataInteger MetadataSet MetadataString MultiTexture MultiTextureCoordinate MultiTextureTransform 
        /// NavigationInfo Normal NormalInterpolator OctTree OpacityMapVolumeStyle OrientationInterpolator OrthoViewpoint PixelTexture PixelTexture3D PointSet 
        /// Polyline2D Polypoint2D PositionInterpolator ProjectionVolumeStyle Rectangle2D ScalarInterpolator SegmentedVolumeData ShadedVolumeStyle Shape 
        /// SilhouetteEnhancementVolumeStyle Sphere StaticGroup Switch Text TextureCoordinate TextureCoordinate3D TextureCoordinate4D TextureCoordinateGenerator 
        /// TextureMatrixTransform TextureProperties TextureTransform TextureTransform3D TimeSensor TimeTrigger ToneMappedVolumeStyle Transform TriangleFanSet 
        /// TriangleSet TriangleStripSet Viewpoint ViewpointGroup VolumeData WorldInfo.
        /// </summary>
        MedicalInterchange,

        /// <summary>
        /// MPEGInteractive Profile defines base interoperability with MPEG4 standards to a small subset of nodes needed to display lightweight compelling content. 
        /// Allowed X3D nodes for this profile are: Anchor Appearance Background Box Color ColorInterpolator ColorRGBA Cone Coordinate CoordinateInterpolator 
        /// Cylinder CylinderSensor DirectionalLight ElevationGrid Group ImageTexture IndexedFaceSet IndexedLineSet Inline LineSet Material MetadataBoolean 
        /// MetadataDouble MetadataFloat MetadataInteger MetadataSet MetadataString NavigationInfo NormalInterpolator OrientationInterpolator PixelTexture 
        /// PlaneSensor PointLight PointSet PositionInterpolator ProximitySensor ScalarInterpolator Shape Sphere SphereSensor SpotLight Switch TextureCoordinate 
        /// TextureTransform TimeSensor TouchSensor Transform Viewpoint WorldInfo.
        /// </summary>
        MPEG4Interactive,

        /// <summary>
        /// The Full Profile corresponds to all Immersive X3D nodes plus all approved/implemented extensions. All X3D nodes and statements are allowed in this profile.
        /// </summary>
        Full,
    }

    /// <summary>
    /// X3D is the root node for an Extensible 3D (X3D) Graphics model.
    /// </summary>
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
    [System.Xml.Serialization.XmlRootAttribute("X3D", IsNullable = false)]
    public class X3D : X3DStatement
    {
        [XmlElement("head", typeof(HeadType))]
        public HeadType Head { get; set; } = new HeadType();

        [XmlElement("Scene")]
        public SceneType Scene { get; set; } = new SceneType();

        /// <summary>
        /// Warning: version is required and must be specified in source document.
        /// </summary>
        [XmlAttribute("version")]
        public X3dVersionChoices Version { get; set; } = X3dVersionChoices.VER_4_0;

        /// <summary>
        /// Warning: profile is required and must be specified in source document.
        /// </summary>
        [XmlAttribute("profile")]
        public ProfileNameChoices Profile { get; set; } = ProfileNameChoices.CADInterchange;

        [XmlAttribute("noNamespaceSchemaLocation", Namespace = XmlSchema.InstanceNamespace)]
        public string noNamespaceSchemaLocation = "https://www.web3d.org/specifications/x3d-3.2.xsd";
    }
}