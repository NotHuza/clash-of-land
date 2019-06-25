using ClashLand.Logic;
using ClashLand.Extensions;
using ClashLand.Extensions.Binary;
using ClashLand.Files.CSV_Logic;
using ClashLand.Logic.Structure.Slots.Items;
using ClashLand.Files;
using ClashLand.Logic.Enums;

namespace ClashLand.Packets.Commands.Client
{
    // Packet 523
    internal class ClaimAchievementRewardCommand : Command
    {
        public ClaimAchievementRewardCommand(Reader reader, Device client, int id) : base(reader, client, id)
        {
        }

        internal override void Decode()
        {
            this.AchievementId = this.Reader.ReadInt32();
            this.Unknown1 = this.Reader.ReadUInt32();
        }

       /* internal override void Process()
        {
            Device.Player.Avatar.Achievements.Add(new Achievement
           {
               Id = AchievementId,
               Data = ((Achievements)CSV.Tables.Get(Gamefile.Achievements).GetDataWithID(Id)).ActionCount
           });
        }*/

        public int AchievementId;
        public uint Unknown1;
    }
}