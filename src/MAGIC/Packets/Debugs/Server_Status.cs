using System;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Core.Networking;


namespace ClashLand.Packets.Debugs
{


    internal class Server_Status : Debug
    {
        public Server_Status(Device Device, params string[] Parameters) : base(Device, Parameters)
        {
            // Server_Status
        }

        internal override void Process()
        {
            if (this.Device.Player.Avatar.Rank >= Rank.ADMIN)
                try
                {
                    SendChatMessage("~ Server Status ~ \n" +
                        "* Online Players : " + Convert.ToString(Gateway.NumberOfBuffersInUse.ToString() + " \n" +
                        "* RAM usage of the Emulator : " + (System.Diagnostics.Process.GetCurrentProcess().WorkingSet64 / (1024 * 1024)) + " MB / 32768 MB \n"));
                }
                catch (Exception)
                {
                    SendChatMessage("Command Processor: Insufficient privileges.");
                }
        }
    }
}