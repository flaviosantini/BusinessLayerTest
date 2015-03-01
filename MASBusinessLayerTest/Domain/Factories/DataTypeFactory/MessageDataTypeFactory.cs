using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.DataWrapper;
using Domain.DataWrapper.Interface;
using Domain.Entities;
using Domain.Enums;

namespace Domain.Factories.DataTypeFactory
{
    public static class MessageDataTypeFactory
    {
        public static IDataWrapper<Message> CreateDataObject(DataTypes.PossibleDataTypes possibleDataType)
        {
            switch (possibleDataType)
            {
                case DataTypes.PossibleDataTypes.CoreDataType:
                    return new DefaultMessageDataWrapper();

                default:
                    throw new Exception("Factory not defined!");
            }
        }
    }
}
