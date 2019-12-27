using ClashLand.Logic;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic.Structure.Slots.Items;
using ClashLand.Files;
using ClashLand.Logic.Enums;


namespace ClashLand.Packets.Commands.Client
{

    internal class Friend_List_Opened : Command

    {
        /*public override LogicCommandType GetCommandType()
        {
            return LogicCommandType.FRIEND_LIST_OPENED;
        }

        public override void Destruct()
        {
            base.Destruct();
        }

        public override int Execute(LogicLevel level)
        {
            level.GetPlayerAvatar().UpdateLastFriendListOpened();
            return 0;
        }*/
        public Friend_List_Opened(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {

        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            this.Reader.ReadInt32();

            this.Tick = this.Reader.ReadInt32();
        }
    }
}