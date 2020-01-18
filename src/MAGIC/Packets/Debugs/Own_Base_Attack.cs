using System;
using ClashLand.Core.Networking;
using ClashLand.Packets.Messages.Server;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using Search_Opponent = ClashLand.Packets.Commands.Client.Battle.Search_Opponent;

namespace ClashLand.Packets.Debugs
{

    internal class Own_Base_Attack : Debug
    {
        public Own_Base_Attack(Device Device, params string[] Parameters) : base(Device, Parameters)
        {
            // Own_Base_Attack
        }

        internal override void Process()
        {
            if (this.Device.Player.Avatar.Rank >= Rank.PLAYER)
                try
                {
                    this.Device.Player.Avatar.Modes.Own_Base_Attack = true;

                    new Server_Commands(this.Device)
                    {
                        Command = new Search_Opponent(this.Device, null)
                    }.Send();
                }
                catch (Exception)
                {
                    SendChatMessage("Command Processor: Insufficient privileges.");
                }
        }
    }
}
