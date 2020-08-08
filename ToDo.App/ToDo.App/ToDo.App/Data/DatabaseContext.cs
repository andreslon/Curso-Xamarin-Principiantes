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
        public async Task<int> InsertItemAsync(ToDoItem item)
        {
            return await connection.InsertAsync(item);
        }
        public async Task<List<ToDoItem>> GetItemsAsync()
        {
            return await connection.Table<ToDoItem>().ToListAsync();
        }
    }
}
