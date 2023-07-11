namespace OLBootcampConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region დავალება 1

            //1) დაწერეთ შემდეგი პროგრამა:
            //კონსოლიდან შეიყვანეთ იუზერის სახელი და პაროლი. თუ დაემთხვა თქვენს მიერ შექმნილ
            //იუზერს და პაროლს, კონსოლზე დაიბეჭდოს წარმატება. 5 ცდის შემდეგ კი დააბრუნოს
            //შეცდომის შეტყობინება.

            try
            {
                int attempts = 5;
                while (attempts > 0)
                {
                    Console.Write("Please enter the username: ");
                    string enteredUsername = Console.ReadLine();
                    Console.WriteLine("-----------------------------------");

                    Console.Write("Please enter the password: ");
                    string enteredPassword = Console.ReadLine();
                    Console.WriteLine("-----------------------------------");

                    if (UserInfoIsValid(enteredUsername, enteredPassword))
                    {
                        Console.WriteLine("SUCCESS");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("INCORRECT INFORMATION");
                    }
                    Console.WriteLine("-----------------------------------");
                    attempts--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion


            #region დავალება 2
            //2) დაწერეთ პროგრამა, რომელიც კონსოლიდან შეყვანილ რიცხვს გადაიყვანს ორობით ფორმატში.შედეგი დაბეჭდეთ კონსოლზე.

            try
            {
                Console.WriteLine(ConvertToBinary(125));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion


            #region დაავალება 3
            //3) შექმენით ორი გადატვირთული მეთოდი. პირველი მეთოდი უნდა ითვლიდეს ფართობს(სიგრძე * სიგანეზე),
            //  მეორე მეთოდი მოცულობას(სიგრძე * სიგანე * სიმაღლე).გადაეცით მეთოდებს შესაბამისი რაოდენობის პარამეტრები.

            try
            {
                Console.WriteLine(CountArea(10, 20));
                Console.WriteLine(CountArea(10, 20, 30));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion
        }



        /// <summary>
        /// მესამე დავალება. მეთოდი რომელიც ითვლის ფართობს
        /// </summary>
        /// <param name="length">სიგრძე</param>
        /// <param name="width">სიგანsე</param>
        /// <param name="height">სიმაღლე</param>
        /// <returns>სიგრძის სიგანის და სიმაღლის ნამრავლს</returns>
        static int CountArea(int length, int width, int height) => length * width * height;

        /// <summary>
        /// მესამე დავალება მეთოდი რომელიც ითვლის ფართობს
        /// </summary>
        /// <param name="length">შემოყვანილი სიგრძე</param>
        /// <param name="width">შემოყვანილი სიგანე</param>
        /// <returns>სიგრძი და სიგანის ნამრავლს</returns>
        static int CountArea(int length, int width) => length * width;

        /// <summary>
        /// მეორე დავალება. მეთოდი რომელიც შემოყანილ რიცხვს გარდაქმნის Binary-თ
        /// </summary>
        /// <param name="argument">შემოყვანილი რიცხვი</param>
        /// <returns>შედეგს binary-ში</returns>
        static string ConvertToBinary(int argument) => Convert.ToString(argument, 2);

        /// <summary>
        /// პირველი დავალება მომხმარებლის პაროლის და სახელის შემოწმება
        /// </summary>
        /// <param name="username">შემოყვანილი სახელი</param>
        /// <param name="password">შემოყვანილი პაროლი</param>
        /// <returns>bool მნიშვნელობას</returns>
        static bool UserInfoIsValid(string username, string password)
        {
            string myUsername = "myUser";
            string myPassword = "myPassword";

            return username == myUsername && password == myPassword;
        }
    }
}