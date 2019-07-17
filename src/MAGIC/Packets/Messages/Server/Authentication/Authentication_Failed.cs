using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClashLand.Extensions;
using ClashLand.Extensions.List;
using ClashLand.External.Blake2B;
using ClashLand.External.Sodium;
using ClashLand.Files;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Packets.Cryptography;

namespace ClashLand.Packets.Messages.Server.Authentication
{
    internal class Authentication_Failed : Message
    {
        public Authentication_Failed(Device Device, Reason Reason = Reason.Default) : base(Device)
        {
            this.Identifier = 20103;
            this.Reason = Reason;
            this.Version = 9;
        }


        internal Reason Reason = Reason.Default;
        internal string PatchingHost => Fingerprint.Custom ? Constants.PatchServer : "http://b46f744d64acd2191eda-3720c0374d47e9a0dd52be4d281c260f.r11.cf2.rackcdn.com";//your url

        internal string Message;
        internal string RedirectDomain;

        internal override void Encode()
        {
            this.Data.AddInt((int)this.Reason);
            this.Data.AddString(null);
            this.Data.AddString(this.RedirectDomain);
            this.Data.AddString(null); //Old Patching Host
            this.Data.AddString(Constants.UpdateServer);
            this.Data.AddString(this.Message);
            this.Data.AddInt(this.Reason == Reason.Maintenance? Constants.Maintenance.GetRemainingSeconds(DateTime.Now) : 0);
            //this.Data.AddBool(false);
            this.Data.AddByte(0);
            this.Data.AddCompressed(this.Reason == Reason.Patch ? Fingerprint.Json : null, false);
            this.Data.AddInt(1);
            //this.Data.AddString("http://b46f744d64acd2191eda-3720c0374d47e9a0dd52be4d281c260f.r11.cf2.rackcdn.com");
            this.Data.AddString(this.PatchingHost);
            this.Data.AddInt(0);
            this.Data.AddInt(0);
            this.Data.AddInt(-1);
            this.Data.AddInt(-1);
        }
    }
}
