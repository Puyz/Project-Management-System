using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class LabelManager : ILabelService
    {
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
