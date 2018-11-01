namespace ProductManagment.Application.Contracts
{
    public class NumericConstraintValueDto : ConstraintValueDto
    {
        public int? Min { get; set; }
        public int? Max { get; set; }
    }
}