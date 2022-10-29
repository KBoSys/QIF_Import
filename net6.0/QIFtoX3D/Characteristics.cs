/*! \file Characteristics.cs
	\brief QIF Characteristics to X3D Geometry

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Characteristics;
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
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Nodes;

namespace QIFtoX3D
{
    public partial class QIF2X3D
    {
        private void CreateCharacteristics(CharacteristicAspectsListsType characteristics, CADLayer layer)
        {
            // All 3 aspects must be present
            if (characteristics.CharacteristicDefinitions == null)
                return;
            if (characteristics.CharacteristicNominals == null)
                return;
            if (characteristics.CharacteristicItems == null)
                return;

            var characteristicsItems = characteristics.CharacteristicItems.Items;
            if (characteristicsItems == null)
                return;

            foreach (CharacteristicItemBaseType item in characteristicsItems)
            {
                CreateCharacteristic(characteristics, item, layer);
            }
        }

        private void CreateCharacteristic(CharacteristicAspectsListsType characteristics, CharacteristicItemBaseType itemBase, CADLayer layer)
        {
            CharacteristicNominalBaseType? nominal = characteristics.CharacteristicNominals?.GetById(itemBase.CharacteristicNominalId);
            if (nominal != null)
            {
                CharacteristicDefinitionBaseType? definition = characteristics.CharacteristicDefinitions?.GetById(nominal.CharacteristicDefinitionId);
                if (definition != null)
                {
                    switch (itemBase)
                    {
                        case PointProfileCharacteristicItemType item:
                            //CreateEdgePoint(part, pt, nominal as EdgePointFeatureNominalType, featureDef as EdgePointFeatureDefinitionType);
                            break;
                        case LinearCoordinateCharacteristicItemType item:
                            break;
                        case DiameterCharacteristicItemType item:
                            break;
                        case PositionCharacteristicItemType item:
                            break;
                        case DistanceBetweenCharacteristicItemType item:
                            break;
                    }
                }
            }
        }
    }
}
