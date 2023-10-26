using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ILabelService
    {
        IResult Add(Label label);
        IResult Delete(int labelId);
        IResult Update(Label label);
        IDataResult<List<Label>> GetAll();
    }
}
