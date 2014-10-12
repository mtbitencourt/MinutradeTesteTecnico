using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Core.Model;
using Core.Service;
using MinutradeService.Service;
using System.Web.Http.Cors;

namespace MinutradeService.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ClientesController : ApiController
    {
        private IService<Cliente> service = new MinutradeClienteService();

        // GET: api/Clientes
        public IEnumerable<Cliente> GetClientes()
        {
            return service.GetAll();
        }

        // GET: api/Clientes/5
        [ResponseType(typeof(Cliente))]
        public IHttpActionResult GetCliente(int id)
        {
            var cliente = service.Get(id);

            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // PUT: api/Clientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCliente(int id, Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cliente.Id)
            {
                return BadRequest();
            }

            try
            {
                service.Save(id, cliente);
            }
            catch (Exception)
            {
                return NotFound();

            }

            return StatusCode(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}