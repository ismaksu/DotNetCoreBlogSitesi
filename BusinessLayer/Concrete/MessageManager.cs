using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDal;

        public MessageManager(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddEntity(Message t)
        {
            _messageDal.Insert(t);
        }

        public void DeleteEntity(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message FindByID(int id)
        {
            return _messageDal.FindByID(id);
        }

        //public List<Message> ListInboxByAuthor(string mail)
        //{
        //    return _messageDal.ListAll(x => x.Receiver == mail);
        //}

        public List<Message> ListEntity()
        {
            return _messageDal.ListAll();
        }

        public List<Message> ListInboxByAuthor(string mail)
        {
            throw new NotImplementedException();
        }

        public List<Message> ListInboxByAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
