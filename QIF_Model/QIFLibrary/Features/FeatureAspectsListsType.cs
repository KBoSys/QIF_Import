/*! \file FeatureAspectsListsType.cs
    \brief defines lists of the four aspects of a set of inspection features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Features.Nominals;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks The FeaturesAspectsListsType defines lists of the four aspects of a set of inspection features./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class FeatureAspectsListsType
    {
        #region Properties
        /// <remarks The optional FeatureDefinitions element is a list of definitions of the inspection features./>
        [XmlElement()]
        public FeatureDefinitionsType FeatureDefinitions { get; set; }

        /// <remarks The optional FeatureNominals element is a list of nominal inspection features./>
        [XmlElement()]
        public FeatureNominalsType FeatureNominals { get; set; }

        /// <remarks The optional FeatureItems element is a list of instances of inspection features./>
        [XmlElement()]
        public FeatureItems.FeatureItemsType FeatureItems { get; set; }

        /// <remarks The NominalPointSets element is a list of nominal target
        /// points sets which can be referenced by feature nominals and or feature items./>
        [XmlElement()]
        public NominalPointSetListType NominalPointSets { get; set; }
        #endregion
    }
}
