/*! \file EllipticalArcFeatureNominalType.cs
    \brief Defines the elliptical arc feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The EllipticalArcFeatureNominalType defines the elliptical arc
    /// feature nominal information for an individual elliptical arc feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The Axis element is the nominal center point and nominal
        /// axis vector along the long axis of the elliptical arc.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Normal element is the nominal unit normal vector of the
        /// plane of the elliptical arc.</remarks>
        public UnitVectorType Normal { get; set; }

        /// <remarks> The Sweep element gives the nominal start direction and the
        /// swept angle for the elliptical arc.The StartVector of the
        /// Sweep must lie in the plane of the elliptical arc.</remarks>
        public SweepType Sweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the
        /// elliptical arc is constructed and provides details of the construction method.</remarks>
        public EllipticalArcConstructionMethodType Constructed { get; set; }
    }
}
