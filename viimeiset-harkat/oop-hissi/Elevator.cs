namespace oop_hissi
{
    public class Elevator
    {
        public int FloorCount { private set; get; }
        public int CurrentFloor { private set; get; }
        public bool IsMoving { private set; get; } = false;

        private int target_floor;

        public Elevator(int floor_count)
        {
            FloorCount = floor_count;
            CurrentFloor = 1;
        }

        public void Move(int to_floor)
        {
            if (to_floor < 1 || to_floor > FloorCount)
            {
                Console.WriteLine($"Invalid floor! (min {1}, max {FloorCount})");
                return;
            }
            target_floor = to_floor;
            IsMoving = true;

            while (CurrentFloor != target_floor)
            {
                if (CurrentFloor > target_floor)
                {
                    CurrentFloor--;
                }
                else
                {
                    CurrentFloor++;
                }
                PrintLocation();
            }
            IsMoving = false;
            Console.WriteLine($"Target floor ({target_floor}) reached!");
        }

        public void PrintLocation()
        {
            for (int i = 1; i <= FloorCount; i++)
            {
                if (i == CurrentFloor)
                {
                    Console.Write($"[{i}] ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
