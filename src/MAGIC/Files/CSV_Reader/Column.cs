using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashLand.Files.CSV_Reader
{

    [DebuggerDisplay("Name = {Name}")]
    public class Column
    {
        internal readonly List<string> Values;
        public Column(Table table, string name)
        {
            if (table == null) throw new ArgumentNullException(nameof(table));

            _name = name;
            _table = table;
            _table._columns.Add(this);

            _data = new List<string>();
        }
        internal Column()
        {
            this.Values = new List<string>();
        }

        internal readonly List<string> _data;

        private readonly string _name;
        private readonly Table _table; public Table Table => _table;

        public string Name => _name;
        internal string Get(int _Row)
        {
            return this.Values[_Row];
        }
    }
}
