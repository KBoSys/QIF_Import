/*! \file CADFeatures.cs
	\brief QIF Features to X3D Geometry

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features;
using QIF_Model.QIFLibrary.Features.FeatureDefinitions;
using QIF_Model.QIFLibrary.Features.FeatureItems;
using QIF_Model.QIFLibrary.Features.Nominals;
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Geometry;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;

namespace QIFtoX3D
{
    public partial class QIF2X3D
    {
        private void CreateFeatures(FeatureAspectsListsType features, CADLayer layer)
        {
            // Single Assembly
            CADAssembly assembly = new CADAssembly()
            {
                Name = "Assembled part"
            };
            CreateParts(features, assembly);
            layer.Children.Add(assembly);
        }

        private void CreateParts(FeatureAspectsListsType features, CADAssembly assembly)
        {
            // TODO: Multi-Parts

            // Single Part
            CADPart part = new CADPart()
            {
                Name = "Detail"
            };
            CreateFeatures(features, part);

            assembly.Children.Add(part);
        }

        private void CreateFeatures(FeatureAspectsListsType features, CADPart part)
        {
            if (features.FeatureDefinitions == null)
                return;
            if (features.FeatureNominals == null)
                return;

            //if (features.FeatureItems == null)
            //    return;

            var featureNominals = features.FeatureNominals.Items;
            if (featureNominals == null)
                return;

            foreach (FeatureNominalBaseType nominal in featureNominals)
            {
                CreateNominalGeometry(features, nominal, part);
            }
        }
        private void CreateNominalGeometry(FeatureAspectsListsType features, FeatureNominalBaseType nominal, CADPart part)
        {
            if (nominal != null)
            {
                FeatureDefinitionBaseType? featureDef = features.FeatureDefinitions?.GetById(nominal.FeatureDefinitionId);
                FeatureItemBaseType? featureItem = features.FeatureItems?.GetByNominalId(nominal.id);

                if (featureDef != null)
                {
                    switch (nominal)
                    {
                        case EdgePointFeatureNominalType ptNominal:
                            CreateEdgePoint(part, featureItem as EdgePointFeatureItemType, ptNominal, featureDef as EdgePointFeatureDefinitionType);
                            break;
                        case PointFeatureNominalType ptNominal:
                            CreatePoint(part, featureItem as PointFeatureItemType, ptNominal, featureDef as PointFeatureDefinitionType);
                            break;
                        case CircleFeatureNominalType circle:
                            CreateCircle(part, featureItem as CircleFeatureItemType, circle, featureDef as CircleFeatureDefinitionType);
                            break;
                        case CylinderFeatureNominalType cylinder:
                            CreateCylinder(part, featureItem as CylinderFeatureItemType, cylinder, featureDef as CylinderFeatureDefinitionType);
                            break;
                        default:
                            break;
                        case null:
                            throw new ArgumentNullException(nameof(featureDef));
                    }
                }
            }
        }
        private void CreateAppearance(FeatureItemBaseType? item, Shape shape)
        {
            if (item == null)
                return;

            //TODO
            shape.Appearance = new Appearance()
            {
                DEF = "APP01" 
            };
        }

        private void CreateEdgePoint(CADPart part, EdgePointFeatureItemType? featureItem, EdgePointFeatureNominalType? nominal, EdgePointFeatureDefinitionType? featureDef)
        {
            if (nominal == null || nominal.Location == null)
                return;

            Shape shape = new Shape();
            CreateAppearance(featureItem, shape);

            PointSet pointset = new PointSet();
            Coordinates coord = new Coordinates();
            coord.Points.Add(new SFVec3f((float)nominal.Location.X, (float)nominal.Location.Y, (float)nominal.Location.Z));
            pointset.Points = coord;

            shape.Geometry = pointset;
            part.Children.Add(shape);
        }

        private void CreatePoint(CADPart part, PointFeatureItemType? featureItem, PointFeatureNominalType? nominal, PointFeatureDefinitionType? featureDef)
        {
            if (nominal == null || nominal.Location == null)
                return;

            Shape shape = new Shape();
            CreateAppearance(featureItem, shape);

            PointSet pointset = new PointSet();
            Coordinates coord = new Coordinates();
            coord.Points.Add(new SFVec3f((float)nominal.Location.X, (float)nominal.Location.Y, (float)nominal.Location.Z));
            pointset.Points = coord;

            shape.Geometry = pointset;
            part.Children.Add(shape);
        }

        private void CreateCircle(CADPart part, CircleFeatureItemType? featureItem, CircleFeatureNominalType? nominal, CircleFeatureDefinitionType? featureDef)
        {
            Shape shape = new Shape();
            CreateAppearance(featureItem, shape);

            if (featureDef != null)
            {
                Circle2D circle = new Circle2D((float)(featureDef.Diameter.Value / 2));
                shape.Geometry = circle;
            }

            if (nominal != null)
            {
                Transform tr = new Transform();
                if (nominal.Location != null)
                {
                    tr.Translation = new SFVec3f((float)nominal.Location.X, (float)nominal.Location.Y, (float)nominal.Location.Z);
                }
                if (nominal.Normal != null)
                {
                    tr.Rotation = new SFRotation((float)nominal.Normal.Value[0], (float)nominal.Normal.Value[1], (float)nominal.Normal.Value[2], 0);
                }

                tr.Children.Add(shape);
                part.Children.Add(tr);
            }
            else
            {
                part.Children.Add(shape);
            }
        }

        private void CreateCylinder(CADPart part, CylinderFeatureItemType? featureItem, CylinderFeatureNominalType? nominal, CylinderFeatureDefinitionType? featureDef)
        {
            Shape shape = new Shape();
            CreateAppearance(featureItem, shape);

            if (featureDef != null)
            {
                Cylinder cylinder = new Cylinder();
                cylinder.Radius = (float)(featureDef.Diameter.Value / 2);
                cylinder.Height = (float)featureDef.Length.Value;

                shape.Geometry = cylinder;
            }

            if (nominal != null)
            {
                Transform tr = new Transform();
                if (nominal.Axis?.AxisPoint != null)
                {
                    tr.Translation = new SFVec3f((float)nominal.Axis.AxisPoint.X, (float)nominal.Axis.AxisPoint.Y, (float)nominal.Axis.AxisPoint.Z);
                }
                if (nominal.Axis?.Direction != null)
                {
                    tr.Rotation = new SFRotation((float)nominal.Axis.Direction.Value[0], (float)nominal.Axis.Direction.Value[1], (float)nominal.Axis.Direction.Value[2], 0);
                }

                tr.Children.Add(shape);
                part.Children.Add(tr);
            }
            else
            {
                part.Children.Add(shape);
            }
        }

    }
}
