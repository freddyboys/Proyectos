﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAppFunctions
{
    public partial class frmSeno : Form
    {

        private float a;
        private Graphics mGraph;
        private const float FE = 20;






        private void Ejes()
        {
            mGraph = this.TablaGrafico.CreateGraphics();
            Pen ObjPen = new Pen(Color.Black);

            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            mGraph.DrawLine(ObjPen, 200, 0, 200, 300);
        }

        private void Funcion(PointF[] P)
        {
            float x, y;
            float xp, yp;
            float LimInf, LimSup;
            float i;
            int j;

            LimInf = -3 * (float)Math.PI; LimSup = 3 * (float)Math.PI;
            for (i = LimInf, j = 0; i <= LimSup; i = i + (float)Math.PI / 180, j++)
            {
                x = (float)i;
                y = a * (float)Math.Sin(i);
                xp = (float)(x * FE + 200);
                yp = (float)((-1 * y * FE) + 150);
                P[j] = new PointF(xp, yp);
            }


        }



        public frmSeno()
        {
            InitializeComponent();
        }

        private void frmSeno_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            a = float.Parse(txtA.Text);
            if (a == 0)
            {
                TablaGrafico.Refresh();
                Ejes();

                Pen ObjPen = new Pen(Color.Blue);
                PointF[] P = new PointF[1081];
                Funcion(P);
                mGraph.DrawCurve(ObjPen, P);
                lblMensaje.Text = "Grafica el eje X";
            }
            else
            {
                if (a > 0)
                {
                    TablaGrafico.Refresh();
                    Ejes();

                    Pen ObjPen = new Pen(Color.Blue);
                    PointF[] P = new PointF[1081];
                    Funcion(P);
                    mGraph.DrawCurve(ObjPen, P);
                    lblMensaje.Text = "Gráfica Real";

                }
                else
                {
                    TablaGrafico.Refresh();
                    Ejes();

                    Pen ObjPen = new Pen(Color.Blue);
                    PointF[] P = new PointF[1081];
                    Funcion(P);
                    mGraph.DrawCurve(ObjPen, P);
                    lblMensaje.Text = "Gráfica Ivertida";
                }

            }










        }
    }
}
