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
    public partial class frmFuncion : Form
    {

        private Graphics mGraph;
        private const float FE = 30;
     
        private void GraficarEjes()
        {
            mGraph = this.picGraphic.CreateGraphics();
            Pen ObjPen = new Pen(Color.Black);

            mGraph.DrawLine(ObjPen, 0, 200, 550, 200);
            mGraph.DrawLine(ObjPen, 275, 0, 275, 400);
        }

        private void EvaluarFuncion(PointF[] P)
        {
            float x, y;
            float xp, yp;
            double I1, I2;
            double i;
            int j;

            I1 = -4 * (float)Math.PI;
            I2 = 4 * (float)Math.PI;

            for (i = I1, j = 0; i <= I2; i = i + (float)Math.PI / 180, j++)
            {
                x = (float)i;
                listX.Items.Add(x.ToString());
                if (x == 1 || x == -1)
                {
                    y = 1;
                    y = -1;
                }
                else
                {
                    y = (x * x * x) / ((x * x) - 1);
                    listY.Items.Add(y.ToString());
                    if (x == y)
                        x = y;
                }
                xp = (float)(x * FE + 275);
                listXp.Items.Add(xp.ToString());
                yp = (float)((-1 * y * FE) + 200);
                listYp.Items.Add(yp.ToString());
                P[j] = new PointF(xp, yp);

            }
          //  }*/
        }



        public frmFuncion()
        {
            InitializeComponent();
        }

        private void frmFuncion_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             double x, y;
            float xp, yp;
            picGraphic.Refresh();
            GraficarEjes();
            Pen ObjPen = new Pen(Color.Black);
            int n=1600;
            PointF[] P = new PointF[n];
            PointF[] P1 = new PointF[n];
            EvaluarFuncion(P);
            for (int i = -150,j=0; i <= 150; i++ ,j++)
            {
                x = (float)i;
                y = (float)i;
                xp = (float)(x * FE + 275);
                yp = (float)((-1 * y * FE) + 200);
                P1[j] = new PointF(xp, yp);

            }
            mGraph.DrawCurve(ObjPen, P);
            mGraph.DrawCurve(ObjPen, P1);
        }
    }
}
