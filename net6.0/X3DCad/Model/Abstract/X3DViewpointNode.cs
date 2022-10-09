/*! \file X3DViewpointNode.cs
	\brief 
        Node type X3DViewpointNode defines a specific location in the local coordinate system from which the user may view the scene,
        and also defines a viewpoint binding stack.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Node type X3DViewpointNode defines a specific location in the local coordinate system from which the user may view the scene,
    /// and also defines a viewpoint binding stack.
    /// </summary>
    [XmlInclude(typeof(Viewpoint))]
    public abstract class X3DViewpointNode : X3DBindableNode
    {
        private SFRotation rotationField = new SFRotation();

        public NavigationInfo? NavigationInfo { get; set; }

        [XmlAttribute("description")]
        public string? Description { get; set; }

        [XmlAttribute("jump")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Jump { get; set; } = true;

        [XmlAttribute("orientation")]
        [System.ComponentModel.DefaultValueAttribute("0 0 1 0")]
        public string? Orientation { get => rotationField.ToString(); set => rotationField.FromString(value); }

        [XmlAttribute("retainUserOffsets")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RetainUserOffsets { get; set; } = false;

        [XmlAttribute("farDistance")]
        [System.ComponentModel.DefaultValueAttribute(-1.0f)]
        public float FarDistance { get; set; } = -1.0f;

        [XmlAttribute("nearDistance")]
        [System.ComponentModel.DefaultValueAttribute(-1.0f)]
        public float NearDistance { get; set; } = -1.0f;

        /// <summary>
        /// When the viewAll field is set to TRUE or a viewpoint is bound with viewAll field TRUE, 
        /// the current view is modified to change the centerOfRotation field to match center of bounding box for entire visible scene, 
        /// and the orientation field is modified to aim at that point.Finally, position is zoomed in or out until the bounding box containing 
        /// the entire scene is fully within the current viewing window. If the current view is within a model, 
        /// any intervening geometry does not block the change in position.No collision detection or proximity sensing occurs when zooming.
        /// If needed, nearDistance and farDistance shall be adjusted to allow viewing the entire scene. 
        /// When the value of the viewAll field is changed from TRUE to FALSE, no change in the current view occurs.
        /// </summary>
        [XmlAttribute("viewAll")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ViewAll { get; set; } = false;
    }
}
