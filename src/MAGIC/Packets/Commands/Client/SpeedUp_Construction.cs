using ClashLand.Extensions.Binary;
using ClashLand.Logic;
using ClashLand.Logic.Enums;
using ClashLand.Logic.Structure;

namespace ClashLand.Packets.Commands.Client
{
    internal class SpeedUp_Construction : Command
    {
        internal int BuildingId;
        internal int Village;

        public SpeedUp_Construction(Reader reader, Device client, int id) : base(reader, client, id)
        {
        }
        internal override void Decode()
        {
            this.BuildingId = this.Reader.ReadInt32();
            this.Village = this.Reader.ReadInt32();
            base.Decode();
        }

        internal override void Process()
        {
            var GameObject = this.Device.Player.Avatar.Variables.IsBuilderVillage ? this.Device.Player.GameObjectManager.GetBuilderVillageGameObjectByID(BuildingId) : this.Device.Player.GameObjectManager.GetGameObjectByID(BuildingId);

            //  if (go != null)
            if (GameObject != null)
            {
                if (GameObject is Building)
                {
                    Building Building = (Building)GameObject;
                    Building.SpeedUpConstruction();
                }
                else if (GameObject is Trap)
                {
                    Trap Trap = (Trap)GameObject;
                    Trap.SpeedUpConstruction();
                }
                else if (GameObject is Village_Object)
                {
                    Village_Object VillageObject = (Village_Object)GameObject;
                    VillageObject.SpeedUpConstruction();
                }
            }
        }
    }
}