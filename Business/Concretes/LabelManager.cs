using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class LabelManager : ILabelService
    {
        private readonly ILabelRepository _labelRepository;
        public LabelManager(ILabelRepository labelRepository) {
            _labelRepository = labelRepository;
        }
        public IResult Add(Label label)
        {
            _labelRepository.Add(label);
            return new SuccessResult("Etiket eklendi.");
        }

        public IResult Delete(int labelId)
        {
            var result = _labelRepository.Get(l => l.Id.Equals(labelId));
            if (result == null) return new ErrorResult("Silinecek etiket bulunamadı.");
            _labelRepository.Delete(result);
            return new SuccessResult("Etiket silindi.");
        }

        public IDataResult<List<Label>> GetAll()
        {
            var result = _labelRepository.GetAll();
            return new SuccessDataResult<List<Label>>(result);
        }

        public IResult Update(Label label)
        {
            var result = _labelRepository.Get(l => l.Id.Equals(label.Id));
            if (result == null) return new ErrorResult("Güncellenecek etiket bulunamadı.");

            result.Name = label.Name;
            result.Color = label.Color;
            _labelRepository.Update(result);
            return new SuccessResult("Etiket güncellendi.");
        }
    }
}
