﻿/*! \file WeldCharacteristicNominalBaseType.cs
    \brief an abstract base type that defines a unique welding characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <summary>
    /// The WeldCharacteristicNominalBaseType is the abstract base type that defines a unique welding characteristic.
    /// </summary>
    public abstract class WeldCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional AllAround element indicates weld on all sides of the joint./>
        public bool AllAround { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllAroundSpecified { get; set; }

        /// <remarks The optional Field element indicates the weld process occurs on a job site, not in the welding shop./>
        public bool Field { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FieldSpecified { get; set; }

        /// <remarks The optional Specification contains a specification that
        /// describes a specific welding process.This note shall use
        /// the standard welding abbreviations when available such as
        /// AAW(Air Acetylene Welding), AB(Arc Brazing), AHW(Atomic
        /// Hydrogen Welding), ..., TC(Thermal Cutting). Clear
        /// non-standard notes may be also utilized./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Specification { get; set; }

        /// <remarks The optional WeldingProcess element specifies a welding process./>
        public WeldingProcessType WeldingProcess { get; set; }

        /// <remarks The optional NonDestructiveTesting element specifies a set of non-destructive tests./>
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
        /// <remarks The Process element specifies a welding process type./>
        public WeldingProcessEnumType Process { get; set; }

        /// <remarks The optional Suffix element specifies a suffix of the welding process./>
        public WeldingProcessSuffixEnumType Suffix { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SuffixSpecified { get; set; }
    }

    /// <remarks The WeldingProcessEnumType enumerates values that describe types of welding processes./>
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

    /// <remarks The WeldingProcessSuffixEnumType enumerates suffixes of the welding process./>
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

    /// <remarks The ArrayNonDestructiveTestingType is an array of non-destructive testing types./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayNonDestructiveTestingType
    {
        /// <remarks Each TypeOfTest element is a non-destructive testing type./>
        [System.Xml.Serialization.XmlElementAttribute("TypeOfTest")]
        public NonDestructiveTestingEnumType[] Items { get; set; }

        /// <remarks The required n attribute is the number of elements in this array./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count { 
            get => (uint)this.Items.Length;
			set { } 
        }
    }

    /// <remarks The NonDestructiveTestingEnumType enumerates values that describe non-destructive testing types./>
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

    /// <remarks />
    public class WeldEdgeCharacteristicNominalType : WeldCharacteristicNominalBaseType
	{
        //TODO
	}

    /// <remarks />
    public class WeldSurfacingCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldSeamCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldStudCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldSpotCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldSlotCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldPlugCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldFilletCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldCompoundCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldGrooveCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldScarfCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldFlareBevelCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldFlareVCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldJCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldUCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldVCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldBevelCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }

    /// <remarks />
    public class WeldSquareCharacteristicNominalType : WeldCharacteristicNominalBaseType
    {
        //TODO
    }
}
