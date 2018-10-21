using System;
namespace dev2
{
    class Translit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text : ");
            string inputString = Console.ReadLine();
            string outputString = "";
            //translates string to lower case
            string inputStrLow = inputString.ToLower();
            //translates into code
            byte[] b = System.Text.Encoding.Default.GetBytes(inputStrLow);
            int englishCounter = 0;
            int russianCounter = 0;
            bool english = false;
            bool russian = false;
            //checks what language is entered
            foreach (byte bt in b)
            {
                if (((bt >= 97) && (bt <= 122)) || ((bt >= 65) && (bt <= 90)))
                {
                    englishCounter++;
                }
                    
                if ((bt >= 192) && (bt <= 255))
                {
                    russianCounter++;
                }

               
            }
            if (englishCounter > 0 && russianCounter == 0)
            {
                english = true;
                Console.Write("Your language is english\n");
            }
            if (russianCounter > 0 && englishCounter == 0)
            {
                russian = true;
                Console.Write("Your language is russian\n");
            }
            if (russianCounter > 0 && englishCounter > 0)
            {
                Console.Write("Mixed language. Translite is impossible.\n");
            }
            if (russianCounter == 0 && englishCounter == 0)
            {
                Console.Write("Unknown language. Translite is impossible.\n");
            }
            //makes translit of russian text
            if (russian == true)
            {
                Console.Write("Translit text : ");
                for (int i = 0; i < inputString.Length; i++)
                {
                    switch (inputString[i])
                    {
                        case 'а': outputString = String.Concat(outputString, "a"); break;
                        case 'б': outputString = String.Concat(outputString, "b"); break;
                        case 'в': outputString = String.Concat(outputString, "v"); break;
                        case 'г': outputString = String.Concat(outputString, "g"); break;
                        case 'д': outputString = String.Concat(outputString, "d"); break;
                        case 'е': outputString = String.Concat(outputString, "e"); break;
                        case 'ё': outputString = String.Concat(outputString, "yo"); break;
                        case 'ж': outputString = String.Concat(outputString, "zh"); break;
                        case 'з': outputString = String.Concat(outputString, "z"); break;
                        case 'и': outputString = String.Concat(outputString, "i"); break;
                        case 'й': outputString = String.Concat(outputString, "y"); break;
                        case 'к': outputString = String.Concat(outputString, "k"); break;
                        case 'л': outputString = String.Concat(outputString, "l"); break;
                        case 'м': outputString = String.Concat(outputString, "m"); break;
                        case 'н': outputString = String.Concat(outputString, "n"); break;
                        case 'о': outputString = String.Concat(outputString, "o"); break;
                        case 'п': outputString = String.Concat(outputString, "p"); break;
                        case 'р': outputString = String.Concat(outputString, "r"); break;
                        case 'с': outputString = String.Concat(outputString, "s"); break;
                        case 'т': outputString = String.Concat(outputString, "t"); break;
                        case 'у': outputString = String.Concat(outputString, "u"); break;
                        case 'ф': outputString = String.Concat(outputString, "f"); break;
                        case 'х': outputString = String.Concat(outputString, "kh"); break;
                        case 'ц': outputString = String.Concat(outputString, "c"); break;
                        case 'ч': outputString = String.Concat(outputString, "ch"); break;
                        case 'ш': outputString = String.Concat(outputString, "sh"); break;
                        case 'щ': outputString = String.Concat(outputString, "sch"); break;
                        case 'ъ': break;
                        case 'ы': outputString = String.Concat(outputString, "y"); break;
                        case 'ь': break;
                        case 'э': outputString = String.Concat(outputString, "e"); break;
                        case 'ю': outputString = String.Concat(outputString, "yu"); break;
                        case 'я': outputString = String.Concat(outputString, "ya"); break;
                        case 'А': outputString = String.Concat(outputString, "A"); break;
                        case 'Б': outputString = String.Concat(outputString, "B"); break;
                        case 'В': outputString = String.Concat(outputString, "V"); break;
                        case 'Г': outputString = String.Concat(outputString, "G"); break;
                        case 'Д': outputString = String.Concat(outputString, "D"); break;
                        case 'Е': outputString = String.Concat(outputString, "E"); break;
                        case 'Ё': outputString = String.Concat(outputString, "Yo"); break;
                        case 'Ж': outputString = String.Concat(outputString, "Zh"); break;
                        case 'З': outputString = String.Concat(outputString, "Z"); break;
                        case 'И': outputString = String.Concat(outputString, "I"); break;
                        case 'Й': outputString = String.Concat(outputString, "Y"); break;
                        case 'К': outputString = String.Concat(outputString, "K"); break;
                        case 'Л': outputString = String.Concat(outputString, "L"); break;
                        case 'М': outputString = String.Concat(outputString, "M"); break;
                        case 'Н': outputString = String.Concat(outputString, "N"); break;
                        case 'О': outputString = String.Concat(outputString, "O"); break;
                        case 'П': outputString = String.Concat(outputString, "P"); break;
                        case 'Р': outputString = String.Concat(outputString, "R"); break;
                        case 'С': outputString = String.Concat(outputString, "S"); break;
                        case 'Т': outputString = String.Concat(outputString, "T"); break;
                        case 'У': outputString = String.Concat(outputString, "U"); break;
                        case 'Ф': outputString = String.Concat(outputString, "F"); break;
                        case 'Х': outputString = String.Concat(outputString, "Kh"); break;
                        case 'Ц': outputString = String.Concat(outputString, "C"); break;
                        case 'Ч': outputString = String.Concat(outputString, "Ch"); break;
                        case 'Ш': outputString = String.Concat(outputString, "Sh"); break;
                        case 'Щ': outputString = String.Concat(outputString, "Sch"); break;
                        case 'Ъ': break;
                        case 'Ы': outputString = String.Concat(outputString, "Y"); break;
                        case 'Ь': break;
                        case 'Э': outputString = String.Concat(outputString, "E"); break;
                        case 'Ю': outputString = String.Concat(outputString, "Yu"); break;
                        case 'Я': outputString = String.Concat(outputString, "Ya"); break;
                        default: outputString = String.Concat(outputString, inputString[i]); break;
                    }
                }
            }
            //makes translit of english text
            if (english == true)
            {
                Console.Write("Translit text : ");
                for (int i = 0; i < inputString.Length; i++)
                {
                    switch (inputString[i])
                    {
                        case 'a': outputString = String.Concat(outputString, "а"); break;
                        case 'b': outputString = String.Concat(outputString, "б"); break;
                        case 'c': outputString = String.Concat(outputString, "ц"); break;
                        case 'd': outputString = String.Concat(outputString, "д"); break;
                        case 'e': outputString = String.Concat(outputString, "е"); break;
                        case 'f': outputString = String.Concat(outputString, "ф"); break;
                        case 'g': outputString = String.Concat(outputString, "г"); break;
                        case 'h': outputString = String.Concat(outputString, "х"); break;
                        case 'i': outputString = String.Concat(outputString, "и"); break;
                        case 'j': outputString = String.Concat(outputString, "й"); break;
                        case 'k': outputString = String.Concat(outputString, "к"); break;
                        case 'l': outputString = String.Concat(outputString, "л"); break;
                        case 'm': outputString = String.Concat(outputString, "м"); break;
                        case 'n': outputString = String.Concat(outputString, "н"); break;
                        case 'o': outputString = String.Concat(outputString, "о"); break;
                        case 'p': outputString = String.Concat(outputString, "п"); break;
                        case 'q': outputString = String.Concat(outputString, "я"); break;
                        case 'r': outputString = String.Concat(outputString, "р"); break;
                        case 's': outputString = String.Concat(outputString, "с"); break;
                        case 't': outputString = String.Concat(outputString, "т"); break;
                        case 'u': outputString = String.Concat(outputString, "у"); break;
                        case 'v': outputString = String.Concat(outputString, "в"); break;
                        case 'w': outputString = String.Concat(outputString, "ш"); break;
                        case 'x': outputString = String.Concat(outputString, "х"); break;
                        case 'y': outputString = String.Concat(outputString, "ы"); break;
                        case 'z': outputString = String.Concat(outputString, "з"); break;
                        case 'A': outputString = String.Concat(outputString, "А"); break;
                        case 'B': outputString = String.Concat(outputString, "Б"); break;
                        case 'C': outputString = String.Concat(outputString, "Ц"); break;
                        case 'D': outputString = String.Concat(outputString, "Д"); break;
                        case 'E': outputString = String.Concat(outputString, "Е"); break;
                        case 'F': outputString = String.Concat(outputString, "Ф"); break;
                        case 'G': outputString = String.Concat(outputString, "Г"); break;
                        case 'H': outputString = String.Concat(outputString, "Х"); break;
                        case 'I': outputString = String.Concat(outputString, "И"); break;
                        case 'J': outputString = String.Concat(outputString, "Й"); break;
                        case 'K': outputString = String.Concat(outputString, "К"); break;
                        case 'L': outputString = String.Concat(outputString, "Л"); break;
                        case 'M': outputString = String.Concat(outputString, "М"); break;
                        case 'N': outputString = String.Concat(outputString, "Н"); break;
                        case 'O': outputString = String.Concat(outputString, "О"); break;
                        case 'P': outputString = String.Concat(outputString, "П"); break;
                        case 'Q': outputString = String.Concat(outputString, "Я"); break;
                        case 'R': outputString = String.Concat(outputString, "Р"); break;
                        case 'S': outputString = String.Concat(outputString, "С"); break;
                        case 'T': outputString = String.Concat(outputString, "Т"); break;
                        case 'U': outputString = String.Concat(outputString, "У"); break;
                        case 'V': outputString = String.Concat(outputString, "В"); break;
                        case 'W': outputString = String.Concat(outputString, "Ш"); break;
                        case 'X': outputString = String.Concat(outputString, "Х"); break;
                        case 'Y': outputString = String.Concat(outputString, "Ы"); break;
                        case 'Z': outputString = String.Concat(outputString, "З"); break;
                        default: outputString = String.Concat(outputString, inputString[i]); break;
                    }
                }
            }
            //displays the result of translit
            Console.WriteLine(outputString);
            Console.ReadKey();
        }
    }
}