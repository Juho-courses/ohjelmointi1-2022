namespace oop1
{
    public class Car
    {
        public String Manufacturer { private set; get; }
        public int Miles { private set; get; }

        public Car(string _manu)
        {
            Manufacturer = _manu;
            Miles = 0;
        }

        public void Drive(int miles)
        {
            Miles += miles;
        }
    }
}
