using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_test
{
    public class Calc
    {
        private Stack<int> numbers;

        public Calc()
        {

            numbers = new Stack<int>();
        }

        public void PutNumber(int number)
        {
            numbers.Push(number);
        }

        public int Add()
        {
            return numbers.Pop() + numbers.Pop();
        }

        public void Login(string login, string pass)
        {
            Console.WriteLine($"This is fake login you log in as user {login} with password {pass}");
        }
    }
}
