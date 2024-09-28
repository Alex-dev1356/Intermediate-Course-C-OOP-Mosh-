namespace Intermediate_Course_C__OOP__Mosh_
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS.....");
        }
    }
}
