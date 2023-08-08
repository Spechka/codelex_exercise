using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_8
{
    internal class Program
    {
        static string[] words = { "apple", "banana", "orange", "grape", "mango", "pear", "cherry", "kiwi", "melon", "peach" };
        static Random random = new Random();

        static string ChooseWord()
        {
            return words[random.Next(words.Length)];
        }

        static string DisplayWord(string word, HashSet<char> guessedLetters)
        {
            string display = "";
            foreach (char letter in word)
            {
                if (guessedLetters.Contains(letter))
                    display += letter;
                else
                    display += "_";
            }
            return display;
        }

        static void DisplayGuessedLetters(HashSet<char> guessedLetters)
        {
            if (guessedLetters.Count > 0)
            {
                Console.Write("Guessed letters: ");
                foreach (char letter in guessedLetters)
                {
                    Console.Write(letter + " ");
                }
                Console.WriteLine();
            }
        }

        static char GetGuess(HashSet<char> guessedLetters)
        {
            char guess;
            do
            {
                Console.Write("Enter a letter: ");
                guess = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("You already guessed this letter. Try another one.");
                }
                else
                {
                    break;
                }
            } while (true);

            return guess;
        }

        static void PlayGame()
        {
            string wordToGuess = ChooseWord();
            HashSet<char> guessedLetters = new HashSet<char>();
            int maxAttempts = 6;

            Console.WriteLine("Welcome to the Word Guessing Game (similar to Hangman)!");
            Console.WriteLine("You have {0} attempts to guess the word.", maxAttempts);

            while (maxAttempts > 0)
            {
                Console.WriteLine("\n" + DisplayWord(wordToGuess, guessedLetters));
                DisplayGuessedLetters(guessedLetters);

                Console.Write("Enter a letter: ");

                char guess = GetGuess(guessedLetters);

                guessedLetters.Add(guess);

                if (wordToGuess.Contains(guess))
                    Console.WriteLine("Good guess!");
                else
                {
                    Console.WriteLine("Incorrect guess.");
                    maxAttempts--;
                }

                if (wordToGuess.All(guessedLetters.Contains))
                {
                    Console.WriteLine("\nCongratulations! You guessed the word: {0}", wordToGuess);
                    break;
                }
            }

            if (maxAttempts == 0)
                Console.WriteLine("\nGame over! The word was: {0}", wordToGuess);
        }

        static void Main()
        {
            PlayGame();
        }
    }
}
