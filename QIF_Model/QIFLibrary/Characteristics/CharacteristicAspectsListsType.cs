/*! \file CharacteristicAspectsListsType.cs
    \brief 
        The CharacteristicAspectsListsType defines three lists of aspects
        of characteristics (for definitions, nominals, and items). A list
        of characteristic measurements is given elsewhere in the QIF model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The CharacteristicAspectsListsType defines three lists of aspects
    /// of characteristics(for definitions, nominals, and items). A list
    /// of characteristic measurements is given elsewhere in the QIF model.
    /// </summary>
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CharacteristicAspectsListsType
    {
        /// <remarks The FormalStandardId element is the id of the standard or
        /// specification against which the inspection characteristics are to be evaluated./>
        public Primitives.QIFReferenceType FormalStandardId { get; set; }

        /// <remarks The CharacteristicDefinitions element is a list of characteristic definitions./>
        public CharacteristicDefinitionsType CharacteristicDefinitions { get; set; }

        /// <remarks The optional DefaultCharacteristicDefinitions element is a list
        /// of default or "unless otherwise specified" characteristic definitions./>
        public CharacteristicDefinitionsType DefaultCharacteristicDefinitions { get; set; }

        /// <remarks The optional DefaultToleranceDefinitions element is a list of
        /// default or "unless otherwise specified" tolerance definitions
        /// with allow a tolerance definition to be shared among
        /// characteristic definitions of different types./>
        public ToleranceDefinitionsType DefaultToleranceDefinitions { get; set; }

        /// <remarks The CharacteristicNominals element is a list of characteristic nominals./>
        public CharacteristicNominalsType CharacteristicNominals { get; set; }

        /// <remarks The optional CharacteristicItems element is a list of  characteristic items.This is the entry point in QIF for the
        /// information contained in a bill of characteristics (BOC)./>
        public CharacteristicItemsType CharacteristicItems { get; set; }

        /// <remarks The optional CharacteristicGroups element is a list of characteristic groups./>
        public CharacteristicGroupsType CharacteristicGroups { get; set; }

        /// <remarks The optional SimultaneousRequirementGroups element is a list of simultaneous requirement groups./>
        public SimultaneousRequirementGroupsType SimultaneousRequirementGroups { get; set; }
    }
}
