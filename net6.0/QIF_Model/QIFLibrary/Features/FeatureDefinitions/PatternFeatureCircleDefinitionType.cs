/*! \file PatternFeatureCircleDefinitionType.cs
	\brief Defines a regular arrangement of identically shaped features that can be common to one or more circle pattern features

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The PatternFeatureCircleDefinitionType defines a regular
    /// arrangement of identically shaped features that can be common to
    /// one or more circle pattern features.
    /// A circle pattern feature is a set of identically shaped features arranged in a circle. The
    /// small arcs defined by adjacent features must subtend equal angles.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PatternFeatureCircleDefinitionType : PatternFeatureDefinitionBaseType
    {
        /// <remarks> The Diameter element is the diameter of the circle. 
        /// The Diameter must equal twice the distance from the center of the circle to the first element of the pattern.</remarks>
        public LinearValueType? Diameter { get; set; }

        /// <remarks> The optional FeatureDirection element gives a direction
        /// characterizing the features in the pattern, for example,
        /// the axis of a cylinder or extrusion.The direction is
        /// relative to a coordinate system whose Z axis is the normal
        /// to the plane of the circle and whose X axis is the line
        /// from the center of the circle to the feature being located.
        /// If this element is omitted, it means that all features in
        /// the pattern have the same orientation or are not orientable.</remarks>
        public UnitVectorType? FeatureDirection { get; set; }

        /// <remarks> The NumberOfFeatures element gives the number of locations
        /// in the pattern.This must be the same as the number of
        /// features in the pattern.</remarks>
        public uint NumberOfFeatures { get; set; }
    }
}
