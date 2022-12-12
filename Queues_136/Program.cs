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
            /* once the position of REAR is determined, the element os added at its proper place. */
            queu_array[REAR] = element;
        }
        public void remove()
        {
            /* checks wheather the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue Underflow\n");
                return;
            }
            Console.WriteLine("\nThe Element deleted from the queue is : " + queu_array[FRONT]
                + "\n");
            /*check if the queue has one element. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /* if the elements to be deleted is at the last position of the array, then the value
                 * of FRONT is set to 0 1.e to the first elements of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /* Checks if the queue is empty. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is Empty \n");
                return;
            }
            Console.WriteLine("\nElements in the queue are ................\n");
            if(FRONT_position <= REAR_position)
            {
                /* traverses the queue till the last element present in an array. */
                while(FRONT_position <= REAR_position)
                {
                    Console.Write(queu_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* Traverses the queue till the last position of the array. */
                while(FRONT_position <=max -1)
                {
                    Console.Write(queu_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                /*set the front position to the first element of the array. */
                FRONT_position = 0;
                /* Traverse the array till the last elements present in the queue. */
                while(FRONT_position <= REAR_position)
                {
                    Console.Write(queu_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine(" 1. Implement insert operation ");
                    Console.WriteLine(" 2. Implement delete operation");
                    Console.WriteLine(" 3. Display Value ");
                    Console.WriteLine(" 4. Exit ");
                    Console.Write("\nEnter Your choice (1-4) :  ");
                    ch = Convert.ToChar(Console.Read());
                    Console.WriteLine();
                    switch(ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number : ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(num);
                            }
                            break;
                        case '2':
                            {
                                queue.remove();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option !!");
                            }
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
