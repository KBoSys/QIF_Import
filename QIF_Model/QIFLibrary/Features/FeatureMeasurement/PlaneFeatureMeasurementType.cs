/*! \file PlaneFeatureMeasurementType.cs
    \brief defines the plane feature measurement information for an individual plane feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The PlaneFeatureMeasurementType defines the plane feature
    /// measurement information for an individual plane feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Location element is the measured XYZ location of a point on the plane.</remarks>
        public MeasuredPointType Location { get; set; }

        /// <remarks> The optional Normal element is the measured unit normal vector of the plane.</remarks>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks> The optional PolyLine element gives a polyline representing the extent and boundary of the plane.</remarks>
        public PolyLineType PolyLine { get; set; }

        /// <remarks> The optional Form element is the form error (flatness) of the plane from a report or an analysis.</remarks>
        public MeasuredLinearValueType Form { get; set; }
    }
}
