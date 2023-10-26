using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IWorkspaceTypeService
    {
        IResult Add(WorkspaceType workspaceType);
        IResult Delete(int workspaceTypeId);
        IResult Update(WorkspaceType workspaceType);
        IDataResult<List<WorkspaceType>> GetAll();
        IDataResult<WorkspaceType> GetById(int workspaceTypeId);
    }
}
