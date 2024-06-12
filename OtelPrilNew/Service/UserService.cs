using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelPrilNew.Service
{
    public static class UserService
    {
        public static async Task<bool> Auth(string username, string password)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(DBConnection.ConnectionString);// создание строителя подключения к бд

            await using var dataSource = dataSourceBuilder.Build();// создание источника данных

            var command = dataSource.CreateCommand($"SELECT password FROM users WHERE login='{username}'");//создание команды к бд на языке SQL
            var reader = await command.ExecuteReaderAsync(); //Чтение ответа с бд

            while (await reader.ReadAsync())
            {
                if ((string)reader["password"] == password)
                {
                    SessionService.AddUserToSecureStorage(username);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
