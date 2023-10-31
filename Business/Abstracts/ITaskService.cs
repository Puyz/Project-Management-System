using Core.Utilities.Results.Abstracts;
using Entities.Dtos.Task;
using Task = Entities.Concretes.Task;

namespace Business.Abstracts
{
    public interface ITaskService
    {
        IResult Add(AddTaskDto addTaskDto);
        IResult Delete(int taskId);
        IResult DeleteAll(List<Task> tasks);
        IResult Update(EditTaskDto editTaskDto);
        IResult UpdateOrder(TaskOrderEditDto taskOrderEditDto);
        IDataResult<TaskViewDto> GetById(int taskId);
        IDataResult<List<Task>> GetAllByTaskListId(int taskListId);
    }
}
