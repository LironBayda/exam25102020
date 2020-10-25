using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2510
{
    class WordGame : Game,Display
    {
        private string[] _words= { "pool", "dog", "animal", "cat", "house" };
        private string _wordToGeuss;
        private string _wordToPrint;
        private int _numOfTurn;

        private Random _gen = new Random();

        public WordGame()
        {
            Initi();
        }
        public void EndGame()
        {
            WinDisplay();
            Initi();

        
        }
        private string Get_wordToPrint()
        {
            string str = "";
            for (int i = 0; i < _wordToGeuss.Length; i++)
            {
                   str= str.Insert(0,"-");
            }

            return str;


        }
        public void Initi()
        {
            int num = _gen.Next(0,_words.Length-1);
            _wordToGeuss = _words[num];
            _wordToPrint = Get_wordToPrint();
            _numOfTurn = 0;
            PlayDisplay();


        }

        public bool IsWinning()
        {
            return _wordToGeuss == _wordToPrint;        }

        public void PlayDisplay()
        {
            Console.WriteLine(_wordToPrint);
        }


        private char  GetLetter()
        {
            Console.WriteLine("enter letter");
            char letter;
            Char.TryParse( Console.ReadLine(),out  letter);
            return letter;
        }
        private void reveal(char letter)
        {
            for (int i = 0; i < _wordToGeuss.Length; i++)
            { 
               if(_wordToGeuss[i]==letter)
                {
                    Console.WriteLine("press enter to anther game");

                    _wordToPrint = _wordToPrint.Insert(i, Convert.ToString(letter));
                    _wordToPrint = _wordToPrint.Remove(i+1,1);

                }
            }

        
        }
        public void Turn()
        {
            _numOfTurn++;
            char letter = GetLetter();
            reveal(letter);
            PlayDisplay();
            if(IsWinning())
            {
                EndGame();

            }
        }

        public void WinDisplay()
        {
            Console.WriteLine($"it takas {_numOfTurn} turns");
            Console.WriteLine("press enter to anther game");
            Console.ReadLine();


        }
    }
}
