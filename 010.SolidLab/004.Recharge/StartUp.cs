//SOLID - lab, Task 004
//28.08.2025, 15:59

namespace Recharge;

public class StartUp
{
    static void Main()
    {
        Worker worker = new Worker("Pesho");

        Robot robot = new Robot("Ksiomii", 200);

        worker.Work(8);
        worker.Sleep();

        robot.Work(12);
        robot.Work(88);
        robot.Recharge();
    }
}
