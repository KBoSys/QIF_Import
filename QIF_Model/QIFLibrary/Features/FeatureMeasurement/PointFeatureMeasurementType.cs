/*! \file PointFeatureMeasurementType.cs
    \brief defines the point feature measurement information for an individual point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The PointFeatureMeasurementType defines the point feature measurement information for an individual point feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureMeasurementType : PointFeatureMeasurementBaseType
    {
        /// <remarks The optional Location element is the measured location of the point./>
        public MeasuredPointType Location { get; set; }

        /// <remarks The optional Normal element is the measured unit normal vector of the point./>
        public MeasuredUnitVectorType Normal { get; set; }
    }

}
