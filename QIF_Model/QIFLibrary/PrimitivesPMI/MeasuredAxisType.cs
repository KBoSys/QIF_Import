/*! \file MeasuredAxisType.cs
    \brief defines a measured feature axis.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The MeasuredAxisType defines a measured feature axis./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasuredZoneAxisType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredAxisType
    {
        /// <remarks The AxisPoint element is the measured location of a point on the axis./>
        public MeasuredPointType AxisPoint { get; set; }

        /// <remarks The Direction element is the measured unit vector direction of the axis./>
        public MeasuredUnitVectorType Direction { get; set; }
    }

    /// <remarks The MeasuredZoneAxisType defines a measured axis with a length./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredZoneAxisType : MeasuredAxisType
    {
        /// <remarks The Length element is the length of an axis or line. A
        /// positive value means in the direction of the associated
        /// vector and a negative value means in the opposite direction./>
        public Units.MeasuredLinearValueType Length { get; set; }
    }
}
