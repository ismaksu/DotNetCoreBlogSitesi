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
    public class NotificationManager : INotificationService
    {
        INotificationDAL _notifiDal;

        public NotificationManager(INotificationDAL notifiDal)
        {
            _notifiDal = notifiDal;
        }

        public void AddEntity(Notification t)
        {
            _notifiDal.Insert(t);
        }

        public void DeleteEntity(Notification t)
        {
            _notifiDal.Delete(t);
        }

        public Notification FindByID(int id)
        {
            return _notifiDal.FindByID(id);
        }

        public List<Notification> ListEntity()
        {
            return _notifiDal.ListAll();
        }

        public List<Notification> ListEnabled()
        {
            return _notifiDal.ListAll(x => x.NotificationStat == true);
        }

        public void UpdateEntity(Notification t)
        {
            _notifiDal.Update(t);
        }
    }
}
