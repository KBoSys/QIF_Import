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
        [XmlElement()]
        public string Name { get; set; }

        /// <remarks The optional UUID element is a persistent identifier for
        /// the shape feature nominal.If used, it should be generated using a widely accepted UUID generator./>
        [XmlElement()]
        public Primitives.QPIdType UUID { get; set; }

        /// <remarks The FeatureDefinitionId element is the QIF id of the associated feature definition./>
        [XmlElement(IsNullable = false)]
        public Primitives.QIFReferenceType FeatureDefinitionId { get; set; }

        /// <remarks The optional ParentFeatureNominalId element is the QIF id of
        /// the parent feature nominal when this feature item is derived from another feature nominal./>
        [XmlElement()]
        public Primitives.QIFReferenceType ParentFeatureNominalId { get; set; }

        /// <remarks The EntityInternalIds element is a list of the QIF ids of
        /// internally-defined CAD entities associated with this feature nominal./>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType EntityInternalIds { get; set; }

        /// <remarks The EntityExternalIds element is a list of the QIF ids of
        /// instances of EntityExternalType associated with this feature nominal./>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType EntityExternalIds { get; set; }
    }

    /// <remarks The ShapeFeatureNominalBaseType is the abstract base type for shape
    /// feature nominals.A shape feature nominal holds that portion of
    /// shape feature nominal information which cannot be shared among
    /// several features, e.g.feature location./>
    public abstract class ShapeFeatureNominalBaseType : FeatureNominalBaseType
    {
        /// <remarks The optional PointList element is a list of references to nominal target measurement points for the feature./>
        [XmlElement()]
        public PointListType PointList { get; set; }

        /// <remarks The optional SubstituteFeatureAlgorithm element is the substitute feature data fitting algorithm for the shape feature./>
        [XmlElement()]
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }
    }

    /// <remarks The CurveFeatureNominalBaseType is the abstract base type for shape feature nominals for features composed of curves./>
    public abstract class CurveFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
        /// <remarks The optional SurfaceFeatureNominalId element is the QIF id of the nominal surface feature the curve lies on./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType SurfaceFeatureNominalId { get; set; }
    }

    /// <remarks The SurfaceFeatureNominalBaseType is the abstract base type for shape feature nominals for features composed of surfaces./>
    public abstract class SurfaceFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
	}

    /// <remarks The PointFeatureNominalBaseType is the abstract base type for shape feature nominals for features that are a point./>
    public abstract class PointFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
        /// <remarks The optional SurfaceFeatureNominalId element is the QIF id of the nominal surface feature the point lies on./>
        [XmlElement]
        public Primitives.QIFReferenceFullType SurfaceFeatureNominalId { get; set; }

        /// <remarks The optional CurveFeatureNominalId element is the QIF id of the nominal curve feature the point lies on./>
        [XmlElement]
        public Primitives.QIFReferenceFullType CurveFeatureNominalId { get; set; }
    }

    /// <remarks The NonShapeFeatureNominalBaseType is the abstract base type for
    /// non-shape feature nominals.A non-shape feature nominal holds that
    /// portion of non-shape feature nominal information which cannot be
    /// shared among several features, e.g.feature location./>
    public abstract class NonShapeFeatureNominalBaseType : FeatureNominalBaseType
    {
    }

    /// <remarks The PatternFeatureNominalBaseType is the abstract base type that
    /// defines the pattern feature nominal information for an individual
    /// pattern feature.Each feature nominal in an instance of
    /// PatternFeatureNominalBaseType must reference the same feature definition./>
    public abstract class PatternFeatureNominalBaseType : GroupFeatureNominalType
    {
    }

    /// <remarks The SpecifiedFeatureNominalBaseType is the abstract base type for
    /// shape feature nominals for features that are defined indirectly by a
    /// specification rather than by a direct shape description./>
    public abstract class SpecifiedFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
    }
}
