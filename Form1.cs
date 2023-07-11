using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica_7_BackPropagation
{
    public partial class Backpropagation : Form
    {
        int entradatabla;
        int[] Neurxcapa;
        double Aprender, Error;
        int Capas;
        List<double[]> entradas = new List<double[]>();
        List<double[]> salidas = new List<double[]>();
        public Backpropagation()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            entradatabla = int.Parse(tBCapas.Text);
            //Tabla de capas
            Neurxcapa = new int[entradatabla];
            GridCapOcu.RowCount = entradatabla;
            GridCapOcu.ColumnCount = 2;
            GridCapOcu.Columns[0].HeaderText = "Capas Ocultas";
            GridCapOcu.Columns[1].HeaderText = "Neuronas";
            for (int C = 0; C < entradatabla; C++)
            {
                GridCapOcu.Rows[C].Cells[0].Value = 1+C;
               //  lBsalida.Items.Add(capas[s]);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            GridResultado.Columns.Clear();
            lBsalida.Items.Clear();

            Aprender = double.Parse(tBAprendizaje.Text);
            Error = double.Parse(tBError.Text);
            Capas = int.Parse(tBCapas.Text);
            Opera_Backpropagation.Epocas = double.Parse(tBEpocas.Text);
            
            for (int N = 0; N<entradatabla; N++)
            {
                Neurxcapa[N] = int.Parse(GridCapOcu.Rows[N].Cells[1].Value.ToString());
               // lBsalida.Items.Add(Neurxcapa[N]);
            }

            if (Problema.Text=="AND")
            {
                AND();
            }
            if (Problema.Text=="OR")
            {
                OR();
            }
            if (Problema.Text=="XOR")
            {
                XOR();
            }
            if (Problema.Text=="EJERCICIO")
            {
                EJERCICIO();
            }
            if (Problema.Text=="MAYORIA SIMPLE")
            {
                MAYORIASIMPLE();
            }
            if (Problema.Text=="PARIDAD")
            {
                PARIDAD();
            }
        }
        #region Problemas
        public void AND()
        {
            //Tamaño de la entrada de datos y salida dimencionado
            for (int i = 0; i < 4; i++)
            {
                entradas.Add(new double[2]);
                salidas.Add(new double[1]);
            }
            //Datos que sabemos que deben de dar en entrada y salida
            //                0                   0         =        1 
            entradas[0][0] = 0; entradas[0][1] = 0; salidas[0][0] = 0;
            entradas[1][0] = 0; entradas[1][1] = 1; salidas[1][0] = 0;
            entradas[2][0] = 1; entradas[2][1] = 0; salidas[2][0] = 0;
            entradas[3][0] = 1; entradas[3][1] = 1; salidas[3][0] = 1;
            //Activo la Clase con el objeto de 2entradas entra el valor de entradas, el valor de las capas ocultas y la salida
            Opera_Backpropagation dosentradas = new Opera_Backpropagation(new int[] { entradas[0].Length, Capas, salidas[0].Length });
            //aprendizaje,error
            dosentradas.Aprender(entradas, salidas, Aprender, Error);//aqui se leen los valores de error

            GridResultado.Columns.Add("x1", "X1");
            GridResultado.Columns.Add("x2", "X2");
            GridResultado.Columns.Add("ye", "Y esperada");
            GridResultado.Columns.Add("yr", "Y obt");

            GridResultado.Rows.Add("0", "0", "0", dosentradas.Activate(new double[] { 0, 0 })[0]);
            GridResultado.Rows.Add("0", "1", "0", dosentradas.Activate(new double[] { 0, 1 })[0]);
            GridResultado.Rows.Add("1", "0", "0", dosentradas.Activate(new double[] { 1, 0 })[0]);
            GridResultado.Rows.Add("1", "1", "1", dosentradas.Activate(new double[] { 1, 1 })[0]);
            

            if (Opera_Backpropagation.mostEpocas < Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Error : " + Opera_Backpropagation.mostError);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Epocas : "+Opera_Backpropagation.mostEpocas);

            }
            else if (Opera_Backpropagation.mostEpocas >= Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Epocas : " + Opera_Backpropagation.mostEpocas);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Error : " + Opera_Backpropagation.mostError);

            }
        }
        public void OR()
        {
            for (int i = 0; i < 4; i++)
            {
                entradas.Add(new double[2]);
                salidas.Add(new double[1]);
            }
            //Datos que sabemos que deben de dar en entrada y salida
            //                0                   0         =        1 
            entradas[0][0] = 0; entradas[0][1] = 0; salidas[0][0] = 0;
            entradas[1][0] = 0; entradas[1][1] = 1; salidas[1][0] = 1;
            entradas[2][0] = 1; entradas[2][1] = 0; salidas[2][0] = 1;
            entradas[3][0] = 1; entradas[3][1] = 1; salidas[3][0] = 1;

            Opera_Backpropagation dosentradas = new Opera_Backpropagation(new int[] { entradas[0].Length, Int32.Parse(Neurxcapa[0].ToString()), salidas[0].Length });
            //aprendizaje,error
            dosentradas.Aprender(entradas, salidas, Aprender, Error);//aqui se leen los valores de error

            GridResultado.Columns.Add("x1", "X1");
            GridResultado.Columns.Add("x2", "X2");
            GridResultado.Columns.Add("ye", "Y esperada");
            GridResultado.Columns.Add("yr", "Y obt");
            
            GridResultado.Rows.Add("0", "0", "0", dosentradas.Activate(new double[] { 0, 0 })[0]);
            GridResultado.Rows.Add("0", "1", "1", dosentradas.Activate(new double[] { 0, 1 })[0]);
            GridResultado.Rows.Add("1", "0", "1", dosentradas.Activate(new double[] { 1, 0 })[0]);
            GridResultado.Rows.Add("1", "1", "1", dosentradas.Activate(new double[] { 1, 1 })[0]);
            if (Opera_Backpropagation.mostEpocas < Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Error : " + Opera_Backpropagation.mostError);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Epocas : "+Opera_Backpropagation.mostEpocas);

            }
            else if (Opera_Backpropagation.mostEpocas >= Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Epocas : " + Opera_Backpropagation.mostEpocas);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Error : " + Opera_Backpropagation.mostError);

            }
        }
        public void XOR()
        {
            for (int i = 0; i < 4; i++)
            {
                entradas.Add(new double[2]);
                salidas.Add(new double[1]);
            }
            //Datos que sabemos que deben de dar en entrada y salida
            //                0                   0         =        1 
            entradas[0][0] = 0; entradas[0][1] = 0; salidas[0][0] = 0;
            entradas[1][0] = 0; entradas[1][1] = 1; salidas[1][0] = 1;
            entradas[2][0] = 1; entradas[2][1] = 0; salidas[2][0] = 1;
            entradas[3][0] = 1; entradas[3][1] = 1; salidas[3][0] = 0;

            Opera_Backpropagation dosentradas = new Opera_Backpropagation(new int[] { entradas[0].Length, Int32.Parse(Neurxcapa[0].ToString()), salidas[0].Length });
            //aprendizaje,error
            dosentradas.Aprender(entradas, salidas, Aprender, Error);//aqui se leen los valores de error

            GridResultado.Columns.Add("x1", "X1");
            GridResultado.Columns.Add("x2", "X2");
            GridResultado.Columns.Add("ye", "Y esperada");
            GridResultado.Columns.Add("yr", "Y obt");
            
            GridResultado.Rows.Add("0", "0", "0", dosentradas.Activate(new double[] { 0, 0 })[0]);
            GridResultado.Rows.Add("0", "1", "1", dosentradas.Activate(new double[] { 0, 1 })[0]);
            GridResultado.Rows.Add("1", "0", "1", dosentradas.Activate(new double[] { 1, 0 })[0]);
            GridResultado.Rows.Add("1", "1", "0", dosentradas.Activate(new double[] { 1, 1 })[0]);
            if (Opera_Backpropagation.mostEpocas < Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Error : " + Opera_Backpropagation.mostError);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Epocas : "+Opera_Backpropagation.mostEpocas);

            }
            else if (Opera_Backpropagation.mostEpocas >= Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Epocas : " + Opera_Backpropagation.mostEpocas);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Error : " + Opera_Backpropagation.mostError);

            }
        }
        public void EJERCICIO()
        {
            for (int i = 0; i < 6; i++)
            {
                entradas.Add(new double[2]);
                salidas.Add(new double[1]);
            }
            //Datos que sabemos que deben de dar en entrada y salida
            //                0                   0         =        1 
            entradas[0][0] = 2; entradas[0][1] = 0; salidas[0][0] = 1;
            entradas[1][0] = 0; entradas[1][1] = 0; salidas[1][0] = 0;
            entradas[2][0] = 2; entradas[2][1] = 2; salidas[2][0] = 1;
            entradas[3][0] = 0; entradas[3][1] = 1; salidas[3][0] = 0;
            entradas[2][0] = 1; entradas[2][1] = 1; salidas[2][0] = 1;
            entradas[3][0] = 1; entradas[3][1] = 2; salidas[3][0] = 0;
        
            Opera_Backpropagation dosentradas = new Opera_Backpropagation(new int[] { entradas[0].Length, Int32.Parse(Neurxcapa[0].ToString()), salidas[0].Length });
            //aprendizaje,error
            dosentradas.Aprender(entradas, salidas, Aprender, Error);//aqui se leen los valores de error

            GridResultado.Columns.Add("x1", "X1");
            GridResultado.Columns.Add("x2", "X2");
            GridResultado.Columns.Add("ye", "Y esperada");
            GridResultado.Columns.Add("yr", "Y obt"); 
            

            GridResultado.Rows.Add("2", "0", "1", dosentradas.Activate(new double[] { 2, 0 })[0]);
            GridResultado.Rows.Add("0", "0", "0", dosentradas.Activate(new double[] { 0, 0 })[0]);
            GridResultado.Rows.Add("2", "2", "1", dosentradas.Activate(new double[] { 2, 2 })[0]);
            GridResultado.Rows.Add("0", "1", "0", dosentradas.Activate(new double[] { 0, 1 })[0]);
            GridResultado.Rows.Add("1", "1", "1", dosentradas.Activate(new double[] { 1, 1 })[0]);
            GridResultado.Rows.Add("1", "2", "0", dosentradas.Activate(new double[] { 1, 2 })[0]);
            if (Opera_Backpropagation.mostEpocas < Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Error : " + Opera_Backpropagation.mostError);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Epocas : "+Opera_Backpropagation.mostEpocas);

            }
            else if (Opera_Backpropagation.mostEpocas >= Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Epocas : " + Opera_Backpropagation.mostEpocas);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Error : " + Opera_Backpropagation.mostError);

            }
        }
        public void MAYORIASIMPLE()
        {
            
            for (int i = 0; i < 8; i++)
            {
                entradas.Add(new double[3]);
                salidas.Add(new double[1]);
            }
            entradas[0][0] = 0; entradas[0][1] = 0; entradas[0][2] = 0; salidas[0][0] = 0;
            entradas[1][0] = 0; entradas[1][1] = 0; entradas[1][2] = 1; salidas[1][0] = 0;
            entradas[2][0] = 0; entradas[2][1] = 1; entradas[2][2] = 0; salidas[2][0] = 0;
            entradas[3][0] = 0; entradas[3][1] = 1; entradas[3][2] = 1; salidas[3][0] = 1;
            entradas[4][0] = 1; entradas[4][1] = 0; entradas[4][2] = 0; salidas[4][0] = 0;
            entradas[5][0] = 1; entradas[5][1] = 0; entradas[5][2] = 1; salidas[5][0] = 1;
            entradas[6][0] = 1; entradas[6][1] = 1; entradas[6][2] = 0; salidas[6][0] = 1;
            entradas[7][0] = 1; entradas[7][1] = 1; entradas[7][2] = 1; salidas[7][0] = 1;

            Opera_Backpropagation tresentradas = new Opera_Backpropagation(new int[] { entradas[0].Length, Int32.Parse(Neurxcapa[0].ToString()), salidas[0].Length });
            tresentradas.Aprender(entradas, salidas, Aprender, Error);//aqui se leen los valores de error

            GridResultado.Columns.Add("x1", "X1");
            GridResultado.Columns.Add("x2", "X2");
            GridResultado.Columns.Add("x3", "X3");
            GridResultado.Columns.Add("ye", "Y esp");
            GridResultado.Columns.Add("yr", "Y obt");
            
            GridResultado.Rows.Add("0", "0", "0", "0", tresentradas.Activate(new double[] { 0, 0, 0 })[0]);
            GridResultado.Rows.Add("0", "0", "1", "0", tresentradas.Activate(new double[] { 0, 0, 1 })[0]);
            GridResultado.Rows.Add("0", "1", "0", "0", tresentradas.Activate(new double[] { 0, 1, 0 })[0]);
            GridResultado.Rows.Add("0", "1", "1", "1", tresentradas.Activate(new double[] { 0, 1, 1 })[0]);
            GridResultado.Rows.Add("1", "0", "0", "0", tresentradas.Activate(new double[] { 1, 0, 0 })[0]);
            GridResultado.Rows.Add("1", "0", "1", "1", tresentradas.Activate(new double[] { 1, 0, 1 })[0]);
            GridResultado.Rows.Add("1", "1", "0", "1", tresentradas.Activate(new double[] { 1, 1, 0 })[0]);
            GridResultado.Rows.Add("1", "1", "1", "1", tresentradas.Activate(new double[] { 1, 1, 1 })[0]);

            if (Opera_Backpropagation.mostEpocas < Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Error : " + Opera_Backpropagation.mostError);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Epocas : "+Opera_Backpropagation.mostEpocas);

            }
            else if (Opera_Backpropagation.mostEpocas >= Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Epocas : " + Opera_Backpropagation.mostEpocas);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Error : " + Opera_Backpropagation.mostError);

            }
        }
        public void PARIDAD()
        {

            for (int i = 0; i < 16; i++)
            {
                entradas.Add(new double[4]);
                salidas.Add(new double[1]);
            }

            entradas[0][0] = 0; entradas[0][1] = 0; entradas[0][2] = 0; entradas[0][3] = 0; salidas[0][0] = 0;
            entradas[1][0] = 0; entradas[1][1] = 0; entradas[1][2] = 0; entradas[1][3] = 1; salidas[1][0] = 0;
            entradas[2][0] = 0; entradas[2][1] = 0; entradas[2][2] = 1; entradas[2][3] = 0; salidas[2][0] = 0;
            entradas[3][0] = 0; entradas[3][1] = 0; entradas[3][2] = 1; entradas[3][3] = 1; salidas[3][0] = 1;
            entradas[4][0] = 0; entradas[4][1] = 1; entradas[4][2] = 0; entradas[4][3] = 0; salidas[4][0] = 0;
            entradas[5][0] = 0; entradas[5][1] = 1; entradas[5][2] = 0; entradas[5][3] = 1; salidas[5][0] = 1;
            entradas[6][0] = 0; entradas[6][1] = 1; entradas[6][2] = 1; entradas[6][3] = 0; salidas[6][0] = 1;
            entradas[7][0] = 0; entradas[7][1] = 1; entradas[7][2] = 1; entradas[7][3] = 1; salidas[7][0] = 0;

            entradas[8][0] = 1; entradas[8][1] = 0; entradas[8][2] = 0; entradas[8][3] = 0; salidas[8][0] = 0;
            entradas[9][0] = 1; entradas[9][1] = 0; entradas[9][2] = 0; entradas[9][3] = 1; salidas[9][0] = 1;
            entradas[10][0] = 1; entradas[10][1] = 0; entradas[10][2] = 1; entradas[10][3] = 0; salidas[10][0] = 1;
            entradas[11][0] = 1; entradas[11][1] = 0; entradas[11][2] = 1; entradas[11][3] = 1; salidas[11][0] = 0;
            entradas[12][0] = 1; entradas[12][1] = 1; entradas[12][2] = 0; entradas[12][3] = 0; salidas[12][0] = 1;
            entradas[13][0] = 1; entradas[13][1] = 1; entradas[13][2] = 0; entradas[13][3] = 1; salidas[13][0] = 0;
            entradas[14][0] = 1; entradas[14][1] = 1; entradas[14][2] = 1; entradas[14][3] = 0; salidas[14][0] = 0;
            entradas[15][0] = 1; entradas[15][1] = 1; entradas[15][2] = 1; entradas[15][3] = 1; salidas[15][0] = 1;
     
            Opera_Backpropagation cuatroentradas = new Opera_Backpropagation(new int[] { entradas[0].Length, Int32.Parse(Neurxcapa[0].ToString()), salidas[0].Length });
            cuatroentradas.Aprender(entradas, salidas, Aprender, Error);//aqui se leen los valores de error

            GridResultado.Columns.Add("x1", "X1");
            GridResultado.Columns.Add("x2", "X2");
            GridResultado.Columns.Add("x3", "X3");
            GridResultado.Columns.Add("x4", "X4");
            GridResultado.Columns.Add("ye", "Y esp");
            GridResultado.Columns.Add("yr", "Y obt");

            GridResultado.Rows.Add("0", "0", "0", "0", "0", cuatroentradas.Activate(new double[] { 0, 0, 0, 0 })[0]);
            GridResultado.Rows.Add("0", "0", "0", "1", "0", cuatroentradas.Activate(new double[] { 0, 0, 0, 1 })[0]);
            GridResultado.Rows.Add("0", "0", "1", "0", "0", cuatroentradas.Activate(new double[] { 0, 0, 1, 0 })[0]);
            GridResultado.Rows.Add("0", "0", "1", "1", "1", cuatroentradas.Activate(new double[] { 0, 0, 1, 1 })[0]);
            GridResultado.Rows.Add("0", "1", "0", "0", "0", cuatroentradas.Activate(new double[] { 0, 1, 0, 0 })[0]);
            GridResultado.Rows.Add("0", "1", "0", "1", "1", cuatroentradas.Activate(new double[] { 0, 1, 0, 1 })[0]);
            GridResultado.Rows.Add("0", "1", "1", "0", "1", cuatroentradas.Activate(new double[] { 0, 1, 1, 0 })[0]);
            GridResultado.Rows.Add("0", "1", "1", "1", "0", cuatroentradas.Activate(new double[] { 0, 1, 1, 1 })[0]);
            
            GridResultado.Rows.Add("1", "0", "0", "0", "0", cuatroentradas.Activate(new double[] { 1, 0, 0, 0 })[0]);
            GridResultado.Rows.Add("1", "0", "0", "1", "1", cuatroentradas.Activate(new double[] { 1, 0, 0, 1 })[0]);
            GridResultado.Rows.Add("1", "0", "1", "0", "1", cuatroentradas.Activate(new double[] { 1, 0, 1, 0 })[0]);
            GridResultado.Rows.Add("1", "0", "1", "1", "0", cuatroentradas.Activate(new double[] { 1, 0, 1, 1 })[0]);
            GridResultado.Rows.Add("1", "1", "0", "0", "1", cuatroentradas.Activate(new double[] { 1, 1, 0, 0 })[0]);
            GridResultado.Rows.Add("1", "1", "0", "1", "0", cuatroentradas.Activate(new double[] { 1, 1, 0, 1 })[0]);
            GridResultado.Rows.Add("1", "1", "1", "0", "0", cuatroentradas.Activate(new double[] { 1, 1, 1, 0 })[0]);
            GridResultado.Rows.Add("1", "1", "1", "1", "1", cuatroentradas.Activate(new double[] { 1, 1, 1, 1 })[0]);
            if (Opera_Backpropagation.mostEpocas < Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Error : " + Opera_Backpropagation.mostError);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Epocas : "+Opera_Backpropagation.mostEpocas);

            }
            else if (Opera_Backpropagation.mostEpocas >= Opera_Backpropagation.Epocas)
            {
                lBsalida.Items.Add("Por Epocas : " + Opera_Backpropagation.mostEpocas);
                lBsalida.Items.Add("");
                lBsalida.Items.Add("Error : " + Opera_Backpropagation.mostError);

            }
        }
        #endregion
        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RIVERA RIVERA JUAN CARLOS \n\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridCapOcu.Columns.Clear();
            GridResultado.Columns.Clear();
            tBAprendizaje.Clear();
            tBCapas.Clear();
            tBEpocas.Clear();
            tBError.Clear();
            entradas.Clear();
            lBsalida.Items.Clear();
        }
    }
}
