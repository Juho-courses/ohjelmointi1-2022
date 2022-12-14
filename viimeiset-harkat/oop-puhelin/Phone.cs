namespace oop_puhelin
{
    public class Phone
    {
        public string Model { private set; get; }
        public bool CallOnGoing { private set; get; } = false;
        public string OnCallWithNumber { private set; get; } = "";

        public Phone(string model)
        {
            Model = model;
        }

        public void Call(string number)
        {
            if (CallOnGoing)
            {
                Console.WriteLine($"Call already ongoing with {OnCallWithNumber}");
                return;
            }
            CallOnGoing = true;
            OnCallWithNumber = number;
            Console.WriteLine($"Calling number {OnCallWithNumber}");
        }

        public void EndCall()
        {
            if (!CallOnGoing)
            {
                Console.WriteLine("no call to hang up");
                return;
            }
            Console.WriteLine("Hanging up");
            CallOnGoing = false;
            OnCallWithNumber = "";
        }
    }
}
