/*! \file SphereType.cs
    \brief Defines a sphere to be used as a spherical DatumTarget. It is not a feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The SphereType defines a sphere to be used as a spherical DatumTarget. It is not a feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphereType
    {
        /// <remarks> The CenterPoint element is the center of the sphere.</remarks>
        public PointType CenterPoint { get; set; }

        /// <remarks> The Diameter element is the diameter of the sphere.</remarks>
        public LinearValueType Diameter { get; set; }
    }
}
