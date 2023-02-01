using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Models;
using WindowsEFEscuela.Dac;

namespace WindowsFormsEFEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                Nombre = txtNombre.Text,
                Apellido = "Castro",
                FechaNacimiento= new DateTime (2003, 12, 21),
                ProfesorId= 1
            };
            
            int filasAfectadas = AbmAlumno.Insert(alumno);
            if(filasAfectadas> 0 )
            {
                MessageBox.Show("Alumno insertado");
                MostrarAlumnos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = "Castro",
                FechaNacimiento = new DateTime(2003, 11, 11),
                ProfesorId = 1
            };

            int filasAfectadas = AbmAlumno.Update(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarAlumnos();

            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int IdAlumno = Convert.ToInt32(txtId.Text);

            Alumno alumno = AbmAlumno.SelectWhereById(IdAlumno);
            MessageBox.Show(alumno.Nombre);

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Alumno alumno = new Alumno()
            {   IdAlumno= Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = "Castro",
                FechaNacimiento = new DateTime(2003, 11, 11),
                ProfesorId = 1
            };


            int filasAfectadas = AbmAlumno.Delete(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarAlumnos();

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        //Metodo

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        private void MostrarAlumnos()
        {
            GridAlumno.DataSource = AbmAlumno.SelectAll();
        }

      
    }
}

    
   

