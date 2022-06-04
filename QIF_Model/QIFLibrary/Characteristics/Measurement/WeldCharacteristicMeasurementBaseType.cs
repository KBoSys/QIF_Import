/*! \file WeldCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured welding characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The WeldCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured welding characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldCompoundCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldGrooveCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldEdgeCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSurfacingCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSeamCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldStudCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSpotCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSlotCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldPlugCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFilletCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class WeldCharacteristicMeasurementBaseType : CharacteristicMeasurementBaseType
    {
    }

    /// <remarks The WeldCompoundCharacteristicMeasurementType describes the compound
    /// weld characteristic defining one or more welds to be filled in the same welding operation sequence./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldCompoundCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The WeldCharacteristicMeasurementIds element is a list of
        /// the QIF ids of the weld characteristic measurements./>
        public ArrayReferenceType WeldCharacteristicMeasurementIds { get; set; }
    }

    /// <remarks The WeldGrooveCharacteristicMeasurementType describes the basic measured parameters of the groove weld./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks This optional compositor provides a choice between a one-sided weld and a two-sided weld./>
        [System.Xml.Serialization.XmlElementAttribute("BothSides", typeof(WeldGrooveBothSidesExtendedType))]
        [System.Xml.Serialization.XmlElementAttribute("OneSide", typeof(WeldGrooveOneSideType))]
        public object Item { get; set; }
    }

    /// <remarks The WeldScarfCharacteristicMeasurementType defines the results of a measured weld scarf characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldScarfCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The global WeldFlareBevelCharacteristicMeasurement element is a flare bevel weld characteristic measurement./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFlareBevelCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldFlareVCharacteristicMeasurementType defines the results of a measured weld flare-v characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFlareVCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldJCharacteristicMeasurementType defines the results of a measured weld j characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldJCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldUCharacteristicMeasurementType defines the results of a measured weld u characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldUCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldVCharacteristicMeasurementType defines the results of a measured weld v characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldVCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldBevelCharacteristicMeasurementType specifies the results of a measured weld bevel characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldBevelCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldSquareCharacteristicMeasurementType defines the results of a measured weld square characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSquareCharacteristicMeasurementType : WeldGrooveCharacteristicMeasurementType
    {
    }

    /// <remarks The WeldEdgeCharacteristicMeasurementType defines the results of a measured weld edge characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldEdgeCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The LocationSignificance element specifies a location significance./>
        public LocationSignificanceOneSidesEnumType LocationSignificance { get; set; }

        /// <remarks The optional SideParameters element specifies parameters of the weld characteristic./>
        public WeldOneSideParametersExtendSizeType SideParameters { get; set; }
    }

    /// <remarks The WeldSurfacingCharacteristicMeasurementType defines the results
    /// of a measured weld surfacing characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSurfacingCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The optional ArrowSideParameters element specifies parameters of the weld characteristic./>
        public WeldOneSideParametersExtendSizeType ArrowSideParameters { get; set; }
    }

    /// <remarks The LocationSignificanceSpotSeamEnumType enumerates values that
    /// describe the location significance of a spot/seam weld symbol./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LocationSignificanceSpotSeamEnumType
    {
        /// <remarks/>
        ARROW_SIDE,

        /// <remarks/>
        OTHER_SIDE,

        /// <remarks/>
        NO_SIDE,
    }

    /// <remarks The WeldSeamCharacteristicMeasurementType defines the results of a measured weld seam characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSeamCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The LocationSignificance element specifies a location significance./>
        public LocationSignificanceSpotSeamEnumType LocationSignificance { get; set; }

        /// <remarks The optional SideParameters element specifies parameters of the weld characteristic./>
        public WeldOneSideParametersExtendType SideParameters { get; set; }
    }

    /// <remarks The WeldStudCharacteristicMeasurementType defines the results
    /// of a measured weld stud characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldStudCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The optional ArrowSideParameters element specifies parameters of the weld characteristic./>
        public WeldOneSideParametersExtendType ArrowSideParameters { get; set; }
    }

    /// <remarks The WeldSpotCharacteristicMeasurementType defines the results of a measured weld spot characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSpotCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The LocationSignificance element specifies a location significance./>
        public LocationSignificanceSpotSeamEnumType LocationSignificance { get; set; }

        /// <remarks The optional SideParameters element specifies parameters of the weld characteristic./>
        public WeldSpotOneSideParametersType SideParameters { get; set; }

        /// <remarks The optional Projection element indicates whether
        /// projection welding is chosen.Projection welding is a modification of spot welding./>
        public bool Projection { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProjectionSpecified { get; set; }
    }

    /// <remarks The WeldSlotCharacteristicMeasurementType defines the results
    /// of a measured weld slot characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSlotCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The LocationSignificance element specifies a location significance./>
        public LocationSignificanceOneSidesEnumType LocationSignificance { get; set; }

        /// <remarks The optional SideParameters element specifies parameters of the weld characteristic./>
        public WeldPlugOneSideParametersType SideParameters { get; set; }
    }

    /// <remarks The WeldPlugCharacteristicMeasurementType defines the results    of a measured weld plug characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldPlugCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The LocationSignificance element specifies a location        significance./>
        public LocationSignificanceOneSidesEnumType LocationSignificance { get; set; }

        /// <remarks The optional SideParameters element specifies parameters of the weld characteristic./>
        public WeldPlugOneSideParametersType SideParameters { get; set; }
    }

    /// <remarks The WeldFilletCharacteristicMeasurementType defines the results of a measured weld fillet characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletCharacteristicMeasurementType : WeldCharacteristicMeasurementBaseType
    {
        /// <remarks The LocationSignificance element specifies a location significance./>
        public LocationSignificanceAllEnumType LocationSignificance { get; set; }

        /// <remarks This optional compositor provides a choice between a two-sided weld and a one-sided weld./>
        [System.Xml.Serialization.XmlElementAttribute("BothSides", typeof(WeldFilletBothSidesType))]
        [System.Xml.Serialization.XmlElementAttribute("OneSide", typeof(WeldFilletOneSideType))]
        public object Item { get; set; }
    }

    /// <remarks The LocationSignificanceAllEnumType enumerates values that describe location significance./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LocationSignificanceAllEnumType
    {

        /// <remarks/>
        ARROW_SIDE,

        /// <remarks/>
        OTHER_SIDE,

        /// <remarks/>
        BOTH_SIDE,
    }

    /// <remarks The WeldFilletBothSidesType defines the two-sided fillet weld./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletBothSidesType
    {
        /// <remarks The optional ArrowSide element specifies weld parameters on the arrow side of the reference line./>
        public WeldFilletOneSideInBothSidesType ArrowSide { get; set; }

        /// <remarks The optional OtherSide element specifies weld parameters on the other side of the reference line./>
        public WeldFilletOneSideInBothSidesType OtherSide { get; set; }

        /// <remarks The optional Staggered element indicates the staggered mode./>
        public bool Staggered { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StaggeredSpecified { get; set; }
    }
}
