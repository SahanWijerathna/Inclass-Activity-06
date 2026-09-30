namespace Activity06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("       ROBOT PROTOTYPE SYSTEM");
            Console.WriteLine("======================================");
            Console.WriteLine();


            // Create original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot(
                "SR-100",
                10,
                "v1.0",
                "Patient Assistance");

            Console.WriteLine("Original Service Robot");
            serviceRobot.Display();

            Console.WriteLine();


            // Clone Service Robot
            ServiceRobot serviceRobotClone =
                (ServiceRobot)serviceRobot.Clone();

            // Customize the cloned robot
            serviceRobotClone.BatteryCapacity = 15;
            serviceRobotClone.SoftwareVersion = "v1.1";

            Console.WriteLine("Cloned and Customized Service Robot");
            serviceRobotClone.Display();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();


            // Create original Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot(
                "IR-200",
                20,
                "v2.0",
                "Welding");

            Console.WriteLine("Original Industrial Robot");
            industrialRobot.Display();

            Console.WriteLine();


            // Clone Industrial Robot
            IndustrialRobot industrialRobotClone =
                (IndustrialRobot)industrialRobot.Clone();

            // Customize the cloned robot
            industrialRobotClone.BatteryCapacity = 25;
            industrialRobotClone.SoftwareVersion = "v2.1";

            Console.WriteLine("Cloned and Customized Industrial Robot");
            industrialRobotClone.Display();

            Console.WriteLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();


            // Create original Entertainment Robot
            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot(
                    "ER-300",
                    8,
                    "v3.0",
                    "Dancing and Talking");

            Console.WriteLine("Original Entertainment Robot");
            entertainmentRobot.Display();

            Console.WriteLine();


            // Clone Entertainment Robot
            EntertainmentRobot entertainmentRobotClone =
                (EntertainmentRobot)entertainmentRobot.Clone();

            // Customize the cloned robot
            entertainmentRobotClone.BatteryCapacity = 12;
            entertainmentRobotClone.SoftwareVersion = "v3.1";

            Console.WriteLine("Cloned and Customized Entertainment Robot");
            entertainmentRobotClone.Display();

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("Prototype cloning completed successfully.");
            Console.WriteLine("======================================");

            Console.ReadKey();
        }
    }
}