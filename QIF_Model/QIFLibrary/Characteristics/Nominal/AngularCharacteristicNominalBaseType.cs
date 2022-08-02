/*! \file AngularCharacteristicNominalBaseType.cs
    \brief an abstract base type that defines a unique angular characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <summary>
    /// The AngularCharacteristicNominalBaseType is the abstract base type that defines a unique angular characteristic nominal.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleBetweenCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleFromCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleCharacteristicNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAngularCharacteristicNominalType))]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class AngularCharacteristicNominalBaseType : DimensionalCharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the angle./>
        public Units.AngularValueType TargetValue { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AngleBetweenAnalysisModeEnumType
    {
        /// <remarks/>
        TWODIMENSIONAL,

        /// <remarks/>
        THREEDIMENSIONAL,
    }

    /// <remarks The AngleBetweenCharacteristicNominalType defines a unique angle-between characteristic nominal./>
    public class AngleBetweenCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {
        /// <remarks The FeatureNominalPairs element is a list of pairs of QIF
        /// ids of feature nominals.This element replaces the
        /// FeatureNominalIds element of CharacteristicNominalBaseType.
        /// The FeatureNominalIds element is not populated for angle between characteristics./>
        public ArrayPairReferenceFullType FeatureNominalPairs { get; set; }

        /// <remarks The optional AnalysisVector element used by the
        /// ysisMode gives a vector defining a unit vector normal
        /// to the plane in which the angle-between characteristic is evaluated./>
        public UnitVectorType AnalysisVector { get; set; }

        /// <remarks The AnalysisMode element indicates whether the
        /// angle-between characteristic is two dimensional or three dimensional./>
        public AngleBetweenAnalysisModeEnumType AnalysisMode { get; set; }

        /// <remarks The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated./>
        public QIFReferenceFullType CoordinateSystemId { get; set; }

        /// <remarks The optional MeasurementDirective element modifies the
        /// characteristic evaluation to be the average, minimum or
        /// maximum angle between two features.For example, the angle
        /// from an origin to two circles can be from their centers or
        /// from their closest or furthest tangents./>
        public MeasurementDirectiveType MeasurementDirective { get; set; }

        /// <remarks The optional Vertex element is the point of intersection of
        /// the angle. It is needed when the features themselves do not
        /// intersect to define a vertex. For example, the angle
        /// between two circles with respect to the vertex./>
        public PointType Vertex { get; set; }
    }

    /// <remarks The AngleFromCharacteristicNominalType defines a unique angle-from characteristic nominal./>
    public class AngleFromCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {
        /// <remarks The optional OriginReference element gives the reference
        /// feature for the angle-from characteristic.This is the
        /// first of two features involved in the angle-from
        /// characteristic. The second feature(s) is defined in the
        /// FeatureNominalIds element of CharacteristicNominalBaseType./>
        public OriginReferenceType OriginReference { get; set; }

        /// <remarks The optional AnalysisVector element used by the
        /// AnalysisMode gives a vector defining a unit vector normal
        /// to the plane in which the angle-from characteristic is evaluated./>
        public UnitVectorType AnalysisVector { get; set; }

        /// <remarks The AnalysisMode element indicates whether the angle-from
        /// characteristic is two dimensional or three dimensional./>
        public AngleBetweenAnalysisModeEnumType AnalysisMode { get; set; }

        /// <remarks The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated./>
        public QIFReferenceFullType CoordinateSystemId { get; set; }

        /// <remarks The optional MeasurementDirective element modifies the
        /// characteristic evaluation to be the average, minimum or
        /// maximum angle between two features.For example, the angle
        /// from an origin to two circles can be from their centers or
        /// from their closest or furthest tangents./>
        public MeasurementDirectiveType MeasurementDirective { get; set; }

        /// <remarks The optional Vertex element is the point of intersection of
        /// the angle.It is needed when the features themselves do not
        /// intersect to define a vertex. For example, the angle
        /// between two circles with respect to the vertex./>
        public PointType Vertex { get; set; }
    }

    /// <remarks The AngleCharacteristicNominalType defines a unique angle characteristic nominal./>
    public class AngleCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {

    }

    /// <remarks The UserDefinedAngularCharacteristicNominalType is a characteristic
    /// nominal specified by the user that is measured in angle units.This
    /// user defined type is not to be used where an appropriate type
    /// already exists, in particular it is not to be used for:
    /// angle-between, angle (the feature angle: included, draft, taper),
    /// angular-coordinate or angle-from./>
    public class UserDefinedAngularCharacteristicNominalType : AngularCharacteristicNominalBaseType
    {

    }
}
