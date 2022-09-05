/*! \file CircularArcFeatureNominalType.cs
    \brief Defines feature nominal information for an individual circular arc feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The CircularArcFeatureNominalType defines feature nominal information for an individual circular arc feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal center point of the circular arc.</remarks>
        public PointType? Location { get; set; }

        /// <remarks> The Sweep element gives the nominal start direction and the swept angle for the circular arc.
        /// The StartVector of the Sweep must lie in the plane of the circular arc.</remarks>
        public SweepType? Sweep { get; set; }

        /// <remarks> The Normal element is the nominal unit normal vector of the plane of the circular arc.</remarks>
        public UnitVectorType? Normal { get; set; }

        /// <remarks> The optional Constructed element signifies that the circular
        /// arc is constructed and provides details of the construction method.</remarks>
        public CircularArcConstructionMethodType? Constructed { get; set; }
    }
}
