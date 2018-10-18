using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Clase6Ejercicio1.Models;
using SQLite;

namespace Clase6Ejercicio1.Data
{
    public class MyLocalDatabase
    {
        readonly SQLiteAsyncConnection database;

        public int LastInsertedId { get; set; }

        public MyLocalDatabase(string path)
        {
            database = new SQLiteAsyncConnection(path);
            database.CreateTableAsync<TodoItem>().Wait();
        }

        internal void Delete(object item)
        {
            database.DeleteAsync(item).Wait();
        }

        public async Task<IList<TodoItem>> GetTodoItems()
        {
            var results = await database.QueryAsync<TodoItem>("Select * from TodoItem");

            return results;
        }

        public void Insert(TodoItem item)
        {
            database.InsertAsync(item).Wait();
        }

        internal void Update(TodoItem item)
        {
            database.UpdateAsync(item).Wait();
        }
    }
}
