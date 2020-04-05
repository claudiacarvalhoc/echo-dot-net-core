using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public TodoItem()
        {
            Id = Guid.NewGuid().ToString();
            Status = TodoStatus.NEW;
        }
        public TodoItem(string id, string name, string details, int status)
        {
            Id = id;
            Name = name;
            Details = details;

            if(Enum.TryParse<TodoStatus>(status.ToString(), out TodoStatus resultStatus))
            {
                Status = resultStatus;
            }
            else
            {
                Status = TodoStatus.NEW;
            }

        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public TodoStatus Status { get; set; }
    }
}