namespace AdapterDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        string[,] employeesArray = new string[5, 4]
        {
                {"101","Kerim","SE","10000"},
                {"102","Rehman","SE","20000"},
                {"103","Selim","SSE","30000"},
                {"104","Xaliq","SE","40000"},
                {"105","Zehra","SSE","50000"}
        };

        ITarget target = new EmployeeAdapter();
        Console.WriteLine("HR sistemi employee string massivini Adaptere oturur\n");
        target.ProcessCompanySalary(employeesArray);
        Console.Read();
    }
}