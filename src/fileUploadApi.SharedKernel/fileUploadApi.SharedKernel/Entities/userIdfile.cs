namespace fileUploadApi.SharedKernel.Entities
{
    public class userIdfile : BaseEntity
    {
        public int fileTypeId { get; set; }
        public string? filename { get; set; }
        public string? fileTypeExtension { get; set; }
        public string? updatedFileName { get; set; }
        public string? filePath { get; set; }
        public string? fileDataBS64 { get; set; }
    }
}