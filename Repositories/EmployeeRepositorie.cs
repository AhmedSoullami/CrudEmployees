using GestionDesEmployees.Models;

namespace GestionDesEmployees.Repositories
{
    public class EmployeeRepositorie : IEmployes
    { 

        private readonly ApplicationDbContext _context;
        public EmployeeRepositorie(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            
        }

        public void DeleteEmployee(int idEmployee)
        {
           var employee= _context.Employees.Find(idEmployee);
            _context.Employees.Remove(employee);
            _context.SaveChanges(); 
           
        }
        
        public Employee Detail(int idEmployee)
        {
            var employee = _context.Employees.Find(idEmployee);
            return employee;
            
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList() ;
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
