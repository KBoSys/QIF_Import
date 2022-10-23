/*! \file FeaturesList.cs
    \brief List with Feature Instances

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
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
    public class FeaturesList
    {
        public List<FeatureInstance> Items { get; set; } = new List<FeatureInstance>();

        public void Create(QIFDocumentType qifDocument)
        {
            // All 3 aspects must be present
            if (qifDocument?.Features?.FeatureDefinitions == null)
                return;
            if (qifDocument?.Features?.FeatureNominals == null)
                return;
            if (qifDocument?.Features?.FeatureItems == null)
                return;

            var featureItems = qifDocument?.Features?.FeatureItems?.Items;
            if (featureItems == null)
                return;

            foreach (FeatureItemBaseType item in featureItems)
            {
                FeatureNominalBaseType? nominal = qifDocument?.Features?.FeatureNominals?.GetById(item.FeatureNominalId);
                if (nominal != null)
                {
                    FeatureDefinitionBaseType? featureDef = qifDocument?.Features?.FeatureDefinitions?.GetById(nominal.FeatureDefinitionId);
                    if (featureDef != null)
                    {
                        Items.Add(new FeatureInstance()
                        {
                            Definition = featureDef,
                            Nominal = nominal,
                            Item = item,
                        });
                    }
                }
            }
        }
    }
}
