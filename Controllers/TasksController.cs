using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private static List<TaskItem> _tasks = new List<TaskItem>
    {
        new TaskItem { Id = 1, Title = "Learn .NET", IsCompleted = false },
        new TaskItem { Id = 2, Title = "Build an API", IsCompleted = false }
    };

    [HttpGet]
    public ActionResult<List<TaskItem>> GetAll()
    {
        return Ok(_tasks);
    }

    [HttpGet("{id}")]
    public ActionResult<TaskItem> GetById(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return NotFound();
        return Ok(task);
    }

    [HttpPost]
    public ActionResult<TaskItem> Create(TaskItem newTask)
    {
        newTask.Id = _tasks.Count + 1;
        _tasks.Add(newTask);
        return CreatedAtAction(nameof(GetById), new { id = newTask.Id }, newTask);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, TaskItem updatedTask)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return NotFound();
        task.Title = updatedTask.Title;
        task.IsCompleted = updatedTask.IsCompleted;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null) return NotFound();
        _tasks.Remove(task);
        return NoContent();
    }
}