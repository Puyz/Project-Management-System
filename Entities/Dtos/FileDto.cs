using Core.Entities.Abstracts;

namespace Entities.Dtos
{
    public class FileDto : IDto
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
