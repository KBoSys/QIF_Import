/*! \file GeometricCharacteristicDefinitionBaseType.cs
    \brief 
		The GeometricCharacteristicDefinitionBaseType is the abstract base
        type that defines information that can be common to more than one
        geometric characteristic. A geometric characteristic is defined by a
        "feature control frame" (ASME Y14.5) or synonymously by a "tolerance
        frame" or "tolerance indicator" (ISO specific).

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The GeometricCharacteristicDefinitionBaseType is the abstract base
    /// type that defines information that can be common to more than one geometric characteristic.
    /// A geometric characteristic is defined by a "feature control frame" (ASME Y14.5) or synonymously by a "tolerance
    /// frame" or "tolerance indicator" (ISO specific).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class GeometricCharacteristicDefinitionBaseType : CharacteristicDefinitionBaseType
    {
        /// <remarks This optional compositor provides a choice between the two
        /// ISO specific methods for modifying a substitute feature with respect to a characteristic evaluation./>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedTolerancedFeatureSpecificationElement", typeof(AssociatedTolerancedFeatureSpecificationElementEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceFeatureAssociationSpecificationElement", typeof(ReferenceFeatureAssociationSpecificationElementType))]
        public object Item { get; set; }

        /// <remarks (ISO specific leading arrow) The optional DirectionFeature
        /// element defines the direction feature modifying the characteristic./>
        public IntermediatesPMI.DirectionFeatureType DirectionFeature { get; set; }

        /// <remarks (ISO specific leading circle) The optional
        /// CollectionPlane element defines the collection plane modifying the characteristic./>
        public IntermediatesPMI.CollectionPlaneType CollectionPlane { get; set; }

        /// <remarks (ISO specific leading triangle) The optional
        /// IntersectionPlane element defines the intersection plane modifying the characteristic./>
        public IntermediatesPMI.IntersectionPlaneType IntersectionPlane { get; set; }

        /// <remarks (ISO specific leading and trailing triangles) The optional
        /// OrientationPlane element defines the orientation plane modifying the characteristic./>
        public IntermediatesPMI.OrientationPlaneType OrientationPlane { get; set; }
    }

    /// <remarks The AssociatedTolerancedFeatureSpecificationElementEnumType
    /// enumerates values that describe ISO specific circled substitute feature characteristic modifiers./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AssociatedTolerancedFeatureSpecificationElementEnumType
    {
        C, ///< minimax (Chebyshev)
        G, ///< least squares (Gaussian)
        N, ///< maximum inscribed
        T, ///< tangent plane
        X, ///< minimum circumscribed
    }

    /// <remarks The ReferenceFeatureAssociationSpecificationElementType defines the
    /// ISO specific substitute feature modifiers associated with a geometric characteristic, e.g., 'S0.25-x-150 C P'./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ReferenceFeatureAssociationSpecificationElementType
    {
        /// <remarks The optional Filter element describes the filter definition
        /// portion of the substitute feature modifiers, e.g, the 'S0.25-x-150' in 'S0.25-x-150 C P'./>
        public FilterType Filter { get; set; }

        /// <remarks The Association element describes the substitute feature association modifier, e.g, the 'C' in 'S0.25-x-150 C P'./>
        public ReferenceFeatureAssociationSpecificationElementEnumType Association { get; set; }

        /// <remarks The Parameter element describes the filter parameter modifier, e.g, the 'P' in 'S0.25-x-150 C P'./>
        public ReferenceFeatureAssociationSpecificationParameterEnumType Parameter { get; set; }
    }

    /// <remarks The FilterType defines the ISO specific filter definition associated with a geometric characteristic, e.g., 'S0.25-x-150 C P'./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FilterType
    {
        /// <remarks
        /// This compositor provides a choice between a filter definition
        /// that is followed by a single nesting index and a filter
        /// definition that can be followed by two nesting indexes./>
        [System.Xml.Serialization.XmlElementAttribute("DualNestingIndexFilter", typeof(DualNestingIndexFilterType))]
        [System.Xml.Serialization.XmlElementAttribute("SingleNestingIndexFilter", typeof(SingleNestingIndexFilterType))]
        public object Item { get; set; }
    }

    /// <remarks The DualNestingIndexFilterSymbolEnumType enumerates values that
    /// describe ISO specific filter symbols that can be followed by two nesting indexes./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DualNestingIndexFilterSymbolEnumType
    {
        CW, ///> complex wavelet
        F,  ///> Fourier
        G,  ///> Gaussian
        RG, ///> robust Gaussian
        RS, ///> robust spline
        S,  ///> spline
        SW, ///> spline wavelet
    }

    /// <remarks The SingleNestingIndexFilterType defines an ISO specific filter
    /// definition as a symbol followed by a single nesting index optionally in two directions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SingleNestingIndexFilterType
    {
        /// <remarks The Symbol element defines the filter symbol./>
        public SingleNestingIndexFilterSymbolEnumType Symbol { get; set; }

        /// <remarks
        /// The NestingIndex element describes the single nesting index
        /// value.The interpretation of this value depends on the filter symbol:
        /// OB, CB, or AB = ball radius
        /// OH, CH, or AH = segment length
        /// OD, CD, or AD = disc radius
        /// H = a value of 0 indicates the convex hull/>
        public Units.LinearValueType NestingIndex { get; set; }

        /// <remarks
        /// The optional SecondDirectionNestingIndex element
        /// describes the single nesting index value in the second direction , i.e, following the 'x' in '0.25x0.5'./>
        public Units.LinearValueType SecondDirectionNestingIndex { get; set; }
    }

    /// <remarks The SingleNestingIndexFilterSymbolEnumType enumerates values that
    /// describe ISO specific filter symbols that are followed by a single nesting index./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SingleNestingIndexFilterSymbolEnumType
    {

        AB, ///> alternating ball
        AD, ///> alternating disc
        AH, ///> alternating horizontal segment
        CB, ///> closing ball
        CD, ///> closing disc
        CH, ///> closing horizontal segment
        H,  ///> hull
        OB, ///> opening ball
        OH, ///> opening horizontal segment
        OS, ///> opening disc
    }

    /// <remarks The ReferenceFeatureAssociationSpecificationElementEnumType
    /// enumerates values that describe ISO specific non-circled substitute feature characteristic modifiers./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ReferenceFeatureAssociationSpecificationElementEnumType
    {
        C,  ///> minimax (Chebyshev)
        CE, ///> minimax (Chebyshev) external
        CI, ///> minimax (Chebyshev) internal
        G,  ///> least squares (Gaussian)
        GE, ///> least squares (Gaussian) external
        GI, ///> least squares (Gaussian) internal
        N,  ///> maximum inscribed   
        X,  ///> minimum circumscribed
    }

    /// <remarks The ReferenceFeatureAssociationSpecificationParameterEnumType
    /// enumerates values that describe ISO specific filter modifying parameters./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ReferenceFeatureAssociationSpecificationParameterEnumType
    {
        P, ///> peak
        V, ///> valley
        T, ///> peak to valley
        Q, ///> root mean
    }

    /// <remarks The DualNestingIndexFilterType defines an ISO specific filter
    /// definition as a symbol followed by one or both of two nesting indexes optionally in two directions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DualNestingIndexFilterType
    {
        /// <remarks The Symbol element defines the filter symbol./>
        public DualNestingIndexFilterSymbolEnumType Symbol { get; set; }

        /// <remarks
        /// The optional FirstNestingIndex element describes the first
        /// nesting index value.This is the value preceding the '-' in
        /// '0.25-150'. This optional element is not present when no first
        /// nesting index is present, i.e., no value precedes the '-' as in
        /// '-150'. The interpretation of this value depends on the filter
        /// symbol: G, S, SW, CW, RG, or RS = cutoff length F = wavelength />
        public Units.LinearValueType FirstNestingIndex { get; set; }

        /// <remarks
        /// The optional SecondNestingIndex element describes the second
        /// nesting index value.This is the value following the '-' in
        /// '0.25-150'. This optional element is not present when no second
        /// nesting index is present, i.e., no value follows the '-' as in
        /// '0.25-'. The interpretation of this value depends on the filter
        /// symbol: G, S, SW, CW, RG, or RS = cutoff UPR F = UPR number./>
        public Units.LinearValueType SecondNestingIndex { get; set; }

        /// <remarks
        /// The optional SecondDirectionFirstNestingIndex element
        /// describes the first nesting index value in the second
        /// direction , i.e, following the 'x' and preceding the '-',
        /// the '0.5' in '0.25-150x0.5-200'. This optional element
        /// will not be present if either there is no second
        /// direction filter defined or no value precedes the '-'
        /// in the second direction filter definition./>
        public Units.LinearValueType SecondDirectionFirstNestingIndex { get; set; }

        /// <remarks
        /// The optional SecondDirectionSecondNestingIndex element
        /// describes the second nesting index value in the second
        /// direction , i.e, following the 'x' and following the '-', the
        /// '200' in '0.25-150x0.5-200'. This optional element will not be
        /// present if either there is no second direction filter defined
        /// or no value follows the '-' in the second direction filter definition./>
        public Units.LinearValueType SecondDirectionSecondNestingIndex { get; set; }
    }
}
