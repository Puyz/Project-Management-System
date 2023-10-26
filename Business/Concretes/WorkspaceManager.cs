using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class WorkspaceManager : IWorkspaceService
    {
        private readonly IWorkspaceRepository _workspaceRepository;
        public WorkspaceManager(IWorkspaceRepository workspaceRepository) 
        {
            _workspaceRepository = workspaceRepository;
        }
        public IResult Add(Workspace workspace)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int workspaceId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Workspace>> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Workspace workspace)
        {
            throw new NotImplementedException();
        }
    }
}
