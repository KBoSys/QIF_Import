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
    /// <remarks The ThreadSpecificationDetailedBaseType is the abstract base type that defines detailed thread specifications.
    /// A detailed thread specification has elements defining each aspect of the thread in contrast to a simple thread specification string./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiLeadThreadSpecificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SingleLeadThreadSpecificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ThreadSpecificationDetailedBaseType
    {
        /// <remarks The Diameter element is the basic major diameter of the thread.
        /// Note: the screw number is not used, the decimal equivalent for
        /// the screw number will be used(e.g., #10 screw number is equivalent to .190 inch)./>
        public LinearValueType Diameter { get; set; }

        /// <remarks The ThreadSeries element is the thread series (e.g., UNC, M)
        /// for the thread.A thread series is sometimes called the thread form./>
        public ThreadSeriesType ThreadSeries { get; set; }

        /// <remarks The ThreadToleranceClass element is the thread tolerance class
        /// for the pitch diameter of the thread.A thread class
        /// designation indicates the standard grade of tolerance and
        /// allowance specified for a thread -- typically a numeric class
        /// symbol and an internal and external character(e.g., 2A, 2B,
        /// 4h). For metric threads(e.g., M, MJ) the ThreadToleranceClass
        /// (e.g., 4g, 6H) indicates the combination of a tolerance grade
        /// (numeric) with a tolerance position(e.g., e, f, g, h, G, H)
        /// and specifies the allowance for the pitch diameter tolerance./>
        public ThreadClassType ThreadToleranceClass { get; set; }

        /// <remarks The optional CrestDiameterToleranceClass element is the thread
        /// tolerance class for the crest diameter of the thread.The crest
        /// diameter is the major or minor diameter dependent upon if the
        /// thread is external or internal. The diameter tolerance class
        /// designation(e.g., 6g) indicates the combination of a tolerance
        /// grade(numeric) with a tolerance position(e.g., e, f, g, h, G, H). 
        /// It specifies the allowance for the crest diameter tolerance./>
        public ThreadClassType CrestDiameterToleranceClass { get; set; }

        /// <remarks The optional LeftHanded element is a thread qualifier
        /// designator(e.g., LH per ASME B1.7 - Screw Threads Nomenclature
        /// Definitions and Letter Symbols and ASME Y14.6 - Screw Thread
        /// Representation) indicating a thread that is screwed in or on
        /// counterclockwise.If the LeftHanded element is present and set
        /// to "true", the thread is left handed.Otherwise, the thread is right handed./>
        public bool LeftHanded { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeftHandedSpecified { get; set; }

        /// <remarks The optional ModifiedThread element is a thread modifier
        /// designator.If the ModifiedThread is "true", then the thread
        /// has a modifier designate.Otherwise, there is no modifier designated./>
        public bool ModifiedThread { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedThreadSpecified { get; set; }

        /// <remarks The optional ThreadLengthEngagement element is the length of
        /// thread engagement for the thread.The length of thread
        /// engagement is the axial distance over which two mating threads,
        /// each having full form at both crest and root, are designated to
        /// engage. The length of thread engagement is designated by LE./>
        public LinearValueType ThreadLengthEngagement { get; set; }

        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The id attribute is the QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadSeriesType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherThreadSeries", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadSeriesEnum", typeof(ThreadSeriesEnumType))]
        public object Item { get; set; }
    }

    /// <remarks The ThreadSeriesEnumType enumerates values that describe a standard thread series.
    /// Thread series enumerations are designated in ASME B1.7-2006, Table 3 - Thread Series Designations and Table 4 - ISO
    /// Thread Series Designations. Note: Table 4 references ISO 228-1, ISO
    /// 7-1, ISO/R1501, ISO 2901, ISO 2902, ISO 2903, and ISO 2904./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ThreadSeriesEnumType
    {
        /// <remarks/>
        ACME,

        /// <remarks/>
        ACME_C,

        /// <remarks/>
        ACME_G,

        /// <remarks/>
        AMO,

        /// <remarks/>
        ANPT,

        /// <remarks/>
        BUTT,

        /// <remarks/>
        PUSH_BUTT,

        /// <remarks/>
        F_PTF,

        /// <remarks/>
        M,

        /// <remarks/>
        MJ,

        /// <remarks/>
        MJS,

        /// <remarks/>
        NC5_HF,

        /// <remarks/>
        NC5_CSF,

        /// <remarks/>
        NC5_ONF,

        /// <remarks/>
        NC5_IF,

        /// <remarks/>
        NC5_INF,

        /// <remarks/>
        NGO,

        /// <remarks/>
        NGS,

        /// <remarks/>
        NGT,

        /// <remarks/>
        NH,

        /// <remarks/>
        NHR,

        /// <remarks/>
        NPSC,

        /// <remarks/>
        NPSF,

        /// <remarks/>
        NPSH,

        /// <remarks/>
        NPSI,

        /// <remarks/>
        NPSL,

        /// <remarks/>
        NPSM,

        /// <remarks/>
        NPT,

        /// <remarks/>
        NPTF,

        /// <remarks/>
        PTF_SAE_SHORT,

        /// <remarks/>
        PTF_SPL_SHORT,

        /// <remarks/>
        PTF_SPL_EXTRA_SHORT,

        /// <remarks/>
        SGT,

        /// <remarks/>
        SPL_PTF,

        /// <remarks/>
        STUB_ACME,

        /// <remarks/>
        UN,

        /// <remarks/>
        UNC,

        /// <remarks/>
        UNF,

        /// <remarks/>
        UNEF,

        /// <remarks/>
        UNJ,

        /// <remarks/>
        UNJC,

        /// <remarks/>
        UNJF,

        /// <remarks/>
        UNJEF,

        /// <remarks/>
        UNR,

        /// <remarks/>
        UNRC,

        /// <remarks/>
        UNRF,

        /// <remarks/>
        UNREF,

        /// <remarks/>
        UNM,

        /// <remarks/>
        UNS,

        /// <remarks/>
        G,

        /// <remarks/>
        R,

        /// <remarks/>
        RC,

        /// <remarks/>
        RP,

        /// <remarks/>
        S,

        /// <remarks/>
        TR,

        /// <remarks/>
        UNDEFINED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadClassType
    {

        private object itemField;

        /// <remarks/>
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

    /// <remarks The ThreadClassEnumType enumerates values that describe a standard
    /// thread class or a thread tolerance class for the thread fit.Thread
    /// tolerance class enumerations are designated in ASME B1.1-2003,
    /// Section 4.1 and ISO 965-1. ISO external thread tolerance classes
    /// such as "3e" are implemented as "EXT_3E" in QIF./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ThreadClassEnumType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1A")]
        Item1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1B")]
        Item1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2A")]
        Item2A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2AG")]
        Item2AG,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        Item2B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3A")]
        Item3A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3B")]
        Item3B,

        /// <remarks/>
        EXT_3E,

        /// <remarks/>
        EXT_3F,

        /// <remarks/>
        EXT_3G,

        /// <remarks/>
        EXT_3H,

        /// <remarks/>
        EXT_4E,

        /// <remarks/>
        EXT_4F,

        /// <remarks/>
        EXT_4G,

        /// <remarks/>
        EXT_4H,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4G")]
        Item4G,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4H")]
        Item4H,

        /// <remarks/>
        EXT_5E,

        /// <remarks/>
        EXT_5F,

        /// <remarks/>
        EXT_5G,

        /// <remarks/>
        EXT_5H,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5G")]
        Item5G,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5H")]
        Item5H,

        /// <remarks/>
        EXT_6E,

        /// <remarks/>
        EXT_6F,

        /// <remarks/>
        EXT_6G,

        /// <remarks/>
        EXT_6H,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6G")]
        Item6G,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6H")]
        Item6H,

        /// <remarks/>
        EXT_7E,

        /// <remarks/>
        EXT_7F,

        /// <remarks/>
        EXT_7G,

        /// <remarks/>
        EXT_7H,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7G")]
        Item7G,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7H")]
        Item7H,

        /// <remarks/>
        EXT_8E,

        /// <remarks/>
        EXT_8F,

        /// <remarks/>
        EXT_8G,

        /// <remarks/>
        EXT_8H,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8G")]
        Item8G,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8H")]
        Item8H,

        /// <remarks/>
        EXT_9E,

        /// <remarks/>
        EXT_9F,

        /// <remarks/>
        EXT_9G,

        /// <remarks/>
        EXT_9H,

        /// <remarks/>
        INT,

        /// <remarks/>
        EXT,

        /// <remarks/>
        SE,

        /// <remarks/>
        G,

        /// <remarks/>
        UNDEFINED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MultiLeadThreadSpecificationType : ThreadSpecificationDetailedBaseType
    {
        /// <remarks/>
        public LinearValueType ThreadPitch { get; set; }

        /// <remarks/>
        public LinearValueType ThreadLeadDistance { get; set; }

        /// <remarks/>
        public uint ThreadLeadStarts { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SingleLeadThreadSpecificationType : ThreadSpecificationDetailedBaseType
    {
        /// <remarks/>
        public SpecifiedDecimalType ThreadDensity { get; set; }
    }
}
