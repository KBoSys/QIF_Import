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
            MetadataString metadata = new MetadataString();
            metadata.Name = "Product";

            if (header.Name != null)
            {
                metadata.Value.Add(new SFString($"Name: {header.Name}"));
            }
            // Author
            if (header.Author?.Name != null)
            {
                metadata.Value.Add(new SFString($"Author: {header.Author.Name}"));
            }
            if (header.Author?.Organization != null)
            {
                metadata.Value.Add(new SFString($"Author Organization: {header.Author.Organization}"));
            }

            // Application
            if (header.Application?.Name != null)
            {
                metadata.Value.Add(new SFString($"Application: {header.Application.Name}"));
            }
            if (header.Application?.Organization != null)
            {
                metadata.Value.Add(new SFString($"Application Organization: {header.Application.Organization}"));
            }
            if (header.Application?.AddonName != null)
            {
                metadata.Value.Add(new SFString($"Application AddonName: {header.Application.AddonName}"));
            }
            if (header.Application?.AddonOrganization != null)
            {
                metadata.Value.Add(new SFString($"Application AddonOrganization: {header.Application.AddonOrganization}"));
            }

            // ApplicationSource
            if (header.ApplicationSource?.Name != null)
            {
                metadata.Value.Add(new SFString($"ApplicationSource: {header.ApplicationSource.Name}"));
            }
            if (header.ApplicationSource?.Organization != null)
            {
                metadata.Value.Add(new SFString($"ApplicationSource Organization: {header.ApplicationSource.Organization}"));
            }
            if (header.ApplicationSource?.AddonName != null)
            {
                metadata.Value.Add(new SFString($"ApplicationSource AddonName: {header.ApplicationSource.AddonName}"));
            }
            if (header.ApplicationSource?.AddonOrganization != null)
            {
                metadata.Value.Add(new SFString($"ApplicationSource AddonOrganization: {header.ApplicationSource.AddonOrganization}"));
            }

            if (metadata.Value.Count > 0)
            {
                layer.Metadata = metadata;
            }
        }
        private void CreateProductGeometrySet(GeometrySetType geometrySet, CADLayer layer)
        {
            if (geometrySet.PointSet != null)
            {
                CreateGeometryPointSet(geometrySet.PointSet, layer);
            }

            if (geometrySet.Curve12Set != null)
            {
                CADAssembly assembly = new CADAssembly("Curve12Set");

                //geometrySet.PointSet.Items.ForEach(item => CreateGeometryPointSetItem(item, assembly));
                layer.Children.Add(assembly);
            }

            if (geometrySet.Curve13Set != null)
            {
                CADAssembly assembly = new CADAssembly("Curve13Set");

                //geometrySet.PointSet.Items.ForEach(item => CreateGeometryPointSetItem(item, assembly));
                layer.Children.Add(assembly);
            }

            if (geometrySet.SurfaceSet != null)
            {
                CADAssembly assembly = new CADAssembly("SurfaceSet");

                //geometrySet.PointSet.Items.ForEach(item => CreateGeometryPointSetItem(item, assembly));
                layer.Children.Add(assembly);
            }

            if (geometrySet.CurveMeshSet != null)
            {
                CADAssembly assembly = new CADAssembly("CurveMeshSet");

                //geometrySet.PointSet.Items.ForEach(item => CreateGeometryPointSetItem(item, assembly));
                layer.Children.Add(assembly);
            }

            if (geometrySet.SurfaceMeshSet != null)
            {
                CADAssembly assembly = new CADAssembly("SurfaceMeshSet");

                //geometrySet.PointSet.Items.ForEach(item => CreateGeometryPointSetItem(item, assembly));
                layer.Children.Add(assembly);
            }
        }
        private void CreateGeometryPointSet(PointSetType pointSet, CADLayer layer)
        {
            Shape shape = new Shape();
            PointSet pointset = new PointSet();

            X3DCad.Model.Geometry.Coordinates points = new X3DCad.Model.Geometry.Coordinates();
            foreach (var item in pointSet.Items)
            {
                if (item.XYZ != null)
                {
                    points.Points.Add(new SFVec3f((float)item.XYZ.X, (float)item.XYZ.Y, (float)item.XYZ.Z));
                }
            }
            pointset.Points = points;
            shape.Geometry = pointset;
            layer.Children.Add(shape);
        }
    }
}
