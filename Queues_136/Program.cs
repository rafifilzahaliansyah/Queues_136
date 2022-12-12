using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_136
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queu_array = new int[5];

        public Program()
        {
            /*initializing the value of the variable REAR and FRONT to -1 to indicate that
             * the queue to initially empty.*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /*this statement check for the overflow  conditions. */
            if((FRONT == 0 && REAR == max -1 ) || (FRONT == REAR +1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
