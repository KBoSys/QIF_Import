/*! \file CylinderType.cs
    \brief Defines a cylinder to be used as a cylindrical area DatumTarget.It is not a feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The CylinderType defines a cylinder to be used as a cylindrical area DatumTarget.It is not a feature.</remarks>

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderType
    {
        /// <remarks> The CenterPoint element is the center of the cylinder at one end.</remarks>
        public PointType? CenterPoint { get; set; }

        /// <remarks> The Diameter element is the diameter of the cylinder.</remarks>
        public LinearValueType? Diameter { get; set; }

        /// <remarks> The Axis element is the unit vector that gives the axis of the
        /// cylinder pointing from the end at which the center point is defined to the other end.</remarks>
        public UnitVectorType? Axis { get; set; }

        /// <remarks> The Length element is the length of the cylinder along its axis vector.</remarks>
        public LinearValueType? Length { get; set; }
    }
}
