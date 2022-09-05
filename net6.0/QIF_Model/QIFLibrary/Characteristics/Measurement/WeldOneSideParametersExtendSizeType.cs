﻿/*! \file WeldOneSideParametersExtendSizeType.cs
    \brief defines the extended by size one-sided welding parameters.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The WeldOneSideParametersExtendSizeType defines the extended by size one-sided welding parameters.</remarks>
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
    public partial class WeldOneSideParametersExtendSizeType : WeldOneSideParametersBaseType
    {
        /// <remarks> The optional Size element specifies the size/strength of a
        /// one-sided weld.In the case of a bevel weld, this parameter
        /// should be interpreted as its depth.</remarks>
        public FractionType? Size { get; set; }
    }

    /// <remarks> The WeldSpotOneSideParametersType defines one side parameters of a spot weld.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSpotOneSideParametersType : WeldOneSideParametersExtendSizeType
    {
        /// <remarks> The optional Pitch element specifies the pitch of the weld.</remarks>
        public LinearValueType? Pitch { get; set; }

        /// <remarks> The optional WeldNumber element specifies the number of welds.</remarks>
        public uint WeldNumber { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeldNumberSpecified { get; set; }
    }

    /// <remarks> The WeldFilletOneSideInBothSidesType describes the fillet weld
    /// characteristic parameters from one side of the reference line in a two-sided weld.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletOneSideInBothSidesType : WeldOneSideParametersExtendSizeType
    {
        /// <remarks> The optional LengthOfEachWeld element specifies the length of each weld.</remarks>
        public LinearValueType? LengthOfEachWeld { get; set; }

        /// <remarks> The optional Pitch element specifies the pitch of the weld.</remarks>
        public LinearValueType? Pitch { get; set; }
    }

    /// <remarks> The WeldGrooveOneSideParametersType is a container of one sided
    /// groove weld characteristic parameters.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveOneSideParametersType : WeldOneSideParametersExtendSizeType
    {
        /// <remarks> The optional Groove element specifies a groove weld size.</remarks>
        public FractionType? Groove { get; set; }

        /// <remarks> The optional Angle element specifies a groove angle.</remarks>
        public AngularValueType? Angle { get; set; }

        /// <remarks> The optional RootOpening element specifies a root opening.</remarks>
        public FractionType? RootOpening { get; set; }

        /// <remarks> The optional Length element specifies the length of a weld.</remarks>
        public LinearValueType? Length { get; set; }

        /// <remarks> The optional Pitch element specifies the pitch of a weld.</remarks>
        public LinearValueType? Pitch { get; set; }
    }

    /// <remarks> The WeldOneSideParametersExtendType is a container of one sided weld characteristic parameters.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugOneSideParametersType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldOneSideParametersExtendType : WeldOneSideParametersExtendSizeType
    {
        /// <remarks> The optional Length element specifies the length of a weld.</remarks>
        public LinearValueType? Length { get; set; }

        /// <remarks> The optional Pitch element specifies the pitch of a weld or
        /// the distance between seam welds or the spacing of stud welds.</remarks>
        public LinearValueType? Pitch { get; set; }

        /// <remarks> The optional WeldNumber element specifies the number of welds.</remarks>
        public uint WeldNumber { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeldNumberSpecified { get; set; }
    }

    /// <remarks> The WeldPlugOneSideParametersType defines the parameters of a one-sided plug weld.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldPlugOneSideParametersType : WeldOneSideParametersExtendType
    {
        /// <remarks> The optional Angle element specifies an angle of countersink.</remarks>
        public AngularValueType? Angle { get; set; }

        /// <remarks> The optional Depth element specifies a depth of the filling.</remarks>
        public FractionType? Depth { get; set; }
    }
}
