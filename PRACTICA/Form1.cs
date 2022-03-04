using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA
{
    public partial class Form1 : Form
    {
        //Se declaran los vectores para almacenar autor, nombre del libro, ubicacion y cantidad de libros
        string[] N_libro = new string[8];
        string[] autor = new string[8];
        string[] ubicacion = new string[8];
        int[] cantidad = new int[8];

        public Form1()
        {
            //Ingresamos la informacion respectiva a cada vector y se crea un random parala cantidad de libros
            N_libro[0] = "cumbres borrascosas";
            N_libro[1] = "crimen y castigo";
            N_libro[2] = "almas muertas";
            N_libro[3] = "el castillo";
            N_libro[4] = "hamlet";
            N_libro[5] = "cien años de soledad";
            N_libro[6] = "don quijote de la mancha";
            N_libro[7] = "el principito";

            autor[0] = "emily bronte";
            autor[1] = "fiódor dostoievski";
            autor[2] = "nikolai gogol";
            autor[3] = "frank kafka";
            autor[4] = "william shakespeare";
            autor[5] = "gabriel garcia marquez";
            autor[6] = "miguel de cervantes";
            autor[7] = "antoine de saint-exupery";


            ubicacion[0] = "Novelas, C1";
            ubicacion[1] = "Relatos cortos, B10";
            ubicacion[2] = "Poemas, F7";
            ubicacion[3] = "Relatos cortos, D4";
            ubicacion[4] = "Dramaturcos, G10";
            ubicacion[5] = "Dramaturcos, A8";
            ubicacion[6] = "Novelas, H5";
            ubicacion[7] = "Realismo Magico, C9";

            //Se crea Random
            Random cant = new Random();
            for (int i = 0; i < 8; i++)
            {
                cantidad[i] = Convert.ToInt32(cant.Next(30));
            }



            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // se crea un InputBox para ingresar la busqueda por autor 
            string buscar1 = (Microsoft.VisualBasic.Interaction.InputBox("Ingresar Nombre del Autor"));

            // El ciclo for se crea para recorrer c/u delos elementos del vector "autor", e indicamos donde 
            // vamos a ver el resultado de las busqueda en c/u de los textbox
            for (int i = 0; i < autor.Length; i++)
            {
                if (autor[i] == buscar1)
                {
                    txtautor1.Text = autor[i];
                    txtubicacion.Text = ubicacion[i];
                    txtlibro1.Text = N_libro[i];
                    txtdisponible.Text = cantidad[i].ToString();
                    i = N_libro.Length + 5;


                }
                // Estacondicion es para mostrar un messagebox si la busqueda no es exitosa
                else if (i==7)
                {
                    MessageBox.Show("En estos momentos no se encuentra el libro", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // En este boton hacemos lo mismo que el botton anterior, solo cambia el vector que se recorre
            string buscar2 = (Microsoft.VisualBasic.Interaction.InputBox("Ingresar Nombre del Libro")); 
           
            

            for (int i = 0; i < N_libro.Length; i++)
            {
                if (N_libro[i] == buscar2)
                {
                    txtautor1.Text = autor[i];
                    txtubicacion.Text = ubicacion[i];
                    txtlibro1.Text = N_libro[i];
                    txtdisponible.Text = cantidad[i].ToString();
                    i = N_libro.Length + 5;


                }
                else if (i == 7)
                {
                    MessageBox.Show("En estos momentos no se encuentra el libro", "Ups", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // En este boton "nueva busqueda" limpiamos todos los textbox para realizar una nueva busqueda
            
            txtautor1.Clear();
            txtdisponible.Clear();
            txtlibro1.Clear();
            txtubicacion.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Este proceso es para salir de la aplicacion
            Close();
        }

        private void txtautor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
