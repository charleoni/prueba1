using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using prueba1.Models.Request;

namespace prueba1.Controllers
{
    public class CeldasController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Registrar(Models.Request.CeldasRequest model)
        {
            using (Models.pruebillaEntities db = new Models.pruebillaEntities())
            {
                var resul = db.celdas(model.dias,   model.celda1, model.celda2,
                                      model.celda3, model.celda4, model.celda5,
                                      model.celda6, model.celda7, model.celda8);
                db.SaveChanges();
                Rootobject oObjet = JsonConvert.DeserializeObject<Rootobject>(resul.ToList().FirstOrDefault());
                return Ok(oObjet);
            }
        }

    }
}
