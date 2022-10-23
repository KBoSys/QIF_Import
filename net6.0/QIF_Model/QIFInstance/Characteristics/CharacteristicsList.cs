/*! \file CharacteristicsList.cs
    \brief List with charatcetristic instances

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFInstance.Features;
using QIF_Model.QIFLibrary.Characteristics.Definition;
using QIF_Model.QIFLibrary.Characteristics.Items;
using QIF_Model.QIFLibrary.Characteristics.Nominal;
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Features.Nominals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFInstance.Characteristics
{
    public class CharacteristicsList
    {
        public List<CharacteristicInstance> Items { get; set; } = new List<CharacteristicInstance>();

        public void Create(QIFDocumentType qifDocument)
        {
            // All 3 aspects must be present
            if (qifDocument?.Characteristics?.CharacteristicDefinitions == null)
                return;
            if (qifDocument?.Characteristics?.CharacteristicNominals == null)
                return;
            if (qifDocument?.Characteristics?.CharacteristicItems == null)
                return;

            var characteristicsItems = qifDocument?.Characteristics?.CharacteristicItems?.Items;
            if (characteristicsItems == null)
                return;

            foreach (CharacteristicItemBaseType item in characteristicsItems)
            {
                CharacteristicNominalBaseType? nominal = qifDocument?.Characteristics?.CharacteristicNominals?.GetById(item.CharacteristicNominalId);
                if (nominal != null)
                {
                    CharacteristicDefinitionBaseType? definition = qifDocument?.Characteristics?.CharacteristicDefinitions?.GetById(nominal.CharacteristicDefinitionId);
                    if (definition != null)
                    {
                        CharacteristicInstance instance = new CharacteristicInstance()
                        {
                            Definition = definition,
                            Nominal = nominal,
                            Item = item
                        };

                        Items.Add(instance);
                        //item.FeatureItemIds.Count;
                    }
                }
            }
        }
    }
}
