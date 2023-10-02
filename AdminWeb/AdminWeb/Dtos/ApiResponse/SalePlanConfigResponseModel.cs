namespace AdminWeb.Dtos.ApiResponse
{
    public class SalePlanConfigResponseModel
    {
        public long SalePlanConfigId { get; set; }
        public string? PositionCode { get; set; }
        public long? AllowCreateDay { get; set; }
        public long? AllowEditDay { get; set; }
        public int? PlanType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }

}
