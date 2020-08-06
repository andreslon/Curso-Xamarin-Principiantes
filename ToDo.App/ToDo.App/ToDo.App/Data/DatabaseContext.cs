using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDo.App.Models;

namespace ToDo.App.Data
{
    public class DatabaseContext
    {
        private readonly SQLiteAsyncConnection connection;

        public DatabaseContext(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);

            connection.CreateTableAsync<ToDoItem>().Wait();
        }

    }
}
