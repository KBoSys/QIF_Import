/*! \file ExtrudedCrossSectionFeatureNominalType.cs
    \brief Defines the extruded cross-section feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The ExtrudedCrossSectionFeatureNominalType defines the extruded
    /// cross-section feature nominal information for an individual
    /// extruded cross-section feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks> The Direction element is the unit vector representing the extrusion direction.</remarks>
        public UnitVectorType? Direction { get; set; }

        /// <remarks> The CrossSectionReferenceFeatureId element is the QIF id of
        /// the nominal feature defining the base cross section.This
        /// feature is extruded by Length from the location of the base
        /// cross-section in the extrusion direction.The value of the
        /// element must be the QIF id of a nominal feature.</remarks>
        public ArrayReferenceFullType? CrossSectionReferenceFeatureId { get; set; }

        /// <remarks> The optional Constructed element signifies that the extruded
        /// cross section feature is constructed and provides details of
        /// the construction method.</remarks>
        public ExtrudedCrossSectionConstructionMethodType Constructed { get; set; }
    }
}
