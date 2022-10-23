using QIF_Model.QIFApplications;
using QIF_Model.QIFInstance.Characteristics;
using QIF_Model.QIFInstance.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFInstance
{
    public class ProductInstance
    {
        public FeaturesList Features { get; set; } = new FeaturesList();
        public CharacteristicsList Characteristics { get; set; } = new CharacteristicsList();

        public void Create(QIFDocumentType qifDocument)
        {
            Features.Create(qifDocument);
        }
    }
}
