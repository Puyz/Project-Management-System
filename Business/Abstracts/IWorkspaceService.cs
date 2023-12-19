using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.Dtos.Workspace;

namespace Business.Abstracts
{
    public interface IWorkspaceService
    {
        IResult Add(Workspace workspace);
        IResult Delete(int workspaceId);
        IResult Update(Workspace workspace);
        IDataResult<List<Workspace>> GetAllByUserId(int userId);
        IDataResult<WorkspaceViewDto> GetById(int workspaceId);

    }
}
