using ClashLand.Logic;
using ClashLand.Extensions.List;

namespace ClashLand.Packets.Commands.Server
{
    using ClashLand.Logic;

    internal class Gems_Added : Command
    {
        private int Gems;
        private int Package;
        private int OfferID;

        private bool Gift;

        public Gems_Added(Device Device, int Gems, int Package = -1, int OfferID = -1, bool Gift = false) : base(Device)
        {
            this.Identifier = 7;

            this.Gems       = Gems;
            this.Package    = Package;
            this.OfferID    = OfferID;

            this.Gift       = Gift;
        }

        internal override void Encode()
        {
            this.Data.AddBool(this.Gift);
            this.Data.AddInt(this.Gems);
            this.Data.AddInt(this.Package);
            this.Data.AddInt(this.OfferID);
            this.Data.AddInt(this.Gift ? 1 : 0);
            this.Data.AddString(null);
        }
    }
}
