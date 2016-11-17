using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            Stack<string> textEditor = new Stack<string>();
            int inputCount = int.Parse(Console.ReadLine());
            StringBuilder currentText = new StringBuilder();
            for (int i = 0; i < inputCount; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                switch (inputArgs[0])
                {
                    case "1":
                        currentText.Append(inputArgs[1]);
                        textEditor.Push(currentText.ToString());
                        break;
                    case "2":
                        int countOfLettersToErase = int.Parse(inputArgs[1]);
                        string currentTextString = currentText.ToString().Substring(0, currentText.Length - countOfLettersToErase);
                        currentText.Clear();
                        currentText.Append(currentTextString);
                        textEditor.Push(currentText.ToString());
                        break;
                    case "3":
                        int indexOfElementPosition = int.Parse(inputArgs[1]);
                        Console.WriteLine(currentText.ToString().ElementAt(indexOfElementPosition - 1));
                        break;
                    case "4":
                        if (textEditor.Count>0)
                        {
                            textEditor.Pop();
                            currentText.Clear();
                            currentText.Append(textEditor.Peek());
                        }
                        break;

                }
            }
        }
    }
}
