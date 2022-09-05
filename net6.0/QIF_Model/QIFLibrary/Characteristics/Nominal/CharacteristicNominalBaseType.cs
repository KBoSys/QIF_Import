/*! \file CharacteristicNominalBaseType.cs
    \brief an abstract base type that defines a unique characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks> The CharacteristicNominalBaseType is the abstract base type that defines a unique characteristic nominal.</remarks>
    public abstract class CharacteristicNominalBaseType : CharacteristicBaseType
    {
        /// <remarks> The CharacteristicDefinitionId element is the QIF id of the associated characteristic definition.</remarks>
        public Primitives.QIFReferenceType? CharacteristicDefinitionId { get; set; }

        /// <remarks> The optional FeatureNominalIds element is a list of the QIF
        /// ids of the instances of FeatureNominalType to which the CharacteristicNominal applies.</remarks>
        public Primitives.ArrayReferenceFullType? FeatureNominalIds { get; set; }

        /// <remarks> The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the feature or
        /// features.This setting overrides any substitute feature
        /// algorithm defined on the feature nominal or feature item for
        /// the purpose of evaluating this characteristic.</remarks>
        public IntermediatesPMI.SubstituteFeatureAlgorithmType? SubstituteFeatureAlgorithm { get; set; }

        /// <remarks> The optional FeatureZoneIds element is a list of QIF
        /// identifiers of instances derived from FeatureZoneBaseType that define zones of the features to be measured.</remarks>
        public Primitives.ArrayReferenceFullType? FeatureZoneIds { get; set; }

        /// <remarks> The EntityInternalIds element is a list of the QIF
        /// ids of CAD entities associated with this characteristic nominal.</remarks>
        public Primitives.ArrayReferenceFullType? EntityInternalIds { get; set; }

        /// <remarks> The EntityExternalIds element is a list of the QIF
        /// ids of instances of EntityExternalType associated with this characteristic nominal.</remarks>
        public Primitives.ArrayReferenceFullType? EntityExternalIds { get; set; }

        /// <remarks> The optional Name element is the name of the characteristic nominal.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? Name { get; set; }

        /// <remarks>
        /// The optional CharacteristicDesignator element is the
        /// designator of a characteristic together with an optional
        /// level of criticality and optional UUID.The designator
        /// element of the CharacteristicDesignator will typically be
        /// at the most general level when used in this
        /// CharacteristicDefinitionBaseType.For example, an instance
        /// of CharacteristicDefinitionBaseType might have a
        /// CharacteristicDesignator element with the Designator K.
        /// Then there might be three instances of
        /// CharacteristicItemBaseType referencing the
        /// CharacteristicDefinitionBaseType instance and having
        /// CharacteristicDesignator elements using Designators K-1, K-2, and K-3.</remarks>
        public CharacteristicDesignatorType? CharacteristicDesignator { get; set; }
    }

    /// <remarks> The ThreadCharacteristicNominalType defines a unique thread characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ThreadCharacteristicNominalType : CharacteristicNominalBaseType
    {
    }


}
