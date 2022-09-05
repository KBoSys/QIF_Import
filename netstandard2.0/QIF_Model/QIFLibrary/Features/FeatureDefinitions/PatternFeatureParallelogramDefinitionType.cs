/*! \file PatternFeatureParallelogramDefinitionType.cs
	\brief Defines a regular arrangement of identically shaped features that can be common to one or more parallelogram pattern features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The PatternFeatureParallelogramDefinitionType defines a regular
    /// arrangement of identically shaped features that can be common to
    /// one or more parallelogram pattern features.
    /// A parallelogram pattern feature is a set of identically shaped features having the same
    /// orientation arranged in coplanar parallel rows.The nominal
    /// features in each row of the pattern must be equally spaced,
    /// and the rows must be equally spaced.The number of features in
    /// the set of features in the pattern must equal the product of the
    /// NumberOfFeaturesPerRow and the NumberOfRows. The AlongRowDirection
    /// and the BetweenRowDirection determine the plane of the pattern.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PatternFeatureParallelogramDefinitionType : PatternFeatureDefinitionBaseType
    {
        private VectorType alongRowDirectionField;
        private LinearValueType incrementalRowDistanceField;
        private VectorType betweenRowDirectionField;
        private LinearValueType rowSeparationDistanceField;
        private UnitVectorType featureDirectionField;
        private uint numberOfFeaturesPerRowField;
        private uint numberOfRowsField;

        /// <remarks></remarks>
        public VectorType AlongRowDirection
        {
            get
            {
                return this.alongRowDirectionField;
            }
            set
            {
                this.alongRowDirectionField = value;
            }
        }

        /// <remarks></remarks>
        public LinearValueType IncrementalRowDistance
        {
            get
            {
                return this.incrementalRowDistanceField;
            }
            set
            {
                this.incrementalRowDistanceField = value;
            }
        }

        /// <remarks></remarks>
        public VectorType BetweenRowDirection
        {
            get
            {
                return this.betweenRowDirectionField;
            }
            set
            {
                this.betweenRowDirectionField = value;
            }
        }

        /// <remarks></remarks>
        public LinearValueType RowSeparationDistance
        {
            get
            {
                return this.rowSeparationDistanceField;
            }
            set
            {
                this.rowSeparationDistanceField = value;
            }
        }

        /// <remarks></remarks>
        public UnitVectorType FeatureDirection
        {
            get
            {
                return this.featureDirectionField;
            }
            set
            {
                this.featureDirectionField = value;
            }
        }

        /// <remarks></remarks>
        public uint NumberOfFeaturesPerRow
        {
            get
            {
                return this.numberOfFeaturesPerRowField;
            }
            set
            {
                this.numberOfFeaturesPerRowField = value;
            }
        }

        /// <remarks></remarks>
        public uint NumberOfRows
        {
            get
            {
                return this.numberOfRowsField;
            }
            set
            {
                this.numberOfRowsField = value;
            }
        }
    }
}
