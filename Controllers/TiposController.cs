using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Palancia.Models;
using Palancia.Models.Request;

namespace Palancia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposController : ControllerBase
    {
        private readonly PalanciaContext _db;
        public TiposController(PalanciaContext db)
        {
            this._db = db;
        }

        /// <summary>
        /// Obtenemos todos los tipos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Poblaciones> Get([FromQuery] PoblacionFilter request)
        {

            return this._db.Poblaciones.AsNoTracking().Where(pob => pob.Nombre.ToLower().Contains(request.nombre.ToLower())).Include( x => x.IdProvinciaNavigation).Include( x2 => x2.CodigoPostal ).ToList();
        }
    }
}