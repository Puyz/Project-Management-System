using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class WorkspaceManager : IWorkspaceService
    {
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
