using System.Text.RegularExpressions;

namespace CoR
{
    public class Program
    {
        public abstract class ValidationHandler
        {
            protected ValidationHandler nextHandler;
            public void SetNext(ValidationHandler handler)
            {
                nextHandler = handler;
            }
            public abstract bool Validate(string input);
        }
        public class NonEmptyValidator : ValidationHandler
        {
            public override bool Validate(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Fields Should Not Be Empty.");
                    return false;
                }
                return nextHandler?.Validate(input) ?? true;
            }
        }
        public class DateFormatValidator : ValidationHandler
        {
            public override bool Validate(string input)
            {
                if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    Console.WriteLine("Invalid Date Format. Date should be in the format dd/MM/yyyy.");
                    return false;
                }
                return nextHandler?.Validate(input) ?? true;
            }
        }
        public class FutureDateValidator : ValidationHandler
        {
            public override bool Validate(string input)
            {
                if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    return false; // Không thể phân tích ngày
                }
                if (date.Date < DateTime.Today)
                {
                    Console.WriteLine("Date should be in the past.");
                    return false;
                }
                return nextHandler?.Validate(input) ?? true;
            }
        }
        static void Main(string[] args)
        {
            var nonEmptyValidator = new NonEmptyValidator();
            var dateFormatValidator = new DateFormatValidator();
            var futureDateValidator = new FutureDateValidator();

            nonEmptyValidator.SetNext(dateFormatValidator);
            dateFormatValidator.SetNext(futureDateValidator);

            string inputDate = "29/05/2026";
            bool isValid = nonEmptyValidator.Validate(inputDate);
            if (isValid)
            {
                Console.WriteLine("Date is valid.");
            }
            else
            {
                Console.WriteLine("Date is invalid.");
            }
        }
    }
}