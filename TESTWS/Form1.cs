using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text;
            using (WSPersona.WSPersonaClient client = new WSPersona.WSPersonaClient())
            {
               var persona =  client.ObtenerInformacion(id);
                var nombre = persona.nombre;
                var edad = persona.edad;


            }
        }
    }
}
