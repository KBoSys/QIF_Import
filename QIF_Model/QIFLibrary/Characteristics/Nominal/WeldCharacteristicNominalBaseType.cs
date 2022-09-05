/*! \file WeldCharacteristicNominalBaseType.cs
    \brief an abstract base type that defines a unique welding characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Characteristics.Measurement;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <summary>
    /// The WeldCharacteristicNominalBaseType is the abstract base type that defines a unique welding characteristic.
    /// </summary>
    public abstract class WeldCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks> The optional AllAround element indicates weld on all sides of the joint.</remarks>
        public bool AllAround { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllAroundSpecified { get; set; }

        /// <remarks> The optional Field element indicates the weld process occurs on a job site, not in the welding shop.</remarks>
        public bool Field { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FieldSpecified { get; set; }

        /// <remarks> The optional Specification contains a specification that
        /// describes a specific welding process.This note shall use
        /// the standard welding abbreviations when available such as
        /// AAW(Air Acetylene Welding), AB(Arc Brazing), AHW(Atomic
        /// Hydrogen Welding), ..., TC(Thermal Cutting). Clear
        /// non-standard notes may be also utilized.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Specification { get; set; }

        /// <remarks> The optional WeldingProcess element specifies a welding process.</remarks>
        public WeldingProcessType WeldingProcess { get; set; }

        /// <remarks> The optional NonDestructiveTesting element specifies a set of non-destructive tests.</remarks>
        public ArrayNonDestructiveTestingType NonDestructiveTesting { get; set; }
    }

    /// <summary>
    /// The WeldingProcessType defines a welding process.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class WeldingProcessType
    {
        /// <remarks> The Process element specifies a welding process type.</remarks>
        public WeldingProcessEnumType Process { get; set; }

        /// <remarks> The optional Suffix element specifies a suffix of the welding process.</remarks>
        public WeldingProcessSuffixEnumType Suffix { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuffixSpecified { get; set; }
    }

    /// <remarks> The WeldingProcessEnumType enumerates values that describe types of welding processes.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldingProcessEnumType
    {
        ARC_WELDING,
        SHIELDED_METAL_ARC_WELDING,
        FLUX_CORED_ARC_WELDING,
        SUBMERGED_ARC_WELDING,
        GAS_METAL_ARC_WELDING,
        GAS_TUNGSTEN_ARC_WELDING,
        PLASMA_ARC_WELDING,
        RESISTANCE_WELDING,
        RESISTANCE_SPOT_WELDING,
        RESISTANCE_SEAM_WELDING,
        PROJECTION_WELD,
        FLASH_WELDING,
        OXYFUEL_GAS_WELDING,
        OXYACETYLENE_WELDING,
        FRICTION_WELDING,
        FORGE_WELDING,
        THERMIT_WELDING,
        ELECTROSLAG_WELDING,
        STUD_ARC_WELDING,
        BRAZING,
        SOLDERING,
    }

    /// <remarks> The WeldingProcessSuffixEnumType enumerates suffixes of the welding process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum WeldingProcessSuffixEnumType
    {
        MANUAL,
        SEMI_AUTOMATIC,
        ROBOTIC,
        MACHINE,
    }

    /// <remarks> The ArrayNonDestructiveTestingType is an array of non-destructive testing types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayNonDestructiveTestingType : ArrayBaseType<NonDestructiveTestingEnumType>
    {
        /// <remarks> Each TypeOfTest element is a non-destructive testing type.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("TypeOfTest")]
        public NonDestructiveTestingEnumType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The NonDestructiveTestingEnumType enumerates values that describe non-destructive testing types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum NonDestructiveTestingEnumType
    {
        ACOUSTIC_EMISSION,
        ELECTROMAGNETIC,
        LEAK,
        MAGNETIC_PARTICLE,
        NEUTRON_RADIOGRAPHIC,
        PENETRANT,
        PROOF,
        RADIOGRAPHIC,
        ULTRASONIC,
        VISUAL,
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldEdgeCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private LocationSignificanceOneSidesEnumType locationSignificanceField;
        private WeldOneSideParametersExtendSizeType sideParametersField;

        /// <remarks></remarks>
        public LocationSignificanceOneSidesEnumType LocationSignificance
        {
            get
            {
                return this.locationSignificanceField;
            }
            set
            {
                this.locationSignificanceField = value;
            }
        }

        /// <remarks></remarks>
        public WeldOneSideParametersExtendSizeType SideParameters
        {
            get
            {
                return this.sideParametersField;
            }
            set
            {
                this.sideParametersField = value;
            }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSurfacingCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private WeldOneSideParametersExtendSizeType arrowSideParametersField;

        /// <remarks></remarks>
        public WeldOneSideParametersExtendSizeType ArrowSideParameters
        {
            get
            {
                return this.arrowSideParametersField;
            }
            set
            {
                this.arrowSideParametersField = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSeamCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private LocationSignificanceSpotSeamEnumType locationSignificanceField;
        private WeldOneSideParametersExtendType sideParametersField;

        /// <remarks></remarks>
        public LocationSignificanceSpotSeamEnumType LocationSignificance
        {
            get
            {
                return this.locationSignificanceField;
            }
            set
            {
                this.locationSignificanceField = value;
            }
        }

        /// <remarks></remarks>
        public WeldOneSideParametersExtendType SideParameters
        {
            get
            {
                return this.sideParametersField;
            }
            set
            {
                this.sideParametersField = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldStudCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private WeldOneSideParametersExtendType arrowSideParametersField;

        /// <remarks></remarks>
        public WeldOneSideParametersExtendType ArrowSideParameters
        {
            get
            {
                return this.arrowSideParametersField;
            }
            set
            {
                this.arrowSideParametersField = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSpotCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private LocationSignificanceSpotSeamEnumType locationSignificanceField;
        private WeldSpotOneSideParametersType sideParametersField;
        private bool projectionField;
        private bool projectionFieldSpecified;

        /// <remarks></remarks>
        public LocationSignificanceSpotSeamEnumType LocationSignificance
        {
            get
            {
                return this.locationSignificanceField;
            }
            set
            {
                this.locationSignificanceField = value;
            }
        }

        /// <remarks></remarks>
        public WeldSpotOneSideParametersType SideParameters
        {
            get
            {
                return this.sideParametersField;
            }
            set
            {
                this.sideParametersField = value;
            }
        }

        /// <remarks></remarks>
        public bool Projection
        {
            get
            {
                return this.projectionField;
            }
            set
            {
                this.projectionField = value;
            }
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProjectionSpecified
        {
            get
            {
                return this.projectionFieldSpecified;
            }
            set
            {
                this.projectionFieldSpecified = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldSlotCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private LocationSignificanceOneSidesEnumType locationSignificanceField;
        private WeldPlugOneSideParametersType sideParametersField;

        /// <remarks></remarks>
        public LocationSignificanceOneSidesEnumType LocationSignificance
        {
            get
            {
                return this.locationSignificanceField;
            }
            set
            {
                this.locationSignificanceField = value;
            }
        }

        /// <remarks></remarks>
        public WeldPlugOneSideParametersType SideParameters
        {
            get
            {
                return this.sideParametersField;
            }
            set
            {
                this.sideParametersField = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldPlugCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private LocationSignificanceOneSidesEnumType locationSignificanceField;
        private WeldPlugOneSideParametersType sideParametersField;

        /// <remarks></remarks>
        public LocationSignificanceOneSidesEnumType LocationSignificance
        {
            get
            {
                return this.locationSignificanceField;
            }
            set
            {
                this.locationSignificanceField = value;
            }
        }

        /// <remarks></remarks>
        public WeldPlugOneSideParametersType SideParameters
        {
            get
            {
                return this.sideParametersField;
            }
            set
            {
                this.sideParametersField = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldFilletCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private LocationSignificanceAllEnumType locationSignificanceField;
        private object itemField;

        /// <remarks></remarks>
        public LocationSignificanceAllEnumType LocationSignificance
        {
            get
            {
                return this.locationSignificanceField;
            }
            set
            {
                this.locationSignificanceField = value;
            }
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BothSides", typeof(WeldFilletBothSidesType))]
        [System.Xml.Serialization.XmlElementAttribute("OneSide", typeof(WeldFilletOneSideType))]
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

    /// <remarks> </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldCompoundCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private ArrayReferenceFullType weldCharacteristicNominalIdsField;

        /// <remarks></remarks>
        public ArrayReferenceFullType WeldCharacteristicNominalIds
        {
            get
            {
                return this.weldCharacteristicNominalIdsField;
            }
            set
            {
                this.weldCharacteristicNominalIdsField = value;
            }
        }
    }

    /// <remarks> </remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldScarfCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareBevelCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldFlareVCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldJCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldUCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldVCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldBevelCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeldSquareCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WeldGrooveCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        private object itemField;

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BothSides", typeof(WeldGrooveBothSidesExtendedType))]
        [System.Xml.Serialization.XmlElementAttribute("OneSide", typeof(WeldGrooveOneSideType))]
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

    /// <remarks> </remarks>
    public class WeldScarfCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldFlareBevelCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldFlareVCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldJCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldUCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldVCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldBevelCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }

    /// <remarks> </remarks>
    public class WeldSquareCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
    }
}
