using System;
using ClashLand.Extensions;
using ClashLand.Packets;

namespace ClashLand.Core.Networking
{
    internal static class Processor
    {
        internal static void Recept(this Message Message)
        {
            Message.Encrypt();
            Message.Decode();
            Message.Process();
        }


        internal static void Send(this Message Message)
        {
            try
            {
                try
                {
                    Message.Encode();
                }
                catch (Exception ex)
                {
                    Exceptions.Log(ex, $"Exception while encoding message {Message.GetType()}");
                    return;
                }

#if DEBUG
                Loggers.Log(Message, Utils.Padding(Message.Device.Socket.RemoteEndPoint.ToString(), 15));
#endif
                    Message.Encrypt();

                Gateway.Send(Message);
      
                Message.Process();
            }
            catch (Exception)
            {
                //
            }
        }

        internal static Command Handle(this Command Command)
        {
            Command.Encode();

            return Command;
        }
    }
}