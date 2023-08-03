using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;

public class TodoDataAccess
{
    private string connectionString;

    public TodoDataAccess()
    {
        connectionString = ConfigurationManager.ConnectionStrings["TodoDbConnection"].ConnectionString;
    }

    public List<TodoItem> GetAllTasks()
    {
        List<TodoItem> tasks = new List<TodoItem>();

        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM tasks", connection);

            using NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var task = new TodoItem
                {
                    id = Convert.ToInt32(reader["id"]),
                    title = reader["title"].ToString(),
                    description = reader["description"].ToString(),
                    is_complete = Convert.ToBoolean(reader["is_complete"])
                };

                tasks.Add(task);
            }
        }

        
        return tasks;
    }

    public void InsertTask(TodoItem task)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            using var cmd = new NpgsqlCommand("INSERT INTO tasks (title, description, is_complete) VALUES (@title, @description, @is_complete)", connection);

            cmd.Parameters.AddWithValue("title", task.title);
            cmd.Parameters.AddWithValue("description", task.description);
            cmd.Parameters.AddWithValue("is_complete", task.is_complete);

            cmd.ExecuteNonQuery();
        }
    }

    public void UpdateTask(TodoItem task)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            using var cmd = new NpgsqlCommand("UPDATE tasks SET title = @title, description = @description, is_complete = @is_complete WHERE id = @id", connection);

            cmd.Parameters.AddWithValue("id", task.id);
            cmd.Parameters.AddWithValue("title", task.title);
            cmd.Parameters.AddWithValue("description", task.description);
            cmd.Parameters.AddWithValue("is_complete", task.is_complete);

            cmd.ExecuteNonQuery();
        }
    }

    public void DeleteTask(int id)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            using var cmd = new NpgsqlCommand("DELETE FROM tasks WHERE id = @id", connection);

            cmd.Parameters.AddWithValue("id", id);

            cmd.ExecuteNonQuery();
        }
    }
}


public class TodoItem
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public bool is_complete { get; set; }
}
