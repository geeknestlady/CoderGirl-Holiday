using System;


namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is the date you are leaving for vacation?");
            DateTime vacationDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("How many days will you be gone on vacation?");
            int vacationLength = Convert.ToInt32(Console.ReadLine());
            string returning = DayReturning(vacationDate, vacationLength);
            Console.WriteLine($"You are returning on: {returning}");

            Console.ReadLine();
        }
        public static string DayReturning(DateTime vacationDate, int vacationLength)
        {
            DateTime vacationReturnDate = vacationDate.AddDays(vacationLength);
            //string returningDate = vacationReturnDate.ToLongDateString();
            return vacationReturnDate.DayOfWeek.ToString();           

            
        }
        // TODO: Create a method that takes the day you are leaving on vacation and how many days you will be gone and return the name of the day of the week you will return.
    }
}
