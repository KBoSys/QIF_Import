/*! \file CharacteristicsList.cs
    \brief List with charatcetristic instances

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFInstance.Characteristics
{
    public class CharacteristicsList
    {
        public List<CharacteristicInstance> Items { get; set; } = new List<CharacteristicInstance>();
    }
}
