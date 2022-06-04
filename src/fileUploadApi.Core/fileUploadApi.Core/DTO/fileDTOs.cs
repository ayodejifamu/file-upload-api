namespace fileUploadApi.Core.DTO
{
    public class fileDTOs
    {

    }

    public class uploadFileDTO
    {
        public string? fileName { get; set; }
        public string? fileTypeExtension { get; set; }
    }

    public class uploadFileDTOResponse : baseDTOResponse
    {
        public string? fileIdReference { get; set; }
    }
}