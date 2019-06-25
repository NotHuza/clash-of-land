using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using ClashLand.Core;
using ClashLand.Core.Networking;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.External.Sodium;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Packets;
using ClashLand.Packets.Messages.Server.Authentication;

namespace ClashLand.Packets.Client.Authentication
{
    internal class Unlock_Account : Message
    {
        internal long UserID;
        internal string UserToken;
        internal string UnlockCode;
        internal string UserPassword;

        public Unlock_Account(Device Device) : base(Device)
        {
            this.UserPassword = this.Device.Player != null ? this.Device.Player.Avatar.Password : String.Empty;
        }

        internal override void Decode()
        {
            this.UserID = this.Reader.ReadInt64();
            this.UserToken = this.Reader.ReadString();

            this.UnlockCode = this.Reader.ReadString();
        }

        internal override void Process()
        {
            if (this.UnlockCode.Length != 12 || string.IsNullOrEmpty(this.UnlockCode))
            {
                Devices.Remove(this.Device.SocketHandle);
                return;
            }

            if (this.UnlockCode[0] == '/')
            {
                int n = 0;
                if (int.TryParse(this.UnlockCode.Substring(1), out n))
                {
                    if (n == 0)
                    {
                        new Unlock_Account_OK(this.Device) { Account = Players.New().Avatar }.Send();
                        return;
                    }

                    var account = Players.Get(n);
                    if (account != null)
                    {
                        account.Avatar.Locked = true;
                        new Unlock_Account_OK(this.Device) { Account = account.Avatar }.Send();
                    }
                    else
                    {
                        new Unlock_Account_Failed(this.Device) { Reason = UnlockReason.UnlockError }.Send();
                    }

                }
                else
                {
                    new Unlock_Account_Failed(this.Device) { Reason = UnlockReason.UnlockError }.Send();
                }
            }
            if (string.Equals(this.UnlockCode, this.UserPassword))
            {
                this.Device.Player.Avatar.Locked = false;
                new Unlock_Account_OK(this.Device) { Account = this.Device.Player.Avatar }.Send();
            }
            else
            {
                new Unlock_Account_Failed(this.Device) { Reason = UnlockReason.Default }.Send();

            }
        }
    }
}