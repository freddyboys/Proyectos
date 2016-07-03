using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//agrefamos librerias
using System.Drawing;
using System.Windows.Forms;

namespace WinAppTicTacToe
{
    class TwoUsersControl
    {
        #region Atributos de la clase
        ///<summary>
        ///Datos Miembro
        ///</summary>
        ///

        private string mFlag;

       

        #region Propiedades
        ///<summary>
        ///geter y setters
        ///</summary>
        ///
        public string Flag
        {
            get { return mFlag; }
            set { mFlag = value; }
        }

        #endregion


        #region Constructores
        ///<summary>
        ///Funciones que iniclaidza los objetos
        ///</summary>
        ///

        public TwoUsersControl()
        {
            mFlag = "X";
        }
        #endregion



        #region Metodos de la Clase
        ///<summary>
        ///Funciones miembro
        ///</summary>
        ///
        public void InitializeData(List<Button> ButtonList, GroupBox grbTicTacToe)
        {
            //for (int i = 0; i < 9; i++)
            //    ButtonList[i].Text = "";

            for (int i = 0; i < ButtonList.Count; i++)
                ButtonList[i].Text = "";



            EnableControls(grbTicTacToe);

            mFlag="X";
        
        }
        
        public void DisableControls(GroupBox grbTicTacToe)

        {
            grbTicTacToe.Enabled = false;
        }

        public void EnableControls(GroupBox grbTicTacToe)
        {
            grbTicTacToe.Enabled = true;
        }


        public void MarkButton(Button ObjButton)
        {

            if (ObjButton.Text == "")
            {
                if (mFlag == "X")
                {
                    ObjButton.Text = mFlag;
                    mFlag = "0";
                }
                else//(mFLag!="X")
                {
                    ObjButton.Text = mFlag;
                    mFlag = "X";
                }


            }
            else
            {
                MessageBox.Show("Casillero ocupado.","Mensaje de Control");
            }


        
        }

        public void CheckWinner(List<Button> ButtonList, GroupBox grbTicTacToe)
        {

            if (ButtonList[0].Text == ButtonList[1].Text && ButtonList[1].Text==ButtonList[2].Text &&
                
                ButtonList[2].Text=="X")
        {

            MessageBox.Show("Gano"+ButtonList[2].Text,"Mensaje de Ganador");
            DisableControls(grbTicTacToe);



        }
            else if (ButtonList[3].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[5].Text &&

                ButtonList[5].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);

            
            }
            else if (ButtonList[6].Text == ButtonList[7].Text && ButtonList[7].Text == ButtonList[8].Text &&

                ButtonList[8].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[7].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[0].Text == ButtonList[3].Text && ButtonList[3].Text == ButtonList[6].Text &&

                ButtonList[6].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[3].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[1].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[7].Text &&

                ButtonList[7].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[4].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[2].Text == ButtonList[5].Text && ButtonList[5].Text == ButtonList[8].Text &&

                ButtonList[8].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[0].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[8].Text &&

                ButtonList[8].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[0].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[2].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[6].Text &&

                ButtonList[6].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[2].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }

             if (ButtonList[0].Text == ButtonList[1].Text && ButtonList[1].Text==ButtonList[2].Text &&
                
                ButtonList[2].Text=="X")
        {

            MessageBox.Show("Gano"+ButtonList[2].Text,"Mensaje de Ganador");
            DisableControls(grbTicTacToe);



        }
            else if (ButtonList[3].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[5].Text &&

                ButtonList[5].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);

            
            }
            else if (ButtonList[6].Text == ButtonList[7].Text && ButtonList[7].Text == ButtonList[8].Text &&

                ButtonList[8].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[7].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[0].Text == ButtonList[3].Text && ButtonList[3].Text == ButtonList[6].Text &&

                ButtonList[6].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[3].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[1].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[7].Text &&

                ButtonList[7].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[4].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[2].Text == ButtonList[5].Text && ButtonList[5].Text == ButtonList[8].Text &&

                ButtonList[8].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[0].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[8].Text &&

                ButtonList[8].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[0].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }
            else if (ButtonList[2].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[6].Text &&

                ButtonList[6].Text == "X")
            {

                MessageBox.Show("Gano" + ButtonList[2].Text, "Mensaje de Ganador");
                DisableControls(grbTicTacToe);


            }

            //para 0

             if (ButtonList[0].Text == ButtonList[1].Text && ButtonList[1].Text == ButtonList[2].Text &&

               ButtonList[2].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[2].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);



             }
             else if (ButtonList[3].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[5].Text &&

                 ButtonList[5].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[6].Text == ButtonList[7].Text && ButtonList[7].Text == ButtonList[8].Text &&

                 ButtonList[8].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[7].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[0].Text == ButtonList[3].Text && ButtonList[3].Text == ButtonList[6].Text &&

                 ButtonList[6].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[3].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[1].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[7].Text &&

                 ButtonList[7].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[4].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[2].Text == ButtonList[5].Text && ButtonList[5].Text == ButtonList[8].Text &&

                 ButtonList[8].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[0].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[8].Text &&

                 ButtonList[8].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[0].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[2].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[6].Text &&

                 ButtonList[6].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[2].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }

             if (ButtonList[0].Text == ButtonList[1].Text && ButtonList[1].Text == ButtonList[2].Text &&

                ButtonList[2].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[2].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);



             }
             else if (ButtonList[3].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[5].Text &&

                 ButtonList[5].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[6].Text == ButtonList[7].Text && ButtonList[7].Text == ButtonList[8].Text &&

                 ButtonList[8].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[7].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[0].Text == ButtonList[3].Text && ButtonList[3].Text == ButtonList[6].Text &&

                 ButtonList[6].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[3].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[1].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[7].Text &&

                 ButtonList[7].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[4].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[2].Text == ButtonList[5].Text && ButtonList[5].Text == ButtonList[8].Text &&

                 ButtonList[8].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[5].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[0].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[8].Text &&

                 ButtonList[8].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[0].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[2].Text == ButtonList[4].Text && ButtonList[4].Text == ButtonList[6].Text &&

                 ButtonList[6].Text == "0")
             {

                 MessageBox.Show("Gano" + ButtonList[2].Text, "Mensaje de Ganador");
                 DisableControls(grbTicTacToe);


             }
             else if (ButtonList[0].Text !="" && ButtonList[1].Text != "" &&

                 ButtonList[2].Text != "" && ButtonList[3].Text != "" &&
                 ButtonList[4].Text != "" && ButtonList[5].Text != "" &&
                 ButtonList[6].Text != "" && ButtonList[7].Text != "" &&
                 ButtonList[8].Text == "")
             {
             MessageBox.Show("Empate","Mensaje de Ganador");
                 DisableControls(grbTicTacToe);
             }






        
        }






        #endregion






        #endregion


        #region Propiedades de la clase
        ///<summary>
        ///Manejo de descriptores de accesos (gettes y setters)
        ///</summary>
        #endregion



        #region Constructores
        ///<summary>
        ///Funciones que inicializan los objetos
        ///</summary>
        #endregion



        #region Metodos de la clase
        ///<summary>
        ///Funciones miembro
        ///</summary>
        #endregion


    }
}
