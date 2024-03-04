﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRepaso1
{
    public partial class Form1 : Form
    {
        //Crear Empleados
        List<Empleado> empleados = new List<Empleado>();
        List<Asistencia> asistencias = new List<Asistencia>();
        List<Reporte> reportes = new List<Reporte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            MostrarEmpledos();
            CargarAsistencia();
            MostrarAsistencia();


        }
        public void CargarEmpleados()
        {

            //Leer el archivo y cargar  a la lista
            //Guardamos en una variable el nombre del archivo que abrimos
            string fileName = "Empleado.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                //Leer los datos de un empleado
                Empleado empleado = new Empleado();
                empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.SueldoHora = Convert.ToDecimal(reader.ReadLine());

                //Guardar el empleado a la lista de enpleados 
                empleados.Add(empleado);
            }
            reader.Close();

        }
        public void MostrarEmpledos()
        {

            //Mostrar la lista de mepleados en el Gridview
            dataGridViewEmpleado.DataSource = null;
            dataGridViewEmpleado.DataSource = empleados;
            dataGridViewEmpleado.Refresh();

        }

        public void CargarAsistencia()
        {
            //Leer el archivo y cargar  a la lista
            //Guardamos en una variable el nombre del archivo que abrimos
            string fileName = "Asistencia.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)

            {
                //Leer los datos de un empleado
                Asistencia asistencia = new Asistencia();
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.HoraMes  = Convert.ToInt16(reader.ReadLine());
                asistencia.Mes = Convert.ToInt16(reader.ReadLine());

                //Guardar el empleado a la lista de enpleados 
                asistencias.Add(asistencia);
            }
            reader.Close();

        }

        public void MostrarAsistencia()
        {

            //Mostrar la lista de mepleados en el Gridview
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
            dataGridViewAsistencia.Refresh();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSueldo_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in empleados)
            {
              //  int noEmpleado = empleado.NoEmpleado;
                foreach ( Asistencia  asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        Reporte reporte = new Reporte();
                        reporte.NombreEmpleado = empleado.Nombre;
                        reporte.Mes = asistencia.Mes;
                        reporte.SieldoMensual = empleado.SueldoHora * asistencia.HoraMes;

                        reportes.Add(reporte);
                    }
                }
            }

            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();
        }
    }
}
    

