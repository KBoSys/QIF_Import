/*! \file VirtualMeasurementType.cs
    \brief
        The VirtualMeasurementType is a placeholder used in a
        characteristic item or feature item to represent a measured object
        of the same type as the item. For example, an instance of
        VirtualMeasurementType placed in an instance of
        DiameterCharacteristicItemType would represent an instance of
        DiameterCharacteristicMeasurementType. Parameters of the virtual
        measurement object become available after an evaluation of the
        item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> </remarks>
    public class VirtualMeasurementType : QIFIdTypeBase
    {
    }
}
