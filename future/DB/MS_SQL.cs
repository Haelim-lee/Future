using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace future
{
    public class MS_SQL
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataAdapter Adapter { get; set; }
        public UserSession Session;

        public void Connet()
        {
            Connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=cardio;Integrated Security =False; user id = cardio; password = cardi0;");
            Connection.Open();
        }
        public DataTable Select (string selectQuery)
        {
            DataTable ReturnTable = new DataTable();
            Command = new SqlCommand(selectQuery, Connection);
            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(ReturnTable);

            return ReturnTable;
        }

        public int ExecQuery(string Query)
        {
            Command = new SqlCommand(Query, Connection);
            int iret = Command.ExecuteNonQuery();
            
            return iret;
        }

        public List<SqlParameter> CreateParam(Dictionary<string, DBType> Param)
        {
            List<SqlParameter> LParam = new List<SqlParameter>();
            foreach (KeyValuePair<string, DBType> item in Param)
                if (item.Value.DataSize == 0)
                    LParam.Add(new SqlParameter(item.Key, item.Value.DataType) { Value = item.Value.DataValue });
                else
                    LParam.Add(new SqlParameter(item.Key, item.Value.DataType, item.Value.DataSize) { Value = item.Value.DataValue });

            return LParam;
        }
        public void ExecProcedure(string commandName, Dictionary<string, DBType> parameters)
        {
            Command.Parameters.Clear();
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddRange(CreateParam(parameters).ToArray());
            Command.CommandText = commandName;
            Command.ExecuteNonQuery();
        }

        public void OnTransaction(bool IsCommit)
        {
            if (IsCommit) Command.Transaction.Commit();
            else Command.Transaction.Rollback();
        }



    }

}