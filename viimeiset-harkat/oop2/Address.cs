namespace oop2
{
    public class Address
    {
        public string Street { private set; get; }

        public int Number { private set; get; }

        public Address(string street, int number)
        {
            Street = street;
            Number = number;
        }

        public void ChangeAddress(string st, int no)
        {
            Street = st;
            Number = no;
        }

        public void Print()
        {
            Console.WriteLine(Street + ", " + Number);
        }
    }
}
