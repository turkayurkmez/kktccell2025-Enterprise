using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInversion
{

    public interface ISender
    {
        void Send(string to);
    }
    public class ReportService
    {
       

        private readonly ISender sender;

        public ReportService(ISender sender)
        {
            this.sender = sender;
        }



        // public MailSender MailSender { get; set; }
        public void Send(string to)
        {
           // MailSender mailSender = new MailSender();
            sender.Send(to);    
        }

        public void SendApprovedMessage(string to)
        {
            sender.Send(to);
        }
    }

    public class MailSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine($"{to} kişisine mail atıldı");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("WhatsApp");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send(string to)
        {
            Console.WriteLine("Telegram");
        }
    }
}
