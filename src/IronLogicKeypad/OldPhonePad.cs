using System;
using System.Text;
using System.Collections.Generic;

namespace IronLogicKeyPad
{

    public static class OldphonePadTranslator
    {
        private static readonly Dictionary<char, string> keyMap = new Dictionary<char, string>
    {
        { '1', "&'(" },
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" },
        { '0', " " },
    };

        public static String OldPhonePad(string input)
        {

            StringBuilder resultBuilder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                // SEND --> #
                if (currentChar == '#')
                {
                    break;
                }

                // DELETE --> * 
                if (currentChar == '*')
                {
                    if (resultBuilder.Length > 0)
                    {
                        resultBuilder.Length--;
                    }
                    continue;
                }

                // SPACE --> 0 
                if (currentChar == ' ')
                {
                    continue;
                }

                // PULSES 
                int pressCount = 1;
                while (i + 1 < input.Length && input[i + 1] == currentChar)
                {
                    pressCount++;
                    i++;
                }

                // CONVERTING LETTERS 
                if (keyMap.ContainsKey(currentChar))
                {
                    string charactersOnKey = keyMap[currentChar];
                    int charIndex = (pressCount - 1) ;

                    resultBuilder.Append(charactersOnKey[charIndex]);
                }
            }


            return resultBuilder.ToString();
        }
    }
}

