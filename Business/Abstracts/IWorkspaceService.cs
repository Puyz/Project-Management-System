using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IWorkspaceService
    {
        IResult Add(Workspace workspace);
        IResult Delete(int workspaceId);
        IResult Update(Workspace workspace);
        IDataResult<List<Workspace>> GetAllByUserId(int userId);

    }
}
