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

namespace PokedexVS
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1;//guarda el id del pokemon
        bool mod = false;
        int i = 0;
        Button btns = new Button();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void izquierda_Click(object sender, EventArgs e)
        {
            if(idActual > 1 && !mod)
            {
                idActual--;
            }else if (i>0 && mod)
            {
               
                i--;
                idActual = int.Parse(misPokemons.Rows[i]["id"].ToString());
            }
            cargaDatos();
           
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            if (idActual < 151 && !mod)
            {
                idActual++;
            }else if (i <btns.TabIndex && mod)
            {
                
                i++;
                idActual = int.Parse(misPokemons.Rows[i]["id"].ToString());
            }
            cargaDatos();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargaDatos();
        }
        private void cargaDatos()
        {
            if(!mod)
            {
                i = 0;
                misPokemons = miConexion.getPokemonPorId(idActual);
                nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
                mov1.Text = misPokemons.Rows[0]["movimiento1"].ToString();
                mov2.Text = misPokemons.Rows[0]["movimiento2"].ToString();
                mov3.Text = misPokemons.Rows[0]["movimiento3"].ToString();
                mov4.Text = misPokemons.Rows[0]["movimiento4"].ToString();
                descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            }else if (mod)
            {
                
                nombrePokemon.Text = misPokemons.Rows[i]["nombre"].ToString();
                pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[i]["imagen"]);
                mov1.Text = misPokemons.Rows[i]["movimiento1"].ToString();
                mov2.Text = misPokemons.Rows[i]["movimiento2"].ToString();
                mov3.Text = misPokemons.Rows[i]["movimiento3"].ToString();
                mov4.Text = misPokemons.Rows[i]["movimiento4"].ToString();
                descripcion.Text = misPokemons.Rows[i]["descripcion"].ToString();
            }
            
        }
        private void boton_control_Click(object sender, EventArgs e)
        {
            if(boton_control.Text == "Movimientos")
            {
                pictureBox1.Visible = false;
                mov1.Visible = true;
                mov2.Visible = true;
                mov3.Visible = true;
                mov4.Visible = true;
                descripcion.Visible = false;
                boton_control.Text = "Descripcion";
            }
            else if (boton_control.Text == "Descripcion")
            {
                pictureBox1.Visible = false;
                mov1.Visible = false;
                mov2.Visible = false;
                mov3.Visible = false;
                mov4.Visible = false;
                descripcion.Visible = true;
                boton_control.Text = "Imagen";
            }
            else if(boton_control.Text == "Imagen")
            {
                pictureBox1.Visible = true;
                mov1.Visible = false;
                mov2.Visible = false;
                mov3.Visible = false;
                mov4.Visible = false;
                descripcion.Visible = false;
                boton_control.Text = "Movimientos";
            }
                
        }

        private void boton_tipo_Click(object sender, EventArgs e)
        {
            btns = (Button)sender;
            if (mod == false)
            {
                mod = true;
                misPokemons = miConexion.getPokemonPorTipo(btns.Text);
                idActual = int.Parse(misPokemons.Rows[0]["id"].ToString());
            }
            else
            {
                mod = false;
                idActual = 1;
            }
           
            cargaDatos();

        }
    }
}
