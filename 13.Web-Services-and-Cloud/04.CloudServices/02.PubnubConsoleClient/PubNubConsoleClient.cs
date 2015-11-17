namespace PubNumDemo
{
    using System;
    using Constants;

    public class PubNubConsoleClient
    {
        public static void Main()
        {
            PubnubAPI pubnub = new PubnubAPI(
                PubNubConstants.PublishKey,
                PubNubConstants.SubscribeKey,
                PubNubConstants.SecretKey,
                true);

            string channel = PubNubConstants.ChannelName;

            Console.Write("Messages, received in channel {0}: ", channel);
            pubnub.Subscribe(
                channel,
                delegate (object message)
                {
                    Console.WriteLine("Received Message -> '" + message + "'");
                    return true;
                });
        }
    }
}
