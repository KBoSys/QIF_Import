/*! \file PartFamilyType.cs
	\brief provides information useful for grouping parts that have similar process flows and requirements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks The PartFamilyType provides information useful for grouping parts that have similar process flows and requirements.
    /// A part's PartFamilyType can be described by it's primary
    /// shape classification, primary manufacturing method, precision
    /// needs, and/or size ranges./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PartFamilyType
    {
        /// <remarks The optional PrimaryShapeClass element provides the primary shape classification of a part./>
        public ShapeClassType PrimaryShapeClass { get; set; }

        /// <remarks The optional MinimumTolerance element identifies the
        /// smallest linear tolerance that a part possesses that will need to be verified./>
        public LinearValueType MinimumTolerance { get; set; }

        /// <remarks The optional MinimumBoundingBox element provides the smallest bounding box into which the part will fit./>
        public BoundingBoxType MinimumBoundingBox { get; set; }

        /// <remarks The optional PrimaryManufacturingMethod element identifies
        /// the manufacturing method most likely used to produce the primary shape of a part./>
        public ManufacturingMethodType PrimaryManufacturingMethod { get; set; }
    }
}
