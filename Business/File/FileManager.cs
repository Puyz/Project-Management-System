using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Business.File
{
    public class FileManager : IFileService
    {
        private readonly IHostEnvironment _environment;
        //private readonly IHostingEnvironment _hostingEnvironment;

        public FileManager(IHostEnvironment hostEnvironment)
        {
            _environment = hostEnvironment;
            //_hostingEnvironment = environment;
        }

        public async Task<IDataResult<FileDto>> Save(IFormFile file, string fileType)
        {
            try
            {
                if (file == null || file.Length == 0)
                    return new ErrorDataResult<FileDto>("Dosya bulunamadı");

                string folderPath = Path.Combine(_environment.ContentRootPath, "file-storage");
                string newFileName = Guid.NewGuid().ToString();
                string fileExtension = Path.GetExtension(file.FileName).ToLower();
                string fileFullName = newFileName + fileExtension;

                string filePath = "";

                if (fileType.Equals(FileType.TASK_ATTACHMENT))
                {
                    filePath = "task-attachments";
                    folderPath = Path.Combine(folderPath, filePath);
                }

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                using (var stream = new FileStream(Path.Combine(folderPath, fileFullName), FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                FileDto returnFile = new()
                {
                    Name = file.FileName,
                    FilePath = Path.Combine(filePath, fileFullName),
                };
                return new SuccessDataResult<FileDto>(returnFile);
            }
            catch (Exception)
            {
                throw;
            }

        }


        public IResult Delete(string filePath, string fileType)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) return new ErrorResult("Dosya yolu bulunamadı");

                System.IO.File.Delete(Path.Combine(_environment.ContentRootPath, "file-storage", filePath));
                return new SuccessResult();
            }
            catch (Exception)
            {
                return new ErrorResult("Dosya silinemedi");
            }
        }

        public IDataResult<string> GetFileAsBase64(string filePath)
        {
            string file = Path.Combine(_environment.ContentRootPath, "file-storage", filePath);

            if (!System.IO.File.Exists(file))
            {
                return new ErrorDataResult<string>("Dosya bulunamadı");
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(file);
            string base64String = Convert.ToBase64String(fileBytes);

            return new SuccessDataResult<string>(base64String);
        }
    }
}
