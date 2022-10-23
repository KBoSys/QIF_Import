/*! \file CharacteristicInstance.cs
    \brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Characteristics.Definition;
using QIF_Model.QIFLibrary.Characteristics.Items;
using QIF_Model.QIFLibrary.Characteristics.Nominal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFInstance.Characteristics
{
    public class CharacteristicInstance
    {
        public CharacteristicDefinitionBaseType? Definition { get; set; }
        public CharacteristicNominalBaseType? Nominal { get; set; }
        public CharacteristicItemBaseType? Item { get; set; }
    }
}
