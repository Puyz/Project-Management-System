using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
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
            throw new NotImplementedException();
        }

        public IResult Delete(int labelId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Label>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Label label)
        {
            throw new NotImplementedException();
        }
    }
}
