namespace fileUploadApi.SharedKernel.Entities
{
    public class fileTypeControl
    {
        public int baseId { get; set; }
        public string? fileType { get; set; }
        public string? fileTypeAcceptableExtensions { get; set; }
        public string? maxFileSizeToLetSaveInDb { get; set; }
    }
}