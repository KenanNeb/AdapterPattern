namespace AdapterDesignPattern;

public class ThirdPartyBillingSystem
{
    //ThirdPartyBillingSystem hər bir işçinin maaşını emal etmək üçün işçilərin məlumatları List kimi saxlayir
    public void ProcessSalary(List<Employee> listEmployee)
    {
        foreach (Employee employee in listEmployee)
        {
            Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
        }
    }
}