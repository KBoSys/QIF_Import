/*! \file CameraType.cs
	\brief defines a camera.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The CameraType defines a camera. The camera describes projection of the 3D model space to a 2D window./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CameraType : NodeWithIdBaseType
    {
        /// <remarks The ViewPlaneOrigin element is the view plane origin./>
        public PointSimpleType ViewPlaneOrigin { get; set; }

        /// <remarks The Orientation element is the rotation of the view plane around the view plane origin./>
        public QuaternionType Orientation { get; set; }

        /// <remarks The Ratio element is the aspect ratio of the view plane (normally it corresponds to the viewport)./>
        public double Ratio { get; set; }

        /// <remarks The Near element is the distance from the view plane to the near clipping plane./>
        public LinearValueType Near { get; set; }

        /// <remarks The Far element is the distance from the view plane to the far clipping plane./>
        public LinearValueType Far { get; set; }

        /// <remarks The Height element is half of the top to bottom extent of the near clipping plane./>
        public double Height { get; set; }

        /// <remarks The optional form attribute specifies the camera type which
        /// can take one of the following values: 'ORTHOGRAPHIC' or 'PERSPECTIVE'./>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        [System.ComponentModel.DefaultValueAttribute(CameraFormEnumType.ORTHOGRAPHIC)]
        public CameraFormEnumType Form { get; set; } = CameraFormEnumType.ORTHOGRAPHIC;
    }

    /// <remarks The CameraFormEnumType enumerates values that describe the camera form/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CameraFormEnumType
    {
        /// <remarks an orthographic camera/>
        ORTHOGRAPHIC,

        /// <remarks a perspective camera/>
        PERSPECTIVE,
    }

    /// <remarks The CameraSetType defines a collection of cameras./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CameraSetType
    {
        /// <remarks Each Camera element defines a camera./>
        [System.Xml.Serialization.XmlElementAttribute("Camera")]
        public CameraType[] Items { get; set; }

        /// <remarks The required n attribute is the number of cameras in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)Items.Length;
            set { }
        }
    }
}
