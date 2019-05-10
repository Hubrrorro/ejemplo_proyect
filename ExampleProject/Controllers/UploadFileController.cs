using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.IO;
using net.sf.mpxj.reader;
using net.sf.mpxj.mpp;
using net.sf.mpxj;

namespace ExampleProject.Controllers
{
    public class UploadFileController : ApiController
    {
        public IHttpActionResult Post()
        {
            Resultado resul = null;
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                    docfiles.Add(filePath);
                    UploadFileBussines bUpload = new UploadFileBussines();
                    resul= bUpload.Revision(filePath);
                    if (!resul.resultado)
                    {
                        bUpload.EliminarArchivo(filePath);
                        return Json(resul);
                    }
                    bUpload.LeerProject(filePath);

                }
            }
            else
            {
                resul = new Resultado() {
                     resultado= false
                };
                resul.mensajes.Add("No contiene archivos");
                
            }
            return Json(resul);
        }

    }
    public class UploadFileBussines
    {
        public void EliminarArchivo(string archivo)
        {
            FileInfo informacion = new FileInfo(archivo);
            if (informacion.Exists)
            {
                informacion.Delete();
            }
        }
        public Resultado Revision(string archivo)
        {
            Resultado resul = new Resultado() { resultado = true };
            FileInfo informacion = new FileInfo(archivo);
            if (!informacion.Exists)
            {
                resul.resultado = false;
                resul.mensajes.Add("No se guardo correctamente el archivo");
                return resul;
            }
            if (!informacion.Extension.Equals(".mpp"))
            {
                resul.resultado = false;
                resul.mensajes.Add("La extensión no es valida");
                return resul;
            }
            return resul;
        }
        public void LeerProject(string ruta)
        {
            ProjectReader reader = new MPPReader();
            ProjectFile projectObj = reader.read(ruta);
            foreach (Task task in projectObj.Tasks)
            {

            }
        }
    }
}
