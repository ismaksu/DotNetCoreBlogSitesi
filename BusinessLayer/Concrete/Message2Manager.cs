using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2DAL _message2Dal;

        public Message2Manager(IMessage2DAL message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public void AddEntity(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public void DeleteEntity(Message2 t)
        {
            _message2Dal.Delete(t);
        }

        public Message2 FindByID(int id)
        {
            return _message2Dal.FindByID(id);
        }

        public List<Message2> ListEntity()
        {
            return _message2Dal.ListAll();
        }

        public List<Message2> ListInboxByAuthor(int id)
        {
            return _message2Dal.ListWithMessageByReceiver(id);
        }

        public List<Message2> ListSendboxByAuthor(int id)
        {
            return _message2Dal.ListWithMessageBySender(id);
        }

        public void UpdateEntity(Message2 t)
        {
            _message2Dal.Update(t);
        }
    }
}
