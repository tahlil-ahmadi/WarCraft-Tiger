﻿namespace ProductManagment.Domain.Model.GenericProducts.ConstraintValues
{
    public class Range
    {
        public long? Min { get; private set; }
        public long? Max { get; private set; }
        public Range(long? min, long? max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool IsValid(long value)
        {
            var max = this.Max ?? long.MaxValue;
            var min = this.Min ?? long.MinValue;

            return value >= min && value <= max;
        }
    }
}
