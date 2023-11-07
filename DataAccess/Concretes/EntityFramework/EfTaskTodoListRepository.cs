using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos.Task;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfTaskTodoListRepository : EfEntityRepositoryBase<TaskTodoList, PMSContext>, ITaskTodoListRepository
    {
        public List<TaskTodoListDto> GetAllWithTodoByTaskId(int taskId)
        {
            using (var context = new PMSContext())
            {
                var result = (from taskTodoList in context.TaskTodoLists
                              where taskTodoList.TaskId == taskId
                              select new TaskTodoListDto
                              {
                                  Id = taskTodoList.Id,
                                  Title = taskTodoList.Title,
                                  TaskTodos = context.TaskTodos.Where(taskTodo => taskTodo.TaskTodoListId == taskTodoList.Id)
                                  .OrderBy(taskTodo => taskTodo.Id).ToList()
                              }).ToList();
                return result;
            }
        }
    }
}
