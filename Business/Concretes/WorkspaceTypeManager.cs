using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class WorkspaceTypeManager : IWorkspaceTypeService
    {
        private readonly IWorkspaceTypeRepository _workspaceTypeRepository;
        public WorkspaceTypeManager(IWorkspaceTypeRepository workspaceTypeRepository) 
        {
            _workspaceTypeRepository = workspaceTypeRepository;
        }
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
