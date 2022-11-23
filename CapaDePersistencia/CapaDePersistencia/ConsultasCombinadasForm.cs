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

                if (!etxtAnio.Text.Trim().Equals(""))
                {
                    try {
                        int anio = int.Parse(etxtAnio.Text.Trim());
                        qConsulta = qConsulta.Where(x => x.anio >= anio);
                    } catch (Exception) { }                    
                }
                if (!etxtNombre.Text.Trim().Equals("")) {
                    qConsulta = qConsulta.Where(x => x.nombre.ToUpper().StartsWith(etxtTitulo.Text.ToUpper()));
                }
                if (!cbEstilo.Text.Trim().Equals("")) { 
                    qConsulta = qConsulta.Where(x => x.estilo.ToUpper().StartsWith(cbEstilo.Text.ToUpper()));
                }
                if (!cbCategoria.Text.Trim().Equals(""))
                {
                    qConsulta = qConsulta.Where(x => x.categoria.ToUpper().StartsWith(cbCategoria.Text.ToUpper()));
                }

                //Para ocultar columnas:
                //dgvPeliculas.Columns[0].Visible = false;
                //dgvPeliculas.Columns[1].Visible = false;
                //dgvPeliculas.Columns[2].Visible = false;
                //dgvPeliculas.Columns[3].Visible = false;
                //dgvPeliculas.Columns[4].Visible = false;
                //dgvPeliculas.Columns[5].Visible = false;
                //dgvPeliculas.Columns[6].Visible = false;
                //dgvPeliculas.Columns[7].Visible = false;

                //Para cambiar el titulo:
                //dgvPeliculas.Columns[7].HeaderText = "Lo Que sea";
            }

                
        }
    }
}
