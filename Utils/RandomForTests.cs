
using Faker;

namespace Web.Utils
{
    public class RandomForTests
    {
        public static string userName = Internet.UserName();
        public static string domain = Internet.DomainWord();
        private static Random random = new Random();

        public static string GeneratePassword(int minLegth, int maxLeght, string extraChars)
        { 
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string cyrillicLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            int length = random.Next(minLegth, maxLeght);

            char[] passwordChars = new char[length];
            passwordChars[0] = uppercaseLetters[random.Next(uppercaseLetters.Length)];
            passwordChars[1] = digits[random.Next(digits.Length)];
            passwordChars[2] = cyrillicLetters[random.Next(cyrillicLetters.Length)];
            passwordChars[3] = extraChars[random.Next(extraChars.Length)];

            for (int i = 4; i < length; i++)
            {
                string possibleChars = uppercaseLetters + uppercaseLetters.ToLower() + digits + cyrillicLetters + extraChars;
                passwordChars[i] = possibleChars[random.Next(possibleChars.Length)];
            }

            passwordChars = passwordChars.OrderBy(c => random.Next()).ToArray();

            string password = new string(passwordChars);
            return password;
        }

        public static string GeneratePassword(int minLegth, int maxLeght)
        {
            string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string cyrillicLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            int length = random.Next(minLegth, maxLeght);

            char[] passwordChars = new char[length];
            passwordChars[0] = uppercaseLetters[random.Next(uppercaseLetters.Length)];
            passwordChars[1] = digits[random.Next(digits.Length)];
            passwordChars[2] = cyrillicLetters[random.Next(cyrillicLetters.Length)];

            for (int i = 4; i < length; i++)
            {
                string possibleChars = uppercaseLetters + uppercaseLetters.ToLower() + digits + cyrillicLetters;
                passwordChars[i] = possibleChars[random.Next(possibleChars.Length)];
            }

            passwordChars = passwordChars.OrderBy(c => random.Next()).ToArray();

            string password = new string(passwordChars);
            return password;
        }

        public static List<int> RandonDifferentPositiveNumbers(int CountOfNums, int MaxNum)
        {
            var randomNumbers = new List<int>();
            while (randomNumbers.Count < CountOfNums)
            {
                int num = random.Next(MaxNum + 1);
                if (!randomNumbers.Contains(num))
                {
                    randomNumbers.Add(num);
                }
            }

            return randomNumbers;
        }
        public static int RandomInt(int count)
        {
            return random.Next(count);
        }
    }
}
