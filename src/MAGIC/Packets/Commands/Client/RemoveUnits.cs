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
