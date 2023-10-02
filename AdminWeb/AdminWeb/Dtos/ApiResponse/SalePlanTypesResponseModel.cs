namespace AdminWeb.Dtos.ApiResponse
{
    public class SalePlanTypesResponseModel
    {
        public long SalePlanTypesId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Icon { get; set; }
        public string? Color { get; set; }
        public bool? IsActive { get; set; }
        public string? Unit { get; set; }
        public string? Code { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
