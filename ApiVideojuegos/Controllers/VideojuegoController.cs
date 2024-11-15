using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Conector;

namespace ApiVideojuegos.Controllers
{
    public class VideojuegoController : ApiController
    {
        // GET: api/Videojuego
        public IEnumerable<Videojuego> Get()
        {
            using (TiendaJuegosEntities objEntidad = new TiendaJuegosEntities())
            {
                return objEntidad.Videojuego.ToList();
            }
        }


        // GET: api/Videojuego/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Videojuego
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Videojuego/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Videojuego/5
        public void Delete(int id)
        {
        }
    }
}
