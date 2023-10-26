using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class WorkspaceTypeManager : IWorkspaceTypeService
    {
        public IResult Add(WorkspaceType workspaceType)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int workspaceTypeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<WorkspaceType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<WorkspaceType> GetById(int workspaceTypeId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(WorkspaceType workspaceType)
        {
            throw new NotImplementedException();
        }
    }
}
