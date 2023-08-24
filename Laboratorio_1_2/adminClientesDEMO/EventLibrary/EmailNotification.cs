using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLibrary
{
    public class EmailNotification
    {

        public event EventHandler<EmailNotificationEventArgs> EmailBienvenidaNotificacionEvent = delegate { };

        public void EmailBienvenidaNotificacion(string message)
        {
            var eventArgs = new EmailNotificationEventArgs(message);
            EmailBienvenidaNotificacionEvent?.Invoke(this, eventArgs);
        }

    }


    public class EmailNotificationEventArgs : EventArgs
    {
        public string Message { get; }

        public EmailNotificationEventArgs(string message)
        {
            Message = message;
        }
    }


}
