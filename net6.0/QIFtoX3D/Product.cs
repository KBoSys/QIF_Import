/*! \file Product.cs
	\brief QIF Product to X3D Layer

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Metadata;
using X3DCad.Model.Nodes;
using QIF_Model.QIFApplications.QIFProduct;
using QIF_Model.QIFLibrary.Geometry;
using X3DCad.Model.Geometry;
using X3DCad.Model.Types;
using Newtonsoft.Json;
using System.Security;
using System.Reflection;

namespace QIFtoX3D
{
    public partial class QIF2X3D
    {
        private void CreateProductLayer(ProductType product, CADLayer layer)
        {
            if (product.Header != null)
            {
                CreateProductHeader(product.Header, layer);
            }

            if (product.GeometrySet != null)
            {
                CreateProductGeometrySet(product.GeometrySet, layer);
            }
        }

        private void CreateProductHeader(ProductHeaderType header, CADLayer layer)
        {
            string jsonHeader = JsonConvert.SerializeObject(header);
            string headerStr = SecurityElement.Escape(jsonHeader);
            layer.Metadata = new MetadataString("QIFHeader", headerStr);
        }
    }
}
