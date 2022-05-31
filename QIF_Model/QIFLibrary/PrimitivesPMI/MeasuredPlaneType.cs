/*! \file MeasuredPlaneType.cs
    \brief defines a measured plane by means of the plane unit normal vector and a point on the plane.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The MeasuredPlaneType defines a measured plane by means of the plane
    /// unit normal vector and a point on the plane./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredPlaneType
    {
        /// <remarks The Point element is a measured point on the plane./>
        public MeasuredPointType Point { get; set; }

        /// <remarks The Normal element is the measured unit normal vector of the plane./>
        public MeasuredUnitVectorType Normal { get; set; }
    }

}
