using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
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
            _workspaceTypeRepository.Add(workspaceType);
            return new SuccessResult("Çalışma alanı türü eklendi.");
        }

        public IResult Delete(int workspaceTypeId)
        {
            var result = _workspaceTypeRepository.Get(wt => wt.Id.Equals(workspaceTypeId));
            if (result == null) return new ErrorResult("Silinmek istenen çalışma alanı türü bulunamadı.");
            _workspaceTypeRepository.Delete(result);
            return new SuccessResult("Çalışma alanı türü silindi.");
        }

        public IDataResult<List<WorkspaceType>> GetAll()
        {
            var result = _workspaceTypeRepository.GetAll();
            return new SuccessDataResult<List<WorkspaceType>>(result);
        }

        public IDataResult<WorkspaceType> GetById(int workspaceTypeId)
        {
            var result = _workspaceTypeRepository.Get(wt => wt.Id.Equals(workspaceTypeId));
            return (result == null) ? new ErrorDataResult<WorkspaceType>("Çalışma alanı bulunamadı.") 
                : new SuccessDataResult<WorkspaceType>(result);
        }

        public IResult Update(WorkspaceType workspaceType)
        {
            var result = _workspaceTypeRepository.Get(wt => wt.Id.Equals(workspaceType.Id));
            if (result == null) return new ErrorResult("Güncellemek istenen çalışma alanı türü bulunamadı.");

            result.Name = workspaceType.Name;
            _workspaceTypeRepository.Update(result);
            return new SuccessResult("Çalışma alanı türü güncellendi.");
        }
    }
}
