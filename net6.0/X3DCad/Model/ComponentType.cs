/*! \file ComponentType.cs
	\brief Component element

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model
{
    /// <summary>
    /// componentNameChoices are enumeration constants used to identify the profile for each scene-graph node, 
    /// and also utilized by X3D element to identify the components required by the contained Scene. 
    /// This list is bounded, no additional values are allowed.
    /// </summary>
    public enum ComponentNameChoices
    {
        /// <summary>
        /// The Core component supplies the base functionality for the X3D run-time system, including the abstract base node type, field types, the event model, and routing.
        /// </summary>
        Core,

        /// <summary>
        /// The CADGeometry component is provided for Computer-Aided Design (CAD) nodes.
        /// </summary>
        CADGeometry,

        /// <summary>
        /// The Cube Map Environmental Texturing component describes how additional texturing effects are defined to produce environmental effects such as reflections from objects.
        /// </summary>
        CubeMapTexturing,

        /// <summary>
        /// The Distributed Interactive Simulation (DIS) component provides networked interoperability with the IEEE DIS protocol for sharing state and conducting real-time platform-level simulations across multiple host computers.
        /// </summary>
        DIS,

        /// <summary>
        /// Nodes in the Environmental effects component support the creation of realistic environmental effects such as panoramic backgrounds and fog.
        /// </summary>
        EnvironmentalEffects,

        /// <summary>
        /// The Environment Sensor nodes emit events indicating activity in the scene environment, usually based on interactions between the viewer and the world.
        /// </summary>
        EnvironmentalSensor,

        /// <summary>
        /// The Event Utility nodes provide the capability to filter, trigger, convert, or sequence numerous event-types for common interactive applications without the use of a Script node.
        /// </summary>
        EventUtilities,

        /// <summary>
        /// The Follower nodes (Chasers and Dampers) support dynamic creation of smooth parameter transitions at run time.
        /// </summary>
        Followers,

        /// <summary>
        /// The Geometry2D component defines how two-dimensional geometry is specified and what shapes are available.
        /// </summary>
        Geometry2D,

        /// <summary>
        /// The Geometry3D component describes how three-dimensional geometry is specified and defines ElevationGrid, Extrusion, IndexedFaceSet, and most
        /// primitive geometry nodes (Box, Cone, Cylinder, Sphere).
        /// </summary>
        Geometry3D,

        /// <summary>
        /// The Geospatial component defines how to associate real-world locations in an X3D scene and specifies nodes particularly tuned for geospatial applications.
        /// </summary>
        Geospatial,

        /// <summary>
        /// The Grouping component describes how nodes are organized into groups to establish a transformation hierarchy for the X3D scene graph.
        /// </summary>
        Grouping,

        /// <summary>
        /// The Humanoid Animation (HAnim) component for X3D defines node bindings and other details for implementing ISO/IEC 19774, the HAnim International Specification.
        /// Original name was H-Anim for X3D versions 3.0 through 3.3, both enumeration values HAnim and H-Anim are allowed to pass validation.
        /// </summary>
        HAnim,

        /// <summary>
        /// Legacy enumeration H-Anim for X3D versions 3.0-3.3 provides backwards compatibility with Humanoid Animation (HAnim) version 1, preferred form of enumeration value is HAnim.
        /// </summary>
        [XmlEnumAttribute("H-Anim")]
        H_Anim,

        /// <summary>
        /// Interpolator nodes provide keyframe-based animation capability.
        /// </summary>
        Interpolation,

        /// <summary>
        /// The Key Device Sensor defines how keyboard keystrokes are inserted into an X3D world.
        /// </summary>
        KeyDeviceSensor,

        /// <summary>
        /// The Layering component describes how to layer a set of subscene layers into a composite scene.
        /// </summary>
        Layering,

        /// <summary>
        /// The Layout component defines how to precisely position content in a scene in relation to the rendered results, especially for integrating 2D content with 3D content.
        /// </summary>
        Layout,

        /// <summary>
        /// The Lighting component specifies how light sources are defined and positioned, as well as how lights effect the rendered image.
        /// </summary>
        Lighting,

        /// <summary>
        /// The Navigation component specifies how a user can effectively and intuitively move through and around a 3D scene.
        /// </summary>
        Navigation,

        /// <summary>
        /// The Networking component defines node types and other features used to access file - based and streaming resources on the World Wide Web.
        /// </summary>
        Networking,

        /// <summary>
        /// The NURBS component describes Non - uniform Rational B - Spline(NURBS) geometry and interpolation nodes.
        /// </summary>
        NURBS,

        /// <summary>
        /// The Particle Systems component specifies how to model particles and their interactions through the application of basic physics principles to affect motion.
        /// </summary>
        ParticleSystems,

        /// <summary>
        /// The Picking component provides the ability to test for arbitrary object collision and provide basic capabilities to detecting object intersections and interactions.
        /// </summary>
        Picking,

        /// <summary>
        /// Pointing device sensor nodes detect pointing events from user-interface devices, defining activities such as a user selecting a piece of geometry.
        /// </summary>
        PointingDeviceSensor,

        /// <summary>
        /// TextureProjector nodes project textures onto geometry in a scene.
        /// </summary>
        TextureProjector,

        /// <summary>
        /// The Rendering component includes fundamental rendering primitives such as TriangleSet and PointSet nodes, as well as geometric properties nodes that define how coordinate indices, colors, normals and texture coordinates are specified.
        /// </summary>
        Rendering,

        /// <summary>
        /// The Rigid Body Physics component describes how to model rigid bodies and their interactions through the application of basic physics principles to effect motion.
        /// </summary>
        RigidBodyPhysics,

        /// <summary>
        /// The Scripting component describes how Script nodes are used to effect changes in X3D worlds.
        /// </summary>
        Scripting,

        /// <summary>
        /// The Programmable Shaders component describes how programmable shaders are specified and how they affect the visual appearance of geometry.
        /// </summary>
        Shaders,

        /// <summary>
        /// The Shape component defines nodes for associating geometry with their visible properties and the scene environment. 
        /// </summary>
        Shape,

        /// <summary>
        /// The Sound component defines how sound is delivered to an X3D world as well as how sounds are accessed.
        /// </summary>
        Sound,

        /// <summary>
        /// The Text component defines how text strings are rendered in an X3D scene.
        /// </summary>
        Text,

        /// <summary>
        /// The Texturing component specifies how 2D texture images are defined and then positioned on associated geometry.
        /// </summary>
        Texturing,

        /// <summary>
        /// The Texturing3D component specifies how 3D volumetric textures describe surface properties as data points in a volume of space, rather than a flat surface.
        /// </summary>
        Texturing3D,

        /// <summary>
        /// The Time component defines how time is sensed, computed and associated with events in an X3D scene.
        /// </summary>
        Time,

        /// <summary>
        /// The Volume Rendering component provides the ability to specify and render volumetric data sets.
        /// </summary>
        VolumeRendering,
    }

    /// <summary>
    /// "component" element
    /// </summary>
    public class ComponentType : X3DStatement
    {
        /// <summary>
        /// Warning: level is required and must be specified in source document.
        /// </summary>
        [XmlAttribute("level")]
        public uint Level { get; set; }

        [XmlAttribute("name")]
        public ComponentNameChoices Name { get; set; }
    }
}
