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
            /*insert this following statement checks whether the queue is empty.if the queue is empty
             * . then the value of the REAR and FRONT variabeles is set to 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /* if REAR is at the last position of the array, then the value of
                 * REAR is set to 0 that corresponde to the first position of the array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* if REAR is not at the last position , then its value is incremented by one */
                    REAR = REAR + 1;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
