using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NavegadorWeb
{
    public partial class Form1 : Form

    {
        List<Direccion> direcciones = new List<Direccion>();
        HistorialPersistencia persistencia = new HistorialPersistencia();

        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            InicializarWebView();

        }

        private void CargarHistorial()
        {
            direcciones = persistencia.Leer();

            comboBoxDireccion.Items.Clear();

            foreach (var direccion in direcciones)
            {
                comboBoxDireccion.Items.Add(direccion.Url);
            }
        }


        //private void Guardar(string nombreArchivo)
        //{

        // FileStream stream = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
        //StreamWriter writer = new StreamWriter(stream);
        //foreach (var direccion in direcciones)
        //{
        //writer.WriteLine(direccion.Url);
        // writer.WriteLine(direccion.Veces);
        // writer.WriteLine(direccion.FechaAccesso);
        //}

        // writer.Close();
        // }
        //private void Leer()
        //{
            //string nombreArchivo = @"historial.txt";

            //if (!File.Exists(nombreArchivo))
               // return;

            //FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            //StreamReader reader = new StreamReader(stream);

            //while (reader.Peek() > -1)
            //{
               // Direccion direccion = new Direccion();

               // direccion.Url = reader.ReadLine();
               // direccion.Veces = int.Parse(reader.ReadLine());
                //direccion.FechaAccesso = DateTime.Parse(reader.ReadLine());

                //direcciones.Add(direccion);
               // comboBoxDireccion.Items.Add(direccion.Url);
           // }

            //reader.Close();
        //}

        private void Form_Resize(object sender, EventArgs e)
        {
            webView2.Size = this.ClientSize - new System.Drawing.Size(webView2.Location);
            buttonIr.Left = this.ClientSize.Width - buttonIr.Width;
            comboBoxDireccion.Width = buttonIr.Left - comboBoxDireccion.Left;
        }
        private void buttonIr_Click(object sender, EventArgs e)
        {
            string Url = comboBoxDireccion.Text;

            if (!Url.Contains("https://") && !Url.Contains("http://"))
            {
                Url = "https://" + Url;
            }

            if (webView2 != null && webView2.CoreWebView2 != null)
            {
                webView2.CoreWebView2.Navigate(Url);

                Direccion existente = direcciones.Find(d => d.Url == Url);

                if (existente != null)
                {
                    existente.Veces++;
                    existente.FechaAccesso = DateTime.Now;
                }
                else
                {
                    Direccion nueva = new Direccion();
                    nueva.Url = Url;
                    nueva.Veces = 1;
                    nueva.FechaAccesso = DateTime.Now;

                    direcciones.Add(nueva);
                    comboBoxDireccion.Items.Add(Url);
                }

                persistencia.Guardar(direcciones);
            }


        }
        private async void InicializarWebView()
        {
            await webView2.EnsureCoreWebView2Async(null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarHistorial();
            this.Load += Form1_Load;
            //Leer();
        }
    }
}
