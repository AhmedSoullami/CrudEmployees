using GestionDesEmployees.Models;

namespace GestionDesEmployees.Repositories
{
    public interface IEmployes
    {
        List<Employee>GetEmployees();
        void AddEmployee(Employee employee);
        void DeleteEmployee(int idEmployee);
        void UpdateEmployee(Employee employee);
        Employee Detail(int idEmployee);

    }
}
