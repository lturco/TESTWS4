using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersona : IService1
    {
        Persona IService1.ObtenerInformacion(string Identificacion)
        {
            if (Identificacion == "0")
            {

                return new Persona() { nombre = "Lucas", edad = 24 };
            }
            else {

                return new Persona() { error = "no se puede" };
            }
        }
    }
}
