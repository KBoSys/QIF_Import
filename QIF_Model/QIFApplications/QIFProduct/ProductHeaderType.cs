/*! \file ProductHeaderType.cs
    \brief Defines information about the creation of the file containing the CAD model and global parameters of the model.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks The InternalHeaderType defines information about the creation of
    /// the file containing the CAD model and global parameters of the model./>
    [System.SerializableAttribute()]
    public class ProductHeaderType : PartAssemblyHeaderType
    {
        /// <remarks The optional ScaleCoefficient element is an amount by which
        /// all elements representing distances in the QIFDocument/QIFProduct and QIFDocument/Features portions of
        /// an instance file are scaled. 
        /// The default value is 1.
        /// The type of all values to be scaled is either LinearValueType
        /// or xs:double. To convert such values in an instance file to
        /// actual values, divide by the ScaleCoefficient. To record
        /// actual values in an instance file, multiply the actual
        /// value by the ScaleCoefficient./>
        [XmlElement]
        public double ScaleCoefficient { get; set; } = 1.0;

        /// <remarks The optional ModelTolerance element is the model tolerance.
        /// This value specifies the smallest distance between
        /// coordinates, in the global units defined above, that shall be considered as distinct./>
        [XmlElement]
        public double ModelTolerance { get; set; }

        /// <remarks The optional EpsMassProperty element specifies a tolerance
        /// used for calculation of the mass properties of model entities./>
        [XmlElement]
        public double MassPropertyTolerance { get; set; }
    }
}
