/*! \file FeatureNominalBaseType.cs
    \brief The FeatureNominalBaseType is the abstract base type for feature nominals.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks The FeatureNominalBaseType is the abstract base type for feature
    /// nominals.A feature nominal holds that portion of feature nominal
    /// information which cannot be shared among several features, e.g. feature location./>
    public abstract class FeatureNominalBaseType : FeatureBaseType
    {
        /// <remarks The optional Name element is the name of the feature nominal./>
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }

        /// <remarks The optional UUID element is a persistent identifier for
        /// the shape feature nominal.If used, it should be generated using a widely accepted UUID generator./>
        [XmlElement(IsNullable = true)]
        public Primitives.QPIdType UUID { get; set; }

        /// <remarks The FeatureDefinitionId element is the QIF id of the associated feature definition./>
        [XmlElement(IsNullable = false)]
        public Primitives.QIFReferenceType FeatureDefinitionId { get; set; }

        /// <remarks The optional ParentFeatureNominalId element is the QIF id of
        /// the parent feature nominal when this feature item is derived from another feature nominal./>
        [XmlElement(IsNullable = true)]
        public Primitives.QIFReferenceType ParentFeatureNominalId { get; set; }

        /// <remarks The EntityInternalIds element is a list of the QIF ids of
        /// internally-defined CAD entities associated with this feature nominal./>
        [XmlElement(IsNullable = true)]
        public Primitives.ArrayReferenceFullType EntityInternalIds { get; set; }

        /// <remarks The EntityExternalIds element is a list of the QIF ids of
        /// instances of EntityExternalType associated with this feature nominal./>
        [XmlElement(IsNullable = true)]
        public Primitives.ArrayReferenceFullType EntityExternalIds { get; set; }
    }
}
