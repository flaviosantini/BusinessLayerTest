using System;
using System.Collections.Generic;
using Domain.DataWrapper.Interface;
using Domain.Enums;

namespace Domain.Entities
{
    public class Message
    {
        public int UserId { get; set; }
        public IDataWrapper<Message> DataWrapper { get; set; }

        public IList<Message> RetrieveAllMessages()
        {
            if (DataWrapper == null)
                DataWrapper =
                    Factories.DataTypeFactory.MessageDataTypeFactory.CreateDataObject(
                        DataTypes.PossibleDataTypes.CoreDataType);

            return DataWrapper.RetrieveList();
        }
    }
}