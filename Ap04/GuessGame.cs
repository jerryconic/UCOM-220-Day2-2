using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap04
{
    internal class GuessGame
    {
        private int _answer, _guess;

        public void Start()
        {
            Random rnd = new Random();
            _answer = rnd.Next(1, 100);
        }
        public void Guess()
        {
            string s;
            Console.Write("請輸入數字(1 ~ 99):");
            s = Console.ReadLine();
            _guess = int.Parse(s);
        }
        public bool GotAnswer()
        {
            if(_guess < _answer)
                Console.WriteLine("高一點");
            else if(_guess > _answer)
                Console.WriteLine("低一點");
            else
                Console.WriteLine("猜對了");

            return _guess == _answer;
            /*
            if (_guess == _answer)
                return true;
            else
                return false;
            */
        }
    }
}
