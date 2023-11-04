using Core.Utilities.Results.Abstracts;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Business.File
{
    public interface IFileService
    {
        Task<IDataResult<FileDto>> Save(IFormFile file, string fileType);
        IResult Delete(string filePath, string fileType);
        IDataResult<string> GetFileAsBase64(string filePath);
    }
}
