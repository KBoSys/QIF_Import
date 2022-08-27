/*! \file ThreadSpecificationDetailedBaseType.cs
    \brief Abstract base type that defines detailed thread specifications.

          For QIF 3.0, this sequence consists of the ASME Y14.6 general
          designation for a thread specification for a single lead and
          multi-lead thread. The base type includes nominal diameter,
          thread form/series (e.g., UNC, UNF), thread tolerance class
          (pitch diameter and crest diameter), whether the thread is
          left-handed or right-handed, modified thread, and length of
          engagement. Future QIF versions may include additional thread
          specification elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The ThreadSpecificationDetailedBaseType is the abstract base type that defines detailed thread specifications.
    /// A detailed thread specification has elements defining each aspect of the thread in contrast to a simple thread specification string.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiLeadThreadSpecificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SingleLeadThreadSpecificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ThreadSpecificationDetailedBaseType
    {
        /// <remarks> The Diameter element is the basic major diameter of the thread.
        /// Note: the screw number is not used, the decimal equivalent for
        /// the screw number will be used(e.g., #10 screw number is equivalent to .190 inch).</remarks>
        public LinearValueType Diameter { get; set; }

        /// <remarks> The ThreadSeries element is the thread series (e.g., UNC, M)
        /// for the thread.A thread series is sometimes called the thread form.</remarks>
        public ThreadSeriesType ThreadSeries { get; set; }

        /// <remarks> The ThreadToleranceClass element is the thread tolerance class
        /// for the pitch diameter of the thread.A thread class
        /// designation indicates the standard grade of tolerance and
        /// allowance specified for a thread -- typically a numeric class
        /// symbol and an internal and external character(e.g., 2A, 2B,
        /// 4h). For metric threads(e.g., M, MJ) the ThreadToleranceClass
        /// (e.g., 4g, 6H) indicates the combination of a tolerance grade
        /// (numeric) with a tolerance position(e.g., e, f, g, h, G, H)
        /// and specifies the allowance for the pitch diameter tolerance.</remarks>
        public ThreadClassType ThreadToleranceClass { get; set; }

        /// <remarks> The optional CrestDiameterToleranceClass element is the thread
        /// tolerance class for the crest diameter of the thread.The crest
        /// diameter is the major or minor diameter dependent upon if the
        /// thread is external or internal. The diameter tolerance class
        /// designation(e.g., 6g) indicates the combination of a tolerance
        /// grade(numeric) with a tolerance position(e.g., e, f, g, h, G, H). 
        /// It specifies the allowance for the crest diameter tolerance.</remarks>
        public ThreadClassType CrestDiameterToleranceClass { get; set; }

        /// <remarks> The optional LeftHanded element is a thread qualifier
        /// designator(e.g., LH per ASME B1.7 - Screw Threads Nomenclature
        /// Definitions and Letter Symbols and ASME Y14.6 - Screw Thread
        /// Representation) indicating a thread that is screwed in or on
        /// counterclockwise.If the LeftHanded element is present and set
        /// to "true", the thread is left handed.Otherwise, the thread is right handed.</remarks>
        public bool LeftHanded { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeftHandedSpecified { get; set; }

        /// <remarks> The optional ModifiedThread element is a thread modifier
        /// designator.If the ModifiedThread is "true", then the thread
        /// has a modifier designate.Otherwise, there is no modifier designated.</remarks>
        public bool ModifiedThread { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedThreadSpecified { get; set; }

        /// <remarks> The optional ThreadLengthEngagement element is the length of
        /// thread engagement for the thread.The length of thread
        /// engagement is the axial distance over which two mating threads,
        /// each having full form at both crest and root, are designated to
        /// engage. The length of thread engagement is designated by LE.</remarks>
        public LinearValueType ThreadLengthEngagement { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadSeriesType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherThreadSeries", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadSeriesEnum", typeof(ThreadSeriesEnumType))]
        public object Item { get; set; }
    }

    /// <remarks> The ThreadSeriesEnumType enumerates values that describe a standard thread series.
    /// Thread series enumerations are designated in ASME B1.7-2006, Table 3 - Thread Series Designations and Table 4 - ISO
    /// Thread Series Designations. Note: Table 4 references ISO 228-1, ISO
    /// 7-1, ISO/R1501, ISO 2901, ISO 2902, ISO 2903, and ISO 2904.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ThreadSeriesEnumType
    {
        /// <remarks></remarks>
        ACME,

        /// <remarks></remarks>
        ACME_C,

        /// <remarks></remarks>
        ACME_G,

        /// <remarks></remarks>
        AMO,

        /// <remarks></remarks>
        ANPT,

        /// <remarks></remarks>
        BUTT,

        /// <remarks></remarks>
        PUSH_BUTT,

        /// <remarks></remarks>
        F_PTF,

        /// <remarks></remarks>
        M,

        /// <remarks></remarks>
        MJ,

        /// <remarks></remarks>
        MJS,

        /// <remarks></remarks>
        NC5_HF,

        /// <remarks></remarks>
        NC5_CSF,

        /// <remarks></remarks>
        NC5_ONF,

        /// <remarks></remarks>
        NC5_IF,

        /// <remarks></remarks>
        NC5_INF,

        /// <remarks></remarks>
        NGO,

        /// <remarks></remarks>
        NGS,

        /// <remarks></remarks>
        NGT,

        /// <remarks></remarks>
        NH,

        /// <remarks></remarks>
        NHR,

        /// <remarks></remarks>
        NPSC,

        /// <remarks></remarks>
        NPSF,

        /// <remarks></remarks>
        NPSH,

        /// <remarks></remarks>
        NPSI,

        /// <remarks></remarks>
        NPSL,

        /// <remarks></remarks>
        NPSM,

        /// <remarks></remarks>
        NPT,

        /// <remarks></remarks>
        NPTF,

        /// <remarks></remarks>
        PTF_SAE_SHORT,

        /// <remarks></remarks>
        PTF_SPL_SHORT,

        /// <remarks></remarks>
        PTF_SPL_EXTRA_SHORT,

        /// <remarks></remarks>
        SGT,

        /// <remarks></remarks>
        SPL_PTF,

        /// <remarks></remarks>
        STUB_ACME,

        /// <remarks></remarks>
        UN,

        /// <remarks></remarks>
        UNC,

        /// <remarks></remarks>
        UNF,

        /// <remarks></remarks>
        UNEF,

        /// <remarks></remarks>
        UNJ,

        /// <remarks></remarks>
        UNJC,

        /// <remarks></remarks>
        UNJF,

        /// <remarks></remarks>
        UNJEF,

        /// <remarks></remarks>
        UNR,

        /// <remarks></remarks>
        UNRC,

        /// <remarks></remarks>
        UNRF,

        /// <remarks></remarks>
        UNREF,

        /// <remarks></remarks>
        UNM,

        /// <remarks></remarks>
        UNS,

        /// <remarks></remarks>
        G,

        /// <remarks></remarks>
        R,

        /// <remarks></remarks>
        RC,

        /// <remarks></remarks>
        RP,

        /// <remarks></remarks>
        S,

        /// <remarks></remarks>
        TR,

        /// <remarks></remarks>
        UNDEFINED,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadClassType
    {

        private object itemField;

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherThreadClass", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadClassEnum", typeof(ThreadClassEnumType))]
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

    /// <remarks> The ThreadClassEnumType enumerates values that describe a standard
    /// thread class or a thread tolerance class for the thread fit.Thread
    /// tolerance class enumerations are designated in ASME B1.1-2003,
    /// Section 4.1 and ISO 965-1. ISO external thread tolerance classes
    /// such as "3e" are implemented as "EXT_3E" in QIF.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ThreadClassEnumType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("1A")]
        Item1A,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("1B")]
        Item1B,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("2A")]
        Item2A,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("2AG")]
        Item2AG,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        Item2B,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("3A")]
        Item3A,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("3B")]
        Item3B,

        /// <remarks></remarks>
        EXT_3E,

        /// <remarks></remarks>
        EXT_3F,

        /// <remarks></remarks>
        EXT_3G,

        /// <remarks></remarks>
        EXT_3H,

        /// <remarks></remarks>
        EXT_4E,

        /// <remarks></remarks>
        EXT_4F,

        /// <remarks></remarks>
        EXT_4G,

        /// <remarks></remarks>
        EXT_4H,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("4G")]
        Item4G,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("4H")]
        Item4H,

        /// <remarks></remarks>
        EXT_5E,

        /// <remarks></remarks>
        EXT_5F,

        /// <remarks></remarks>
        EXT_5G,

        /// <remarks></remarks>
        EXT_5H,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("5G")]
        Item5G,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("5H")]
        Item5H,

        /// <remarks></remarks>
        EXT_6E,

        /// <remarks></remarks>
        EXT_6F,

        /// <remarks></remarks>
        EXT_6G,

        /// <remarks></remarks>
        EXT_6H,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("6G")]
        Item6G,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("6H")]
        Item6H,

        /// <remarks></remarks>
        EXT_7E,

        /// <remarks></remarks>
        EXT_7F,

        /// <remarks></remarks>
        EXT_7G,

        /// <remarks></remarks>
        EXT_7H,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("7G")]
        Item7G,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("7H")]
        Item7H,

        /// <remarks></remarks>
        EXT_8E,

        /// <remarks></remarks>
        EXT_8F,

        /// <remarks></remarks>
        EXT_8G,

        /// <remarks></remarks>
        EXT_8H,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("8G")]
        Item8G,

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("8H")]
        Item8H,

        /// <remarks></remarks>
        EXT_9E,

        /// <remarks></remarks>
        EXT_9F,

        /// <remarks></remarks>
        EXT_9G,

        /// <remarks></remarks>
        EXT_9H,

        /// <remarks></remarks>
        INT,

        /// <remarks></remarks>
        EXT,

        /// <remarks></remarks>
        SE,

        /// <remarks></remarks>
        G,

        /// <remarks></remarks>
        UNDEFINED,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MultiLeadThreadSpecificationType : ThreadSpecificationDetailedBaseType
    {
        /// <remarks></remarks>
        public LinearValueType ThreadPitch { get; set; }

        /// <remarks></remarks>
        public LinearValueType ThreadLeadDistance { get; set; }

        /// <remarks></remarks>
        public uint ThreadLeadStarts { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SingleLeadThreadSpecificationType : ThreadSpecificationDetailedBaseType
    {
        /// <remarks></remarks>
        public SpecifiedDecimalType ThreadDensity { get; set; }
    }
}
