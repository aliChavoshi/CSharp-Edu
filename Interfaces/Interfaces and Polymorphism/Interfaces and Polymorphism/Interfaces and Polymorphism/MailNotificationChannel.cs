namespace Interfaces_and_Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending Mail ...");
        }
    }
}
