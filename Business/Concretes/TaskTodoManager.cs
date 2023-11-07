using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskTodoManager : ITaskTodoService
    {
        private readonly ITaskTodoRepository _taskTodoRepository;

        public TaskTodoManager(ITaskTodoRepository taskTodoRepository)
        {
            _taskTodoRepository = taskTodoRepository;
        }

        public IResult Add(TaskTodo taskTodo)
        {
            _taskTodoRepository.Add(taskTodo);
            return new SuccessResult("Ekleme İşlemi Başarılı");
        }

        public IResult Change(int id, bool state)
        {
            var result = _taskTodoRepository.Get(p => p.Id.Equals(id));
            if (result == null) return new ErrorResult("Todo bulunamadı");
            result.State = state;
            _taskTodoRepository.Update(result);
            return new SuccessResult("Güncelleme işlemi başarılı");
        }

        public IResult Delete(int id)
        {
            var result = _taskTodoRepository.Get(p => p.Id.Equals(id));
            if (result == null) return new ErrorResult("Silinecek TaskTodo bulunamadı");

            _taskTodoRepository.Delete(result);
            return new SuccessResult("Silme işlemi başarılı");
        }

        public IResult DeleteAll(List<TaskTodo> taskTodos)
        {

            if (taskTodos == null || !taskTodos.Any()) return new ErrorResult("Silinecek TaskTodolar bulunamadı");

            foreach (var taskTodo in taskTodos)
            {
                Delete(taskTodo.Id);
            }

            return new SuccessResult();
        }

        public IDataResult<List<TaskTodo>> GetAllByTodoListId(int todoListId)
        {
            var result = _taskTodoRepository.GetAll(p => p.TaskTodoListId.Equals(todoListId));
            return new SuccessDataResult<List<TaskTodo>>(result);
        }

        public IResult Update(TaskTodo taskTodo)
        {
            var updatedTaskTodo = _taskTodoRepository.Get(p => p.Id.Equals(taskTodo.Id));
            if (updatedTaskTodo == null) return new ErrorResult("Güncellenecek Task todo bulunamadı");

            updatedTaskTodo.Content = taskTodo.Content;
            _taskTodoRepository.Update(updatedTaskTodo);
            return new SuccessResult("Güncelleme işlemi Başarılı");
        }
    }
}
