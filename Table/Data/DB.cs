using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Table.Data
{
    public class DB
    {
        private TableContext table { get; }
        public Repository<Line, int> Lines;

        public DB(TableContext table)
        {
            this.table = table;
            this.Lines = new Repository<Line, int>(table);
        }

        public void SaveChange() => table.SaveChanges();

        public static TResult Execute<TResult>(Func<DB, TResult> lambda)
        {
            using (var ctx = new TableContext())
            {
                var db = new DB(ctx);
                return lambda(arg: db);
            }
        }

        public static void Execute(Action<DB> lambda) => Execute(db => { lambda(db); return 17; }); 
    }
}