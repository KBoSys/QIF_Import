/*! \file PointDeviationsType.cs
    \brief defines a list of vector deviations of individual measurement points from nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <remarks The PointDeviationsType defines a list of vector deviations of
    /// individual measurement points from nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDeviationsType
    {
        /// <remarks Each PointDeviation element gives the vector deviation of an
        /// individual measurement point from nominal./>
        [System.Xml.Serialization.XmlElementAttribute("PointDeviation")]
        public PointDeviationType[] Deviations { get; set; }

        /// <remarks The required n attribute is the number of point deviations in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Deviations.Length;
            set { }
        }
    }

    /// <remarks The PointDeviationType defines the deviation of a measurement point from nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDeviationType
    {
        /// <remarks The MeasurePointId element is the index of a single point in a
        /// measured point set with the specified QIF id./>
        public IntermediatesPMI.PointSetReferenceSingleType MeasurePointId { get; set; }

        /// <remarks The Deviation element is the deviation of the individual
        /// measurement point in the direction of the surface or curve
        /// normal. It is positive if the deviation is in the direction of
        /// the normal vector and negative if the deviation is in the
        /// direction opposite the normal vector./>
        public LinearValueType Deviation { get; set; }
    }

}
