using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IEmpleado
    {
        Task<IEnumerable<Empleado>> GetEmpleados();
        Task<Empleado> GetEmpleado(int codEmp);
        Task<string> MergeEmpleado(Empleado empleado);
        Task<string> DeleteEmpleado(int codEmp);
    }
}
