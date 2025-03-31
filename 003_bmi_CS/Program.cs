namespace _003_bmi_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height;

            Console.Write("키키 (cm) : ");
            height = double.Parse(Console.ReadLine());

            Console.Write("체중 (kg) : ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height / 100 * height / 100);

            Console.WriteLine("BMI = " + bmi);
        }
    }
}