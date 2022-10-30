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

        private void CreateProductGeometrySet(GeometrySetType geometrySet, CADLayer layer)
        {
            if (geometrySet.PointSet != null)
            {
                CreateGeometryPointSet(geometrySet.PointSet, layer);
            }

            if (geometrySet.Curve12Set != null)
            {
                CreateCurve12Set(geometrySet.Curve12Set, layer);
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

        private void CreateCurve12Set(Curve12SetType curveSet, CADLayer layer)
        {
            Polyline2D? currPolyline = null;
            foreach (var item in curveSet.Items)
            {
                switch (item)
                {
                    case Segment12Type seg:
                        var startPt = seg.Segment12Core.StartPoint;
                        var endPt = seg.Segment12Core.EndPoint;
                        if (currPolyline != null)
                        {
                            if (currPolyline.LineSegments.Count == 0)
                                throw new ArgumentOutOfRangeException("LineSegments");

                            double ex = currPolyline.LineSegments[currPolyline.LineSegments.Count - 1].X;
                            double ey = currPolyline.LineSegments[currPolyline.LineSegments.Count - 1].Y;

                            // Finish the current polyline and create new one
                            if (Math.Abs(ex - startPt.X) > 1e-6 || Math.Abs(ey - startPt.Y) > 1e-6)
                            {
                                Shape shape = new Shape();
                                shape.Geometry = currPolyline;
                                layer.Children.Add(shape);
                                currPolyline = null;
                            }
                        }

                        if (currPolyline == null)
                        {
                            currPolyline = new Polyline2D();
                            currPolyline.LineSegments.Add(new SFVec2f((float)startPt.X, (float)startPt.Y));
                        }
                        currPolyline.LineSegments.Add(new SFVec2f((float)endPt.X, (float)endPt.Y));

                        break;
                    case Polyline12Type line:
                        break;
                    case ArcConic12Type arc:
                        break;
                    case ArcCircular12Type arc:
                        break;
                    case Nurbs12Type nurbs:
                        break;
                    case Spline12Type spline:
                        break;
                    case Aggregate12Type agregate:
                        break;
                    default:
                        throw new Exception($"Invalid curve12 type: {nameof(item)}");
                    case null:
                        throw new ArgumentNullException("Curve12SetType");
                }

                if (currPolyline != null)
                {
                    Shape shape = new Shape();
                    shape.Geometry = currPolyline;
                    layer.Children.Add(shape);
                }
            }
        }
    }
}
