using System.Collections.Generic;

namespace ProductManagment.Application.Contracts
{
    public class CreateGenericProductCommand
    {
        public string Title { get; set; }
        public List<ConstraintValueDto> ConstraintValues { get; set; }
    }
}