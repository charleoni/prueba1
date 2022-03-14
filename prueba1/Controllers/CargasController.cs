using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace prueba1.Controllers
{
    public class CargasController : ApiController
    {
        [HttpPost]
        public IHttpActionResult calculo(Models.Request.CargaRequest model)
        {
            int[] valores = new int[5] { model.carga1, model.carga2, model.carga3, model.carga4, model.carga5};
            int[,] matriz = new int[5, 5];
            var cargaOptima = model.tamanoCamion;
            var fila = 0;
            var columna = 0;

            if (cargaOptima > 30)
            {
                cargaOptima = model.tamanoCamion - 30;
            }

            for (int x = 0; x < valores.GetLength(0); x += 1) { 
                for (int y = 0; y < valores.GetLength(0); y += 1) {
                    if (x == y)
                    {
                        matriz[x, y] = 0;
                    }
                    else
                    {
                        matriz[x, y] = valores[x] + valores[y];
                    }
                } 
            }

            for (int x = 0; x < matriz.GetLength(0); x += 1)
            {
                for (int y = 0; y < matriz.GetLength(1); y += 1)
                {
                    if (cargaOptima == matriz[x,y] )
                    {
                        fila = x;
                        columna = y;
                    }
                }
            }

            string resul = "["+valores[fila]+","+valores[columna]+"]";

            //var json = JsonConvert.SerializeObject(matriz);
            return Ok(resul);

            
        }
    }
}
