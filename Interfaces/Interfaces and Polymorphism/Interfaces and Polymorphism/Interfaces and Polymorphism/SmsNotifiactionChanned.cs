namespace Interfaces_and_Polymorphism
{
    public class SmsNotifiactionChanned : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending Sms ...");
        }
    }
}
