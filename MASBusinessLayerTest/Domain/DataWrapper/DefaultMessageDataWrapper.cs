using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DataWrapper.Interface;
using Domain.Entities;

namespace Domain.DataWrapper
{
    class DefaultMessageDataWrapper : IDataWrapper<Message>
    {
        public IList<Message> RetrieveList()
        {
            var messageList = new List<Message>();
            var data = new Data.DefaultMessageDataClass();
            data.Retrieve();

            return messageList;
        }
    }
}
