using System.Text.RegularExpressions;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Request;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio;
using proyectoShopmi.Repositorio.Interfaces;


namespace proyectoShopmi.Controllers
{
    [Route("productos/")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        // Constructor donde inyectamos IConfiguration para acceder a la cadena de conexión
        public ProductoController(IProductoRepository productoRepository, IConfiguration configuration)
        {
            _productoRepository = productoRepository;
        }

        // GET: productos/ListarProductos
        [Authorize]
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<ProductoResponse>>> ListarProductos()
        {
            var response = await _productoRepository.GetProductos();

            if (response == null)
            {
                return BadRequest("¡Error! No se encontraron productos.");
            }

            return Ok(response);
        }

        //LISTAR PRODUCTOS POR CATEGORIA
        //[Authorize]
        [HttpGet("[action]/{codCategoria}")]
        public async Task<ActionResult<IEnumerable<ProductoResponse>>> ListarPorCategoria(int codCategoria)
        {
            var response = await _productoRepository.GetProductosPorCategoria(codCategoria);

            if (response == null || !response.Any())
            {
                return NotFound("No hay productos para esta categoría.");
            }

            return Ok(response);
        }

        //BUSCAR PRODUCTO
        [HttpGet("[action]/{codProducto}")]
        public async Task<ActionResult<ProductoResponse>> ObtenerProducto(int codProducto)
        {
            var registro = await _productoRepository.GetProducto(codProducto);
            return Ok(registro);
        }

        //REGISTRAR PRODUCTOS POR CATEGORIA
        [HttpPost("[action]")]
        public async Task<ActionResult<string>> RegistrarProducto([FromForm] ProductoFormRequest productoForm)
        {
            if (productoForm == null)
                return BadRequest("¡Error! Ingresar datos válidos.");

            string? urlImagen = null;

            if (productoForm.imgProducto != null && productoForm.imgProducto.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes", "productos");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);


                var originalFileName = Path.GetFileName(productoForm.imgProducto.FileName.Trim());
                var filePath = Path.Combine(uploadsFolder, originalFileName);

                int fileIndex = 1;
                while (System.IO.File.Exists(filePath))
                {
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFileName);
                    var ext = Path.GetExtension(originalFileName);
                    var newFileName = $"{fileNameWithoutExt}_{fileIndex}{ext}";
                    filePath = Path.Combine(uploadsFolder, newFileName);
                    originalFileName = newFileName;
                    fileIndex++;
                }


                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await productoForm.imgProducto.CopyToAsync(stream);
                }


                urlImagen = originalFileName;
            }


            if (!string.IsNullOrEmpty(urlImagen))
            {
                urlImagen = Path.GetFileName(urlImagen);
            }

            var producto = new ProductoRequest
            {
                codProducto = productoForm.codProducto,
                nomProducto = productoForm.nomProducto,
                descripcion = productoForm.descripcion,
                preUni = productoForm.preUni,
                stock = productoForm.stock,
                estProducto = productoForm.estProducto,
                codCategoria = productoForm.codCategoria,
                codMarca = productoForm.codMarca,
                imgProducto = urlImagen
            };


            var mensaje = await _productoRepository.MergeProducto(producto, "inserción");

            return Ok(new { mensaje });
        }

        //REGISTRAR ACTUALIZAR POR CATEGORIA

        [HttpPut("[action]")]
        public async Task<ActionResult<string>> ActualizarProducto([FromForm] ProductoFormRequest productoForm)
        {
            if (productoForm == null)
                return BadRequest("¡Error! Ingresar datos válidos.");

            string? urlImagen = null;

            if (productoForm.imgProducto != null && productoForm.imgProducto.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes", "productos");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                var originalFileName = Path.GetFileName(productoForm.imgProducto.FileName.Trim());
                var filePath = Path.Combine(uploadsFolder, originalFileName);

                int fileIndex = 1;
                while (System.IO.File.Exists(filePath))
                {
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFileName);
                    var ext = Path.GetExtension(originalFileName);
                    var newFileName = $"{fileNameWithoutExt}_{fileIndex}{ext}";
                    filePath = Path.Combine(uploadsFolder, newFileName);
                    originalFileName = newFileName;
                    fileIndex++;
                }

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await productoForm.imgProducto.CopyToAsync(stream);
                }

                urlImagen = originalFileName;
            }


            var producto = new ProductoRequest
            {
                codProducto = productoForm.codProducto,
                nomProducto = productoForm.nomProducto,
                descripcion = productoForm.descripcion,
                preUni = productoForm.preUni,
                stock = productoForm.stock,
                estProducto = productoForm.estProducto,
                codCategoria = productoForm.codCategoria,
                codMarca = productoForm.codMarca,
                imgProducto = urlImagen ?? productoForm.imgActual
            };

            var mensaje = await _productoRepository.MergeProducto(producto, "actualización");
            return Ok(new { mensaje });
        }


        [HttpPut("CambiarEstadoProducto/{codProducto}")]
        public async Task<IActionResult> CambiarEstadoProducto(int codProducto)
        {
            // 1) traigo el producto
            var producto = await _productoRepository.GetProducto(codProducto);
            if (producto == null)
                return NotFound("Producto no encontrado.");

            // 2) llamo al repo pasando el estado actual
            var mensaje = await _productoRepository.CambiarEstadoProducto(codProducto, producto.estProducto);

            // 3) devuelvo el mensaje
            return Ok(new { mensaje });
        }


    }
}
