/*! \file ConstructionMethodBaseType.cs
    \brief The ConstructionMethodBaseType is the abstract base type that defines a construction method.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks The ConstructionMethodBaseType is the abstract base type that defines a construction method.A construction method defines the
    /// data for constructing a feature and describes how to use that data in the construction of a feature.In any case where more than one
    /// feature can be constructed with the same input, the result closest to the feature's nominal definition will be chosen./>
    public abstract class ConstructionMethodBaseType
	{
        /// <remarks The optional NominalsCalculated element identifies whether nominals are calculated rather than supplied for the
        /// constructed feature: "true" for calculated, "false" or not present for supplied./>
        [XmlElement]
        public bool NominalsCalculated { get; set; } = false;
    }
}
