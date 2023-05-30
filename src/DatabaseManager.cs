using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;


namespace viewer
{
    [Table("vocabulary")]
    public class NAME
    {
        [Key]
        public int ID { get; set; }
        public string language1 { get; set; }
        public string language2 { get; set; }
        public int mistakes { get; set; }      
    }

    public class DatabaseManager
    {
        public List<NAME> Getname(string l1, string l2)
        {
            
            using (var connection = new SQLiteConnection(Program.t))
            {
                try
                {
                    var b = connection.Query<NAME>("select * from vocabulary WHERE language1 = @l1 OR language2 = @l2", new { l1, l2 }).ToList();
                    connection.Close();
                    return b;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<NAME> GetData()
        {
            
            using (var connection = new SQLiteConnection(Program.t))
            {
                var b = connection.Query<NAME>("select * from vocabulary").ToList();
                connection.Close();
                return b;
            }
        }

    }
}