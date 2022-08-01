/*! \file OtherSurfaceFeatureMeasurementType.cs
    \brief defines the other surface feature measurement information for an individual other surface feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The OtherSurfaceFeatureMeasurementType defines the other surface
    /// feature measurement information for an individual other surface feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherSurfaceFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks The optional PolyLine element gives a polyline representing
        /// the extent and boundary of the other surface feature./>
        public PolyLineType PolyLine { get; set; }
    }
}
