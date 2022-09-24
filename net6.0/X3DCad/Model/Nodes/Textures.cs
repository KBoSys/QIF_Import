/*! \file Textures.cs
	\brief TODO

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The PixelTexture node defines a 2D image-based texture map as an explicit array of pixel values (image field) and parameters 
    /// controlling tiling repetition of the texture onto geometry.
    /// </summary>
    public class ImageTexture : X3DTexture2DNode
    {
        //<xs:attribute name = "image" type="SFImage" default="0 0 0"/>
        //<xs:attribute name = "containerField" type="containerFieldChoicesX3DTexture2DNode" default="texture"/>
    }

    /// <summary>
    /// The MovieTexture node defines a time dependent texture map (contained in a movie file) and parameters for controlling the movie and the texture mapping. 
    /// A MovieTexture node can also be used as the source of sound data for a Sound node. In this special case, the MovieTexture node is not used for rendering.
    /// </summary>
    public class MovieTexture : X3DSoundSourceNode
    {
        //<xs:attribute name = "load" type="SFBool" default="true"/>
        //<xs:attribute name = "loop" type="SFBool" default="false"/>
        //<xs:attribute name = "pitch" type="SFFloat" default="1.0">
        //<xs:attribute name = "autoRefresh" type="SFTime" default="0">
        //<xs:attribute name = "autoRefreshTimeLimit" type="SFTime" default="3600">
        //<xs:attribute name = "url" type="MFString">
        //<xs:attribute name = "repeatS" type="SFBool" default="true"/>
        //<xs:attribute name = "repeatT" type="SFBool" default="true"/>
        //<xs:attribute name = "speed" type="SFFloat" default="1.0"/>
        //<xs:attribute name = "containerField" type="containerFieldChoicesX3dUrlObjectTexture" default="texture"/>
    }

    /// <summary>
    /// The PixelTexture node defines a 2D image-based texture map as an explicit array of pixel values (image field) and parameters controlling tiling repetition of the texture onto geometry.
    /// </summary>
    public class PixelTexture : X3DTexture2DNode
    {
        //<xs:attribute name = "image" type="SFImage" default="0 0 0"/>
        //<xs:attribute name = "containerField" type="containerFieldChoicesX3DTexture2DNode" default="texture"/>
    }
}
