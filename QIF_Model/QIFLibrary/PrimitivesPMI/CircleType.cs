/*! \file CircleType.cs
    \brief defines a circle to be used as a circular DatumTarget or a circular zone limit

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The CircleType defines a circle to be used as a circular DatumTarget or a circular zone limit. 
    /// It is not a feature. 
    /// ASME Y14.5 - 2009 Section 3.3.3.3, Figure 3-6, Figure 3-9/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircleType
    {
        /// <remarks The CenterPoint element is the center of the circle./>
        public PointType CenterPoint { get; set; }

        /// <remarks The Diameter element is the diameter of the circle./>
        public LinearValueType Diameter { get; set; }

        /// <remarks The Normal element is the unit vector that gives the normal to the plane of the circle./>
        public UnitVectorType Normal { get; set; }
    }
}
