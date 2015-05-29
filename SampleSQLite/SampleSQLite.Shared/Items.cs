using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SampleSQLite
{
    [Table("Items")]
    public class Items
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Score { get; set; }
    }
}
