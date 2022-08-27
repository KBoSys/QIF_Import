/*! \file EllipseFeatureNominalType.cs
    \brief Defines the ellipse feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The EllipseFeatureNominalType defines the ellipse feature nominal information for an individual ellipse feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseFeatureNominalType : CurveFeatureNominalBaseType
    {
        /// <remarks> The Axis element is the nominal center point and nominal axis vector along the long axis of the ellipse.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Normal element is the nominal unit normal vector of the plane of the ellipse.</remarks>
        public UnitVectorType Normal { get; set; }

        /// <remarks> The optional Sweep element gives the nominal start direction
        /// and the swept angle for the ellipse.The StartVector of the
        /// Sweep must lie in the plane of the ellipse.</remarks>
        public SweepType Sweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the ellipse
        /// is constructed and provides details of the construction method.</remarks>
        public EllipseConstructionMethodType Constructed { get; set; }
    }
}
