using System;
using ClashLand.Files.CSV_Helpers;
using ClashLand.Files.CSV_Reader;

namespace ClashLand.Packets.Commands.Client
{
    internal class Shields
    {
        private Row _Row;
        private DataTable dataTable;

        public Shields(Row row, DataTable dataTable)
        {
            _Row = row;
            this.dataTable = dataTable;
        }

        public static explicit operator Shields(Data v)
        {
            throw new NotImplementedException();
        }
    }
}