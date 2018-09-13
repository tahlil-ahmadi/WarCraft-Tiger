namespace UOM.Domain.Model
{
   public  class InvalidInputException : System.Exception
    {
        public const string InvalidInputExceptionMessageFormatString = @"فیلد {0} نامعتبر می باشد";
        public InvalidInputException(string propertyName) : base(string.Format(InvalidInputExceptionMessageFormatString, propertyName))
        {

        }
    }
}
