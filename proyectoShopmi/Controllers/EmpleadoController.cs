using Microsoft.AspNetCore.Mvc;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.DAO;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        // GET: api/<EmpleadoController>
        [HttpGet("getEmpleados")]
        public async Task<ActionResult<IEnumerable<Empleado>>> ListarEmpleados()
        {
            var listado = await Task.Run(() => new EmpleadoDAO().GetEmpleados());
            return Ok(listado);
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{codEmp}")]
        public async Task<ActionResult<Empleado>> BuscarEmpleado(int codEmp)
        {
            var registro = await Task.Run(() => new EmpleadoDAO().GetEmpleado(codEmp));
            return Ok(registro);
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public async Task<ActionResult<string>> RegistrarEmpleado([FromBody] Empleado empleado)
        {
            var mensaje = await Task.Run(() => new EmpleadoDAO().MergeEmpleado(empleado));
            return Ok(mensaje);
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{codEmp}")]
        public async Task<ActionResult<string>> ActualizarEmpleado([FromBody] Empleado empleado)
        {
            var mensaje = await Task.Run(() => new EmpleadoDAO().MergeEmpleado(empleado));
            return Ok(mensaje);
        }

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{codEmp}")]
        public async Task<ActionResult<string>> EliminarEmpleado(int codEmp)
        {
            var mensaje = await Task.Run(() => new EmpleadoDAO().DeleteEmpleado(codEmp));
            return Ok(mensaje);
        }
    }
}
