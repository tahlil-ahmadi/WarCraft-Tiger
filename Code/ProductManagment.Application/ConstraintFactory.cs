using System.Collections.Generic;
using ProductManagment.Application.Contracts;
using ProductManagment.Domain.Model.Products.GenericProducts.ConstraintValues;

namespace ProductManagment.Application
{
    public class ConstraintFactory
    {
        public static List<ConstraintValue> CreateFromDto(List<ConstraintValueDto> commandConstraintValues)
        {
            var output = new List<ConstraintValue>();
            foreach (var commandConstraintValue in commandConstraintValues)
            {
                var constraintValue = Map((dynamic)commandConstraintValue);
                output.Add(constraintValue);
            }
            return output;
        }

        public static NumericRangeConstraintValue Map(NumericConstraintValueDto dto)
        {
            return new NumericRangeConstraintValue(dto.ConstraintId, dto.Min, dto.Max);
        }
        public static StringConstraintValue Map(StringConstraintValueDto dto)
        {
            return new StringConstraintValue(dto.ConstraintId,dto.MaxLength);
        }
    }
}