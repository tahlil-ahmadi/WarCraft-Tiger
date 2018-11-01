using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagment.Application.Contracts
{
    public class StringConstraintValueDto : ConstraintValueDto
    {
        public int MaxLength { get; set; }
    }
}
