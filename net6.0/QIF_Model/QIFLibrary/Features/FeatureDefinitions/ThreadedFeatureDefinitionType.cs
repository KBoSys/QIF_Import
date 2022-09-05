/*! \file ThreadedFeatureDefinitionType.cs
	\brief Defines the threaded feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The ThreadedFeatureDefinitionType defines the threaded feature
    /// nominal information that can be common to one or more threaded features.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureDefinitionType : SpecifiedFeatureDefinitionBaseType
    {
        /// <remarks> The InternalExternal element indicates whether the feature is internal or external.</remarks>
        public InternalExternalEnumType InternalExternal { get; set; }

        /// <remarks> The ThreadSpecificationId element is the QIF id of the
        /// thread specification for the thread feature.This
        /// must be the QIF id of a thread specification.</remarks>
        public QIFReferenceType? ThreadSpecificationId { get; set; }

        /// <remarks> The optional Length element is the nominal length of the
        /// threaded feature from the starting point in the direction
        /// of the threaded feature axis.</remarks>
        public LinearValueType? Length { get; set; }

        /// <remarks> The optional Bottom element describes the bottom type of
        /// the threaded feature.</remarks>
        public BottomType? Bottom { get; set; }
    }
}
