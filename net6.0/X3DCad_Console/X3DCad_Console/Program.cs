using QIFtoX3D;
using X3DCad.Helpers;
using X3DCad.Model;

//X3D? x3d = X3DCadSerializer.Import(@"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\axis_rotall.x3d");
//if (x3d != null)
//{
//    X3DCadSerializer.Export(x3d, @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\Test\axis_rotall.x3d");
//}

string qifFile = @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\TestFiles\check_pmi_position_zero_value_2.QIF";
string x3dFile = @"F:\Projects\KBoSys\Projects\Metrology\QIF_Model\QIF_Model_SRC\net6.0\X3DCad\Examples\Test\check_pmi_position_zero_value_2.X3D";

QIF2X3D converter = new QIF2X3D(qifFile, x3dFile);
converter.Convert();

