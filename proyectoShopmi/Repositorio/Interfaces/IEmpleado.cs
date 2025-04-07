using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Interfaces
{
    public interface IEmpleado
    {
        IEnumerable<Empleado> getEmpleados();
        Empleado getEmpleado(int id);
        string insertEmpleado(Empleado empleado);
        string updateEmpleado(Empleado empleado);
    }
}
