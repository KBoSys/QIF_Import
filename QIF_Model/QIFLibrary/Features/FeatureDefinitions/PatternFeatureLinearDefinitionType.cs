/*! \file PatternFeatureLinearDefinitionType.cs
	\brief Defines a regular arrangement of identically shaped features that can be common to one or more linear pattern features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The PatternFeatureLinearDefinitionType defines a regular
    /// arrangement of identically shaped features that can be common to
    /// one or more linear pattern features.
    /// A linear pattern feature is a set of identically shaped features having the same orientation
    /// arranged in a straight line.The nominal features in the pattern
    /// must lie equally spaced on the line./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PatternFeatureLinearDefinitionType : PatternFeatureDefinitionBaseType
    {
        /// <remarks The LineDirection element is the direction of the line of features in the current coordinate system./>
        public UnitVectorType LineDirection { get; set; }

        /// <remarks The IncrementalDistance is the distance between adjacent features in the pattern./>
        public LinearValueType IncrementalDistance { get; set; }

        /// <remarks The optional FeatureDirection element is a direction
        /// characterizing the features in the pattern, for example, the axis of a cylinder or the direction of an extrusion./>
        public UnitVectorType FeatureDirection { get; set; }

        /// <remarks The NumberOfFeatures element gives the number of locations
        /// in the pattern.This must be the same as the number of
        /// features in the pattern./>
        public uint NumberOfFeatures { get; set; }
    }
}
