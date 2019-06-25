using ClashLand.Core.Networking;
using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Packets.Messages.Server.API;

namespace ClashLand.Packets.Messages.Client.API
{
    internal class Facebook_Connect : Message
    {
        internal byte Unknown;

        internal string FBIdentifier;
        internal string FBToken;


        public Facebook_Connect(Device device) : base(device)
        {
            // Facebook_Connect.
        }
        
        internal override void Decode()
        {
            this.Unknown = this.Reader.ReadByte();
            this.FBIdentifier = this.Reader.ReadString();
            this.FBToken = this.Reader.ReadString();
        }

        internal override void Process()
        {
            this.Device.Player.Avatar.Facebook.Identifier = this.FBIdentifier;
            this.Device.Player.Avatar.Facebook.Token = this.FBToken;

            this.Device.Player.Avatar.Facebook.Connect();

            if(this.Device.Player.Avatar.Facebook.Connected)
            new Facebook_Connect_OK(this.Device).Send();
        }
    }
}
