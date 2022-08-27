/*! \file TorusFeatureNominalType.cs
    \brief Defines the torus feature nominal information for an individual torus feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The TorusFeatureNominalType defines the torus feature nominal information for an individual torus feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal center of the torus.</remarks>
        public PointType Location { get; set; }

        /// <remarks> The AxisVector element is the nominal unit axis vector of the torus.</remarks>
        public UnitVectorType AxisVector { get; set; }

        /// <remarks> The optional LatitudeLongitudeSweep element gives the
        /// extent of a partial torus with angular sweep in two
        /// directions analogous to terrestrial latitude and longitude.</remarks>
        public LatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the torus is
        /// constructed and provides details of the construction method.</remarks>
        public TorusConstructionMethodType Constructed { get; set; }
    }
}
