namespace oop3
{
    public class Person
    {
        public string FirstName { private set; get; }
        public int Age { private set; get; }
        public Address Address { private set; get; }

        public Person(string fname, int age)
        {
            FirstName = fname;
            Age = age;
        }

        public void SetAddress(string street, int no)
        {
            Address = new Address(street, no);
        }

        public int MakeOlder()
        {
            Age++;
            return Age;
        }
    }
}
