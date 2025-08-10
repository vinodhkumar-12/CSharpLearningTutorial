using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public interface IMessageService
{
    void SendMessage(string Message);
}


public class EmailService : IMessageService
{
    public void SendMessage(string Message)
    {
        Console.WriteLine(Message);
    }
}


public class Notification
{
    private readonly IMessageService _messgaeService;

    public Notification(IMessageService messgaeService)
    {
        _messgaeService = messgaeService;
    }

    public void Notify(string Message)
    {
        _messgaeService.SendMessage(Message);
    }
}

public class Program
{

    public static void Main(string[] args)
    {
        IMessageService messageService = new EmailService();
        Notification notification = new Notification(messageService);
        notification.Notify("Hello World");
    }

}