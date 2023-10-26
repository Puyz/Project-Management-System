using Core.Utilities.Results.Abstracts;
using Task = Entities.Concretes.Task;

namespace Business.Abstracts
{
    public interface ITaskService
    {
        IResult Add(Task taskDto); // add task dto
        IResult Delete(int taskId);
        IResult DeleteAll(List<Task> tasks);
        IResult Update(Task taskDto); // edit task dto
        IResult UpdateOrder(Task taskOrderEditDto); // task order edit dto
        IDataResult<Task> GetById(int taskId); // task view dto
        IDataResult<List<Task>> GetAllByTaskListId(int taskListId);
    }
}
