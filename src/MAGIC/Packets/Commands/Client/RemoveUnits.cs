using System.Collections.Generic;
using ClashLand.Core;
using ClashLand.Logic;
using ClashLand.Packets.Commands.Client.List;
using ClashLand.Extensions.Binary;



namespace ClashLand.Packets.Commands.Client
{

    internal class RemoveUnits : Command
    {
        internal List<UnitToRemove> UnitsToRemove;
        public RemoveUnits(Reader Reader, Device Device, int Identifier) : base(Reader, Device, Identifier)
        {
        }

        public int Tick { get; private set; }

        internal override void Decode()
        {
            int UnitCount = this.Reader.ReadInt32();
            this.UnitsToRemove = new List<UnitToRemove>(UnitCount);

            for (int i = 0; i < UnitCount; i++)
            {
                this.Reader.ReadInt32();
                this.UnitsToRemove.Add(new UnitToRemove
                {
                    Type = this.Reader.ReadInt32(),
                    Id = this.Reader.ReadInt32(),
                    Count = this.Reader.ReadInt32()
                });
                this.Reader.ReadInt32();
            }

            base.Decode();
        }

        internal override void Process()
        {
            base.Process();
        }
    }
}

/*internal override void Execute()
{
    Level Level = this.Device.GameMode.Level;
    foreach (UnitToRemove UnitToRemove in this.UnitsToRemove)
    {
        if (UnitToRemove.Type == 0)
        {
            Item Unit = Level.Player.Units.Find(T => T.Data == UnitToRemove.Id);
            if (Unit != null)
            {
                Unit.Count -= UnitToRemove.Count;
            }
        }
        else if (UnitToRemove.Type == 1)
        {
            Item Spell = Level.Player.Spells.Find(T => T.Data == UnitToRemove.Id);
            if (Spell != null)
            {
                Spell.Count -= UnitToRemove.Count;
            }
        }
        else
        {
            Logging.Error(this.GetType(), "Unable to remove units. Unknown unit type!");
        }
    }
}
}
}*/
/*using System.Collections.Generic;
using System.IO;
using ClashLand.Logic;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Core.Events;

namespace ClashLand.Packets.Commands.Client
{
    // Packet 550
    internal class RemoveUnits : Command
    {
        public RemoveUnits(PacketReader br)
        {
            Unknown1 = br.ReadUInt32WithEndian();
            UnitTypesCount = br.ReadInt32WithEndian();

            UnitsToRemove = new List<UnitToRemove>();
            for (var i = 0; i < UnitTypesCount; i++)
            {
                var unit = (CharacterData) br.ReadDataReference();
                var count = br.ReadInt32WithEndian();
                var level = br.ReadInt32WithEndian();
                UnitsToRemove.Add(new UnitToRemove { Data = unit, Count = count, Level = level });
            }

            Unknown2 = br.ReadUInt32WithEndian();
        }

        public override void Execute(Level level)
        {
            foreach (var unit in UnitsToRemove)
            {
                List<Component> components = level.GetComponentManager().GetComponents(0);
                for (var i = 0; i < components.Count; i++)
                {
                    UnitStorageComponent c = (UnitStorageComponent)components[i];
                    if (c.GetUnitTypeIndex(unit.Data) != -1)
                    {
                        int storageCount = c.GetUnitCountByData(unit.Data);
                        if (storageCount >= unit.Count)
                        {
                            c.RemoveUnits(unit.Data, unit.Count);
                            break;
                        }
                        c.RemoveUnits(unit.Data, storageCount);
                        unit.Count -= storageCount;
                    }
                }
            }
        }

        public List<UnitToRemove> UnitsToRemove { get; set; }
        public int UnitTypesCount { get; set; }
        public uint Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
    }

    internal class UnitToRemove
    {
        public int Count { get; set; }
        public CharacterData Data { get; set; }
        public int Level { get; set; }
    }
}*/
