using System;
using System.Collections.Generic;
namespace ClashLand.Files.CSV_Reader
{
    public class Row
    {
        public readonly int RowStart;
        public Row(Table table, string name)
        {
            if (table == null)
                throw new ArgumentNullException(nameof(table));

            _name = name;
            _table = table;
            _table._rows.Add(this);
        }
        public Row (Table Table)
        {
            this.RowStart = this.Table.GetRowCount();
        }

        internal int _start;
        internal int _end;

        public Table Table => _table;
        public string Name => _name;
        public int Offset
        {
            get
            {
                return this.RowStart;
            }
        }

        private readonly string _name;
        private readonly Table _table;
        
    }
}
