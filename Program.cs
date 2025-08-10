using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public static void Main(string[] args)
    {
        Notification notification = new Notification();
        notification._messageService = new EmailService();

        notification.Notify("Hello World !!!");
    }

}

public interface IMessageService
{
    public void SendMessage(string message);
}


public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine(message);
    }
}


public class Notification
{
    public IMessageService _messageService { get; set; }

    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }

}



