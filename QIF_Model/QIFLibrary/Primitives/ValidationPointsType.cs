/*! \file ValidationPointsType.cs
    \brief defines validation points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks The ValidationPointsType defines validation points./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ValidationPointsType
    {
        /// <remarks 
        /// The Points element is an array of 3D points.
        /// The PointsBinary element is a binary array of 3D points.
        /// Each element of this array is a triplet of real numbers
        /// (represented in accordance with the standard IEEE 754-2008): 
        /// the X-component, the Y-component and the Z-component./>
        [System.Xml.Serialization.XmlElementAttribute("Points", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsBinary", typeof(ArrayBinaryType))]
        public object Points { get; set; }

        /// <remarks
        /// The optional Directions element is an array of vectors defined at the points.
        /// The directions are considered as normal vectors in the case of face points, and tangent vectors in the case of edge points. 
        /// The number of the directions must be equal to the number of the points.
        /// 
        /// The optional Directions element is a binary array of vectors defined at the points.
        /// The directions are considered as normal vectors in the case of face points, and tangent
        /// vectors in the case of edge points.The number of the directions must be equal to the number of the points. 
        /// Each element of this array is a triplet of real numbers (represented in accordance with the standard IEEE 754-2008):
        /// the X-component, the Y-component and the Z-component./>
        [System.Xml.Serialization.XmlElementAttribute("Directions", typeof(ArrayUnitVectorType))]
        [System.Xml.Serialization.XmlElementAttribute("DirectionsBinary", typeof(ArrayBinaryType))]
        public object Directions { get; set; }
    }
}
