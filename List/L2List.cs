using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace risovalka.List
{
    public class L2List
    {


        private L2Node first;
        private L2Node last;
        public int Length { get; private set; }

        public L2List()
        {
            first = null;
            last = null;
            Length = 0;
        }

        public L2List(Bitmap a)
        {
            first = new L2Node(a);
            last = first;
            Length = 1;
        }



        public Bitmap this[int index]
        {
            get
            {
                if (index == Length - 1)
                {
                    return last.Value;
                }
                else if (index == 0)
                {
                    return first.Value;
                }
                else if (index < 0 || index > Length - 1)
                {
                   // throw new IndexOutOfRangeException();
                }
                else if (index <= Length / 2)
                {
                    L2Node current = first;

                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    return current.Value;
                }
                else
                {
                    L2Node current = last;

                    for (int i = 0; i < Length - 1 - index; i++)
                    {
                        current = current.Previous;
                    }

                    return current.Value;
                }



            }

            set
            {
                if (index == Length - 1)
                {
                    last.Value = value;
                }
                else if (index == 0)
                {
                    first.Value = value; // 5-9 изменение по индексу
                }
                else if (index < 0 || index > Length - 1)
                {
                }
                else if (index <= Length / 2)
                {
                    L2Node current = first;

                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }

                    current.Value = value;
                }
                else
                {
                    L2Node current = last;

                    for (int i = 0; i < Length - 1 - index; i++)
                    {
                        current = current.Previous;
                    }

                    current.Value = value;
                }
            }
        }

        public void Add(Bitmap a)
        {
            if (first == null)
            {
                first = new L2Node(a);
                last = first;
                Length = 1;
            }
            else
            {
                last.Next = new L2Node(a);
                last.Next.Previous = last;
                last = last.Next;
                Length++;
            }

        }



        public void AddToStart(Bitmap a)
        {
            if (first != null)
            {
                first.Previous = new L2Node(a);
                first.Previous.Next = first;
                first = first.Previous;
                Length++;
            }
            else
            {
                first = new L2Node(a);
                last = first;
                Length = 1;
            }
        }







        public void Remove()
        {
            if (first == last)
            {
                first = null;
                last = null;
                Length = 0;
            }
            else if (first == null)
            {

            }
            else
            {
                last.Previous.Next = null;
                last = last.Previous;
                Length--;
            }
        }

        public void Remove(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.Remove();
            }
        }

        public void RemoveFromStart()
        {
            if (first == last)
            {
                first = null;
                last = null;
                Length = 0;
            }
            else if (first == null)
            {

            }
            else
            {
                first = first.Next;
                first.Previous = null;
                Length--;
            }
        }

        public void RemoveFromStart(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.RemoveFromStart();
            }
        }

        public void Insert(Bitmap item, int index)
        {
            if (index == 0)
            {
                AddToStart(item);
            }

            else if (index < 0 || index > Length)
            {
            }
            else if (index == Length)
            {
                this.Add(item);
            }
            else if (index <= Length / 2)
            {
                L2Node tmp = new L2Node(item);
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                tmp.Next = previous.Next;
                previous.Next.Previous = tmp;
                previous.Next = tmp;
                tmp.Previous = tmp;

                Length++;
            }
            else
            {
                L2Node tmp = new L2Node(item);
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }
                tmp.Next = previous.Next;
                previous.Next.Previous = tmp;
                previous.Next = tmp;
                tmp.Previous = tmp;

                Length++;
            }

        }



        public void RemoveOfIndex(int index)
        {
            if (index == 0)
            {
                this.RemoveFromStart();

            }
            else if (index < 0 || index > Length - 1)
            {
            }
            else if (index == Length - 1)
            {
                this.Remove();
            }
            else if (index <= Length / 2)
            {
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }

                previous.Next = previous.Next.Next;
                previous.Next.Previous = previous;
                Length--;
            }
            else
            {
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }

                previous.Next = previous.Next.Next;
                previous.Next.Previous = previous;
                Length--;
            }
        }

        public void RemoveOfIndex(int index, int quantity)
        {

            if (index == 0)
            {
                this.RemoveFromStart(quantity);

            }
            else if (index < 0 || index > Length - 1)
            {
            }
            else if (index == Length - quantity)
            {
                this.Remove(quantity);
            }
            else if (index <= Length / 2)
            {
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                L2Node next = previous;
                for (int i = 0; i <= quantity; i++)
                {
                    next = next.Next;
                }
                previous.Next = next;
                next.Previous = previous;
                Length -= quantity;
            }
            else
            {
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }
                L2Node next = previous;
                for (int i = 0; i <= quantity; i++)
                {
                    next = next.Next;
                }
                previous.Next = next;
                next.Previous = previous;
                Length -= quantity;
            }
        }





        public void Reverse()
        {
            L2Node current = first;
            L2Node tmp = first;
            first = last;
            last = current;

            while (current != null)
            {
                tmp = current.Next;
                current.Next = current.Previous;
                current.Previous = tmp;
                current = tmp;
            }

        }
        public void InsertAndCut(Bitmap item, int index)
        {
            if (index == 0)
            {
                AddToStart(item);
            }

            else if (index < 0 || index > Length)
            {
            }
            else if (index == Length)
            {
                this.Add(item);
            }
            else if (index <= Length / 2)
            {
                L2Node tmp = new L2Node(item);
                L2Node previous = first;

                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                tmp.Next = null;

                previous.Next = tmp;
                tmp.Previous = previous;
                last = tmp;

                Length = index + 1;
            }
            else
            {
                L2Node tmp = new L2Node(item);
                L2Node previous = last;

                for (int i = 0; i < Length - index; i++)
                {
                    previous = previous.Previous;
                }
                tmp.Next = null;

                previous.Next = tmp;
                tmp.Previous = previous;
                last = tmp;

                Length = index + 1;

            }

        }
    }
}