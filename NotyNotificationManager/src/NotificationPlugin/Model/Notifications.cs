using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NotyNotification.Model
{
    public class Notifications
    {
        private const string DictionaryName = "NOTY_NOTIFICATIONS";

        private readonly IList<Notification> _notifications;

        public Notifications(TempDataDictionary tempDataDictionary)
        {
            if (!tempDataDictionary.ContainsKey(DictionaryName))
            {
                tempDataDictionary[DictionaryName] = new List<Notification>();
            }
            _notifications = tempDataDictionary[DictionaryName] as IList<Notification>;
        }

        public IEnumerable<Notification> Current => _notifications;

        public void Add(String message, Position position, AlertType alertType, int timeout, bool animation, bool modal)
        {
            _notifications.Add(new Notification { TimeOut = timeout, Message = message, Position = position, AlertType = alertType, Animation = animation, Modal = modal });
        }
    }
}
