using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ITaskLabelService
    {
        IResult Add(List<int> labelIds, int taskId);

        IResult DeleteByLabelIdAndTaskId(int labelId, int taskId);
        IResult DeleteAllByLabelIdsAndTaskId(List<int> labelIds, int taskId);
        IResult DeleteByTaskLabelId(int taskLabelId);
        IResult DeleteAllByTaskLabelIds(List<int> taskLabelIds);

        IDataResult<List<TaskLabel>> GetAllByTaskId(int taskId);
        IDataResult<List<int>> GetAllIdByTaskId(int taskId);
    }
}
