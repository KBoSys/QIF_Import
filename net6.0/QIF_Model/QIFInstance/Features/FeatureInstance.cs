/*! \file FeatureInstance.cs
    \brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFInstance.Characteristics;
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Features.Nominals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFInstance.Features
{
    public class FeatureInstance
    {
        public FeatureDefinitionBaseType? Definition { get; set; }
        public FeatureNominalBaseType? Nominal { get; set; }
        public FeatureItemBaseType? Item { get; set; }

        /// <summary>
        /// List with all characteristics associated to this Feature
        /// </summary>
        public CharacteristicsList Characteristics { get; set; } = new CharacteristicsList();
    }
}
