/*! \file IfThenFeatureRuleType.cs
    \brief defines a rule containing an optional 'if' part and an optional 'then points' part.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using QIF_Model.QIFLibrary.IntermediatesPMI;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SurfaceOfRevolutionPointSamplingStrategyEnumType
    {

        /// <remarks/>
        ORTHOGONALGRID,

        /// <remarks/>
        BIRDCAGE,

        /// <remarks/>
        SPECIFIEDGRID,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        HELIX,

        /// <remarks/>
        POINTS,
    }

    /// <remarks The IfThenFeatureRuleType defines a rule containing an optional 'if' part and an optional 'then points' part.
    /// The 'then points' part of the rule applies if the 'if' part does not exist or evaluates to true./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCurveRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSurfaceRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenTorusRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenToroidalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSurfaceOfRevolutionRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSphericalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenSphereRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPointRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPointDefinedSurfaceRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPointDefinedCurveRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenPlaneRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeParallelPlanesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeParallelLinesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeAngledPlanesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenOppositeAngledLinesRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenLineRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenExtrudedCrossSectionRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenElongatedCylinderRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenElongatedCircleRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenEllipticalArcRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenEllipseRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCylindricalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCylinderRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenConicalSegmentRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenConeRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCircularArcRuleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IfThenCircleRuleType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenFeatureRuleType : PointRuleBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplingCategoryIs", typeof(SamplingCategoryIsType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureIsDatum", typeof(FeatureIsDatumType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureIsInternal", typeof(FeatureIsInternalType))]
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicIs", typeof(CharacteristicIsType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureTypeIs", typeof(FeatureTypeIsType))]
        [System.Xml.Serialization.XmlElementAttribute("ShapeClassIs", typeof(ShapeClassIsType))]
        [System.Xml.Serialization.XmlElementAttribute("Not", typeof(NotType))]
        [System.Xml.Serialization.XmlElementAttribute("And", typeof(AndType))]
        [System.Xml.Serialization.XmlElementAttribute("Or", typeof(OrType))]
        [System.Xml.Serialization.XmlElementAttribute("BooleanEqual", typeof(BooleanEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("ConstantIs", typeof(ConstantIsType))]
        [System.Xml.Serialization.XmlElementAttribute("TokenEqual", typeof(TokenEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticEqual", typeof(ArithmeticEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("GreaterThan", typeof(GreaterThanType))]
        [System.Xml.Serialization.XmlElementAttribute("GreaterOrEqual", typeof(GreaterOrEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("LessThan", typeof(LessThanType))]
        [System.Xml.Serialization.XmlElementAttribute("LessOrEqual", typeof(LessOrEqualType))]
        public BooleanExpressionBaseType BooleanExpression { get; set; }

        /// <remarks/>
        public ThenPointsType ThenPoints { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenCurveRuleType : IfThenFeatureRuleType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenSurfaceRuleType : IfThenFeatureRuleType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenTorusRuleType : IfThenFeatureRuleType
    {

        private TorusPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public TorusPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SurfaceOfRevolutionPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenToroidalSegmentRuleType : IfThenFeatureRuleType
    {

        private ToroidalSegmentPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public ToroidalSegmentPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SurfaceOfRevolutionPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenSurfaceOfRevolutionRuleType : IfThenFeatureRuleType
    {

        private SurfaceOfRevolutionPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public SurfaceOfRevolutionPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SurfaceOfRevolutionPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenSphericalSegmentRuleType : IfThenFeatureRuleType
    {

        private SphericalSegmentPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public SphericalSegmentPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalSegmentPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SpherePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SpherePointSamplingStrategyEnumType
    {

        /// <remarks/>
        ORTHOGONALGRID,

        /// <remarks/>
        SPECIFIEDGRID,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        HELIX,

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenSphereRuleType : IfThenFeatureRuleType
    {

        private SpherePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public SpherePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SpherePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SpherePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenPointRuleType : IfThenFeatureRuleType
    {

        private PointPointSamplingStrategyType thenPointStrategyField;

        /// <remarks/>
        public PointPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(PointPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum PointPointSamplingStrategyEnumType
    {

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenPointDefinedSurfaceRuleType : IfThenFeatureRuleType
    {

        private PointDefinedSurfacePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public PointDefinedSurfacePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfacePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(PointDefinedPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum PointDefinedPointSamplingStrategyEnumType
    {

        /// <remarks/>
        GIVENPOINTS,

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenPointDefinedCurveRuleType : IfThenFeatureRuleType
    {

        private PointDefinedCurvePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public PointDefinedCurvePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurvePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(PointDefinedPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenPlaneRuleType : IfThenFeatureRuleType
    {

        private PlanePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public PlanePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlanePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(PlanePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum PlanePointSamplingStrategyEnumType
    {

        /// <remarks/>
        ORTHOGONALGRID,

        /// <remarks/>
        POLARGRID,

        /// <remarks/>
        SPECIFIEDGRID,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        SPIRAL,

        /// <remarks/>
        SPIDERWEB,

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenOppositeParallelPlanesRuleType : IfThenFeatureRuleType
    {

        private OppositeParallelPlanesPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public OppositeParallelPlanesPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelPlanesPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(PlanePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenOppositeParallelLinesRuleType : IfThenFeatureRuleType
    {

        private OppositeParallelLinesPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public OppositeParallelLinesPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeParallelLinesPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(OpenCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum OpenCurvePointSamplingStrategyEnumType
    {

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenOppositeAngledPlanesRuleType : IfThenFeatureRuleType
    {

        private OppositeAngledPlanesPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public OppositeAngledPlanesPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(PlanePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenOppositeAngledLinesRuleType : IfThenFeatureRuleType
    {

        private OppositeAngledLinesPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public OppositeAngledLinesPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(OpenCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenLineRuleType : IfThenFeatureRuleType
    {

        private LinePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public LinePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(OpenCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenExtrudedCrossSectionRuleType : IfThenFeatureRuleType
    {

        private ExtrudedCrossSectionPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public ExtrudedCrossSectionPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(ExtrudedCrossSectionPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ExtrudedCrossSectionPointSamplingStrategyEnumType
    {

        /// <remarks/>
        BIRDCAGE,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenElongatedCylinderRuleType : IfThenFeatureRuleType
    {

        private ElongatedCylinderPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public ElongatedCylinderPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCylinderPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(ElongatedCylinderPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ElongatedCylinderPointSamplingStrategyEnumType
    {

        /// <remarks/>
        ORTHOGONALGRID,

        /// <remarks/>
        BIRDCAGE,

        /// <remarks/>
        SPECIFIEDGRID,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        HELIX,

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenElongatedCircleRuleType : IfThenFeatureRuleType
    {

        private ElongatedCirclePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public ElongatedCirclePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCirclePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(OpenCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenEllipticalArcRuleType : IfThenFeatureRuleType
    {

        private EllipticalArcPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public EllipticalArcPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(OpenCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenEllipseRuleType : IfThenFeatureRuleType
    {

        private EllipsePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public EllipsePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipsePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(ClosedCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ClosedCurvePointSamplingStrategyEnumType
    {

        /// <remarks/>
        POINTS,

        /// <remarks/>
        EQUIDISTANT,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenCylindricalSegmentRuleType : IfThenFeatureRuleType
    {

        private CylindricalSegmentPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public CylindricalSegmentPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricalSegmentPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SurfaceOfRevolutionPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks The IfThenCylinderRuleType defines a conditional rule that applies
    /// if the feature under consideration is a cylinder feature.The rule
    /// contains an inherited 'if' part, an inherited ThenPoints part, and
    /// two more 'then' parts.The 'then' parts of the rule apply if the
    /// 'if' part does not exist or evaluates to true./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenCylinderRuleType : IfThenFeatureRuleType
    {
        /// <remarks The optional ThenPointStrategy element is the point
        /// sampling strategy to be used if the 'if' part of the rule
        /// does not exist or evaluates to true./>
        public CylinderPointSamplingStrategyType ThenPointStrategy { get; set; }

        /// <remarks The optional ThenFittingAlgorithm element is the substitute
        /// feature algorithm to be used if the 'if' part of the rule
        /// does not exist or evaluates to true./>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(SurfaceOfRevolutionPointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenConicalSegmentRuleType : IfThenFeatureRuleType
    {

        private ConicalSegmentPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public ConicalSegmentPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(ConePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ConePointSamplingStrategyEnumType
    {

        /// <remarks/>
        POLARGRID,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        SPIRAL,

        /// <remarks/>
        SPIDERWEB,

        /// <remarks/>
        POINTS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenConeRuleType : IfThenFeatureRuleType
    {

        private ConePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public ConePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(ConePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenCircularArcRuleType : IfThenFeatureRuleType
    {

        private CircularArcPointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public CircularArcPointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcPointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(OpenCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenCircleRuleType : IfThenFeatureRuleType
    {

        private CirclePointSamplingStrategyType thenPointStrategyField;

        private SubstituteFeatureAlgorithmType thenFittingAlgorithmField;

        /// <remarks/>
        public CirclePointSamplingStrategyType ThenPointStrategy
        {
            get
            {
                return this.thenPointStrategyField;
            }
            set
            {
                this.thenPointStrategyField = value;
            }
        }

        /// <remarks/>
        public SubstituteFeatureAlgorithmType ThenFittingAlgorithm
        {
            get
            {
                return this.thenFittingAlgorithmField;
            }
            set
            {
                this.thenFittingAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CirclePointSamplingStrategyType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PointSamplingStrategyEnum", typeof(ClosedCurvePointSamplingStrategyEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedStrategy", typeof(string), DataType = "token")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
