// See https://aka.ms/new-console-template for more information
using DepencyInversion;

Console.WriteLine("Hello, World!");

MailSender mailSender = new MailSender();
WhatsAppSender whatsAppSender = new WhatsAppSender();
TelegramSender telegramSender = new TelegramSender();

ReportService reportService = new ReportService(mailSender);

ReportService whatsAppReports = new ReportService(whatsAppSender);
whatsAppReports.Send("bilmemkim");

ReportService telegramReport = new ReportService(telegramSender);
telegramSender.Send("falanca");


//reportService.MailSender = mailSender;
reportService.Send("A");
//MailSender anotherSender = new MailSender ();

//reportService.MailSender = anotherSender;

//reportService.Send("B");

