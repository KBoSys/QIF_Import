/*! \file MeasurementResourceBaseType.cs
	\brief The base type for measurement resources

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks 
    /// The abstract MeasurementResourceBaseType is the base type for
    /// measurement resources that may be required by an action, used by a
    /// method, or referenced.Resource types can be a fixture, a carriage,
    /// a measurement device, a tool, a sensor, or a probe tip.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class MeasurementResourceBaseType : QIFIdTypeBase
    {
        /// <remarks The Name element is the name of the measurement resource. />
        [XmlElement(IsNullable = false)]
        public string Name { get; set; }

        /// <remarks The optional Description element is a description of the measurement resource. />
        [XmlElement()]
        public string Description { get; set; }

        /// <remarks The optional Manufacturer element is the manufacturer of the measurement resource. />
        [XmlElement()]
        public string Manufacturer { get; set; }

        /// <remarks 
        /// The optional ModelNumber element is the identifier of a
        /// very specific type of measurement resource.There may be
        /// many measurement resources with the same ModelNumber, but
        /// they should all be identical (or nearly so)./>
        [XmlElement()]
        public string ModelNumber { get; set; }

        /// <remarks 
        /// The optional SerialNumber element is the serial number of
        /// the measurement resource.Measurement resources with the
        /// same ModelNumber have different SerialNumbers.The
        /// combination of ModelNumber and SerialNumber should
        /// differentiate a given measurement resource from all other
        /// measurement resources in a QIF application instance file. />
        [XmlElement()]
        public string SerialNumber { get; set; }

        /// <remarks 
        /// The optional Mass element is the mass of the measurement
        /// resource. />
        [XmlElement()]
        public QIFLibrary.Units.MassValueType Mass { get; set; }

        /// <remarks 
        /// The optional Size element is the size of a measurement
        /// resource.The size is defined as a box having X, Y, and Z dimensions. />
        [XmlElement()]
        public CartesianWorkingVolumeType Size { get; set; }

        /// <remarks This optional compositor provides a choice of either a location or a reference to a location. />
        #region Choice
        /// <remarks 
        /// The LocationId element is the QIF id of the location of the
        /// measurement device.This element is in an optional choice. />
        [XmlElement()]
        public QIFLibrary.Primitives.QIFReferenceType LocationId { get; set; }

        /// <remarks 
        /// The Location element gives information about the location of
        /// the measurement resource.This element is in an optional choice. />
        [XmlElement()]
        public QIFLibrary.IntermediatesPMI.LocationType Location { get; set; }
        #endregion

        /// <remarks 
        /// The optional Attributes element contains user defined
        /// attributes that define the first axis(typified, binary
        /// array, or XML structured). />
        [XmlElement()]
        public QIFLibrary.Primitives.AttributesType Attributes { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LaserType : MeasurementResourceBaseType
    {
        /// <remarks/>
        public string LaserSource { get; set; }

        /// <remarks/>
        public LinearValueType LaserWaveLength { get; set; }

        /// <remarks/>
        public UserDefinedUnitValueType LaserPower { get; set; }

        /// <remarks/>
        public string LaserSafetyClass { get; set; }

        /// <remarks/>
        public LinearValueType LaserEffectiveLength { get; set; }

        /// <remarks/>
        public LinearValueType LaserSpotSize { get; set; }

        /// <remarks/>
        public UserDefinedUnitValueType LaserPowerSupply { get; set; }
    }
}
