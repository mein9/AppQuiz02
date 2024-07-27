namespace AppQuiz02;


class Program
{
    static void Main(string[] args)
    {
        // Create two Car objects using different constructors
        Car car1 = new Car("1HGCM82633A123456", "Honda", "Accord", 50000);
        Car car2 = new Car("1FTFW1ET4EKF12345", "Ford", "F-150");

        // Drive the cars for different number of miles
        car1.Drive(150);
        car2.Drive(300);

        // Display the details of each car
        car1.Display();
        car2.Display();
    }
}