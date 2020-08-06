using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.App.Models
{
   public class ToDoItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
