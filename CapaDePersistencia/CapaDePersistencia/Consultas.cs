using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePersistencia
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) {
                var qConsulta = from pel in objDB.peliculas
                                from alq in objDB.alquileres
                                from soc in objDB.socios
                                where soc.idSocio == alq.socio
                                orderby soc.nombre ascending
                                select new
                                {
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2
                                };
                dgvResul.DataSource = qConsulta.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                var qConsulta = from pel in objDB.peliculas
                                from alq in objDB.alquileres
                                from soc in objDB.socios
                                where soc.idSocio == alq.socio && alq.fechaDevolucion.Equals(null)
                                orderby soc.nombre ascending
                                select new
                                {
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2
                                };
                dgvResul.DataSource = qConsulta.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                var subConsulta = from alq in objDB.alquileres select alq.socio;
                var qConsulta = from soc in objDB.socios
                                where !subConsulta.Contains(soc.idSocio)
                                orderby soc.nombre ascending
                                select new
                                {
                                    soc.nombre,
                                    soc.apell1,
                                    soc.apell2
                                };
                dgvResul.DataSource = qConsulta.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                var consultaAlqSociosAgrupada = from alq in objDB.alquileres
                                                group alq by alq.socio into grupo
                                                select new
                                                {
                                                    IdSocio = grupo.Key,
                                                    NumVeces = grupo.Count()
                                                };
                var maxValor = consultaAlqSociosAgrupada.Max(x => x.NumVeces);
                var subConsultaSociosMasCantidad = consultaAlqSociosAgrupada.Where(x => x.NumVeces == maxValor);


                var qConsulta = from socmascant in subConsultaSociosMasCantidad.ToList()
                                from soc in objDB.socios
                                where socmascant.IdSocio == soc.idSocio
                                select new { soc.nombre, soc.apell1, soc.apell2, socmascant.NumVeces 
                                };
                dgvResul.DataSource = qConsulta.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                var consultaAlqPelisAgrupada = from pelis in objDB.alquileres
                                               group pelis by pelis.pelicula into grupo
                                               select new
                                               {
                                                   codPelicula = grupo.Key,
                                                   numVecesAlquilada = grupo.Count()
                                               };
                var maxPelicula = consultaAlqPelisAgrupada.Max(x => x.numVecesAlquilada);
                var subconsultaPelisMasVeces = consultaAlqPelisAgrupada.Where(x => x.numVecesAlquilada == maxPelicula);

                var qConsulta = from maximasPelis in subconsultaPelisMasVeces.ToList()
                                from pelis in objDB.peliculas
                                where maximasPelis.codPelicula == pelis.codpeli
                                select new
                                {
                                    pelis.titulo,
                                    maximasPelis.numVecesAlquilada
                                };
                dgvResul.DataSource = qConsulta.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                var consultaEstilosAgrupada = from pelis in objDB.peliculas
                                              group pelis by pelis.estilo into grupo
                                              select new
                                              {
                                                    idEstilo = grupo.Key,
                                                    numVeces = grupo.Count()
                                              };
                var maxEstilo = consultaEstilosAgrupada.Max(x => x.numVeces);
                var consulta6 = consultaEstilosAgrupada.Where(x => x.numVeces == maxEstilo);

                dgvResul.DataSource = consulta6.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities()) {
                var consultaPelis = from pel in objDB.peliculas
                                    select new { pel.titulo, pel.anio, pel.estilo, pel.categoria };
                var minValor = consultaPelis.Min(x => x.anio);
                var consulta7 = consultaPelis.Where(x => x.anio == minValor);

                dgvResul.DataSource = consulta7.Distinct().ToList();
                dgvResul.Refresh();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (videoclubBinarioEntities objDB = new videoclubBinarioEntities())
            {
                
            }
        }
    }
}
