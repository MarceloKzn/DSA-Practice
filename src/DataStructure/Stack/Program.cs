namespace DataStructure
{
    internal class StackImplementation
    {
        public class Plate
        {
            public int top;
            public Plate? next;

            public Plate(int selTop, Plate? nextPlate)
            {
                top = selTop;
                next = nextPlate;
            }
        }

        static void Main(string[] args)
        {
            // Inicialization here    
        }



        public class Stack
        {
            private Plate? topPlate; 
            public Stack() 
            { 
                topPlate = null;
            }
            public void Push(int value) 
            { 
                topPlate = new Plate(value, topPlate); 
            }
            public int Pop()
            {
                if (topPlate == null)
                {
                    throw new InvalidOperationException("Stack is empty"); 
                }

                int value = topPlate.top;
                topPlate = topPlate.next; 
                return value;
            }

        }
    }
}