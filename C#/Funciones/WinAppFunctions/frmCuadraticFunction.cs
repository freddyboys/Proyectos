using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAppFunctions
{
    public partial class frmCuadraticFunction : Form
    {


        //activa el modo grafico de Windows con GDI+(motor de graficos)
        private Graphics mGraph;
        //Coeficientes numericos de la ecuacion
        private float mA, mB, mC;
        //factor de escalamiento para zoom In / Zoom Out
        private const float SF = 20;


        public frmCuadraticFunction()
        {
            InitializeComponent();
        }


        private void GraphAxis()
        {
            //Asignar al objto de Tipo Graphics el control de creacion de
            //graficos de PictureBox
            mGraph = this.picGraphic.CreateGraphics();
            //Crear una pluma de color negro para graficar.
            Pen ObjPen = new Pen(Color.Black);

            //Eje horizontal
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            //Eje Vertical
            mGraph.DrawLine(ObjPen, 200,0,200,300);

        
        }

        private void EvaluateFunction(PointF[] P)
        {
            //Tabla de valores del mundo real
            float x, y;
            // Tabla de valores del Mundo de la computacion grafica
            float xp, yp;
            //Intervalos del Rango (x) de la funcion 
            float I1, I2;
            //  variable para controlar el valor de x
            float i;
            //variable para controlar el arreglo de Puntos flotantes (x,y)
            int j;

            I1 = -10; I2 = 10;
            for (i = I1,j=0; i <= I2;i++,j++)
            {
                //tabla de valores del mundo real
                x = i; lstX.Items.Add(x.ToString());
                y = mA * x * x + mB * x + mC; lstYp.Items.Add(y.ToString());
                //tabla de valores del mundo de computacion grafica
                xp = (float)(x * SF + 200); lstXp.Items.Add(xp.ToString());
                yp = (float)(-1.0 * y * SF + 150); lstYp.Items.Add(yp.ToString());
                //arreglo de puntos de tipo PointF para el mundo de la computacion grafica

                P[j] = new PointF(xp, yp);
            }
        
        }


        private void frmCuadraticFunction_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //leer valores de a,b y c de la ecuacion
            mA = float.Parse(txtA.Text);
            mB = float.Parse(txtB.Text);
            mC = float.Parse(txtC.Text);
            //resetear o borrar el contenido Picture Box
            picGraphic.Refresh();

            //Graficar los Ejes coordenados
            GraphAxis();

            //Crear una pluma de color azul
            Pen ObjPen = new Pen(Color.Blue);
            //crear un arreglo de estructura de tipo PointF(21 puntos)
            PointF[] P = new PointF[21];
            EvaluateFunction(P);
            mGraph.DrawCurve(ObjPen, P);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";

            picGraphic.Refresh();

            lstX.Items.Clear();
            lstY.Items.Clear();
            lstXp.Items.Clear();
            lstYp.Items.Clear();





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
