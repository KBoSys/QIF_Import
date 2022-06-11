/*! \file PlaneType.cs
	\brief defines a plane by means of the plane unit normal vector and a point on the plane.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks The PlaneType defines a plane by means of the plane unit normal vector and a point on the plane./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneXType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneType
    {
        /// <remarks The Point element is a point on the plane./>
        public PointType Point { get; set; }

        /// <remarks The Normal element is the unit normal vector of the plane./>
        public UnitVectorType Normal { get; set; }
    }

    /// <remarks The PlaneXType defines a plane with a given x-direction./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneXType : PlaneType
    {
        /// <remarks The Direction element gives the direction of the positive X axis./>
        public UnitVectorType Direction { get; set; }
    }
}
