using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePersistencia
{
    public partial class ConsultasCombinadasForm : Form
    {
        public ConsultasCombinadasForm()
        {
            InitializeComponent();
            carcarCombos();
        }

        private void carcarCombos()
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) {
                var qCategorias = from c in objDB.categorias
                                  orderby c.categoria ascending
                                  select c;
                foreach (var cat in qCategorias) {
                    cbCategoria.Items.Add(cat.categoria);
                }
                var qEstilos = from e in objDB.estilos
                               orderby e.estilo ascending
                               select e;
                foreach (var est in qEstilos) { 
                    cbEstilo.Items.Add(est.estilo); 
                }
            }
                
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) { 
                var qConsulta = from pel in objDB.peliculas
                                from alq in objDB.alquileres
                                from soc in objDB.socios
                                where pel.codpeli == alq.pelicula && soc.idSocio==alq.socio
                                orderby alq.fechaAlquiler descending
                                select new {pel.titulo, pel.anio, pel.director, pel.estilo, pel.categoria,
                                alq.fechaAlquiler, soc.apell1, soc.nombre};
                if (!etxtTitulo.Text.Trim().Equals(""))
                {
                    qConsulta = qConsulta.Where(x => x.titulo.ToUpper().StartsWith(etxtTitulo.Text.ToUpper()));
                }

                if (!etxtAnio.Text.Trim().Equals("")) { 
                    int anio = Int32.Parse(etxtAnio.Text.Trim());
                    qConsulta = qConsulta.Where(x => x.anio >= anio);
                }

                
            }

                
        }
    }
}
