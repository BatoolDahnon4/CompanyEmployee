namespace CompEmplyee.interfaces
{
    public interface IEmployeeRepo
    {
        List<Employee> Get();
        Employee GetId(int id);
        Employee Addemployee(Employee employee);
        Employee updateEmployee(Employee request);
        Employee Delete(int id);

    }
    public class employeeRepo : IEmployeeRepo
    {

        private List<Employee> employees = new List<Employee>()
            {
                 new Employee{Id=1,  Name="maha",Age=11,CompanyId=1},

                new Employee{Id=2,  Name="Jana",Age=20,CompanyId = 2,},

            };

        public List<Employee> Get()
        {
            return employees;
        }
        public Employee GetId(int Id)
        {
            return employees.FirstOrDefault(f => f.Id == Id);
        }

        public Employee Addemployee(Employee employee)
        { 
            employees.Add(employee);
            return  employee;

        }

        public Employee Delete(int id)
        {
            var employee = employees.Find(x => x.Id == id);
            employees.Remove(employee);
            return employee;
        }
   

        public Employee updateEmployee(Employee request)
        {
            var employee = employees.Find(p => p.Id == request.Id);

            employee.Id = request.Id;
            employee.Name = request.Name;
            employee.Age = request.Age;
            employee.CompanyId = request.CompanyId;
            return employee;

        }

    }
}