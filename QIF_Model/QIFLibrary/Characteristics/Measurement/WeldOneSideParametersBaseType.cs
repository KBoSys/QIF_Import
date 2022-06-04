﻿/*! \file WeldOneSideParametersBaseType.cs
    \brief defines the base container of one-sided welding parameters.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The WeldContourSymbolEnumType enumerates values that describe
    /// supplementary contour symbol of the weld symbol that is used
    /// to indicate how the face of the weld should be finished./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldContourSymbolEnumType
    {
        /// <remarks/>
        WELD_CONTOUR_FLAT,

        /// <remarks/>
        WELD_CONTOUR_FLAT_ANGLED,

        /// <remarks/>
        WELD_CONTOUR_CONCAVE,

        /// <remarks/>
        WELD_CONTOUR_CONCAVE_ANGLED,

        /// <remarks/>
        WELD_CONTOUR_CONVEX,

        /// <remarks/>
        WELD_CONTOUR_CONVEX_ANGLED,
    }

    /// <remarks The WeldFinishingDesignatorEnumType enumerates values that describe
    /// a finishing designator that is used to indicate the method for forming the contour of the weld./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldFinishingDesignatorEnumType
    {

        /// <remarks/>
        MACHINING,

        /// <remarks/>
        GRINDING,

        /// <remarks/>
        CHIPPING,

        /// <remarks/>
        HAMMERING,

        /// <remarks/>
        ROLLING,

        /// <remarks/>
        UNSPECIFIED,
    }


    /// <remarks The WeldFinishingType defines the finishing of a weld./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFinishingType
    {
        /// <remarks The ContourSymbol element specifies a supplementary contour
        /// symbol that is used with the weld symbols to indicate how the face of the weld should be finished./>
        public WeldContourSymbolEnumType ContourSymbol { get; set; }

        /// <remarks The optional FinishingDesignator element specifies a finishing
        /// designator that is used to indicate the method for forming the contour of the weld./>
        public WeldFinishingDesignatorEnumType FinishingDesignator { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinishingDesignatorSpecified { get; set; }
    }

    /// <remarks The WeldOneSideParametersBaseType defines the base container of one-sided welding parameters./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletOneSideType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldOneSideParametersExtendSizeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSpotOneSideParametersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletOneSideInBothSidesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldGrooveOneSideParametersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldOneSideParametersExtendType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugOneSideParametersType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldOneSideParametersBaseType
    {
        /// <remarks The optional Finishing element specifies the finishing of a weld./>
        public WeldFinishingType Finishing { get; set; }
    }

    /// <remarks The WeldFilletOneSideType defines a one-sided fillet weld./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletOneSideType : WeldOneSideParametersBaseType
    {
        /// <remarks This optional compositor provides a choice between a weld
        /// with equal leg lengths and a weld with unequal leg lengths./>
        [System.Xml.Serialization.XmlElementAttribute("EqualLegLength", typeof(WeldFilletEqualLegLengthType))]
        [System.Xml.Serialization.XmlElementAttribute("UnEqualLegLength", typeof(WeldFilletUnequalLegLengthType))]
        public object Item { get; set; }
    }

    /// <remarks The WeldFilletEqualLegLengthType specifies equal leg lengths of a fillet weld./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletEqualLegLengthType
    {
        /// <remarks The optional Size element specifies the welds size/strength./>
        public FractionType Size { get; set; }

        /// <remarks The optional LengthOfEachWeld element specifies the length of each weld./>
        public LinearValueType LengthOfEachWeld { get; set; }

        /// <remarks The optional Pitch element specifies the weld pitch./>
        public LinearValueType Pitch { get; set; }
    }

    /// <remarks The WeldFilletUnequalLegLengthType describes unequal leg lengths of a fillet weld./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletUnequalLegLengthType
    {
        /// <remarks The FirstLegLength element specifies the length of the first leg of the weld./>
        public FractionType FirstLegLength { get; set; }

        /// <remarks The SecondLegLength element specifies the length of the second leg of the weld./>
        public FractionType SecondLegLength { get; set; }
    }
}
