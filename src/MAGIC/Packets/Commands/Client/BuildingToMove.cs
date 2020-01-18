using System.Windows;

namespace ClashLand.Packets.Commands.Client
{
    internal struct BuildingToMove
    {
        internal int Id;
        internal Vector XY;

        public int X { get; internal set; }
        public int Y { get; internal set; }
    }
}