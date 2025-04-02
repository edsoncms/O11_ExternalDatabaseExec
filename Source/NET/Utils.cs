using OutSystems.RuntimePublic.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.Json;

namespace OutSystems.NssExternalDatabaseExec
{
    internal class Utils
    {

        public static int ReadSequenceValue(string dbConnectionName, string sequenceName)
        {
            var databaseProvider = DatabaseAccess.ForExternalDatabase(dbConnectionName);
            using (var transaction = databaseProvider.GetRequestTransaction())
            {
                using (var command = transaction.CreateCommand($"SELECT "+dbConnectionName+".{"+sequenceName+"}.NEXTVAL FROM DUAL"))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        return reader.GetInt32(0);
                    }
                }
            }
        }

        public static string ExecInsUpdDel(string dbConnectionName, string sql)
        {
            var databaseProvider = DatabaseAccess.ForExternalDatabase(dbConnectionName);
            using (var transaction = databaseProvider.GetRequestTransaction())
            {
                using (var command = transaction.CreateCommand(sql))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        return "";
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }

                }
            }
        }
        public static string ExecuteQuery(string dbConnectionName, string sql, out string result)
        {
            result = "";
            var databaseProvider = DatabaseAccess.ForExternalDatabase(dbConnectionName);
            using (var transaction = databaseProvider.GetRequestTransaction())
            {
                using (var command = transaction.CreateCommand(sql))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            //reader.Read();
                            //resultado = reader.GetString(0);
                            result = JsonSerializer.Serialize(reader);

                        }
                        return "";
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
            }
        }

    }
}
