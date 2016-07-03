using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;
//using System.ComponentModel;
using System.Diagnostics;


namespace WinAppTicTacToe
{
    public partial class frmTicTacToe : Form
    {

        private List<Button> ButtonList = new List<Button>();

        private TwoUsersControl objTwoUsersControl = new TwoUsersControl();

         SpeechRecognitionEngine reconocedor = new SpeechRecognitionEngine();
        SpeechSynthesizer AVJarvis = new SpeechSynthesizer();
        string speech;
        bool habilitarReconocimiento = true;

    

        //private void window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    cargarGramaticas();
        //}

        void cargarGramaticas()
        {
            reconocedor.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"ArchivosTexto\ComandosDefecto.txt")))));
         //   reconocedor.LoadGrammarAsync(new DictationGrammar());
            reconocedor.RequestRecognizerUpdate();
            reconocedor.SpeechRecognized += reconocedor_SpeechRecognized;
            AVJarvis.SpeakStarted += AVJarvis_SpeakStarted;
            AVJarvis.SpeakCompleted += AVJarvis_SpeakCompleted;
            reconocedor.AudioLevelUpdated += reconocedor_AudioLevelUpdated;
            reconocedor.SetInputToDefaultAudioDevice();
            reconocedor.RecognizeAsync(RecognizeMode.Multiple);
        }


        void reconocedor_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
        {
            int audiolevel = e.AudioLevel;
           // progressbar1.Value = audiolevel;
        }
    
        void AVJarvis_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            habilitarReconocimiento = true;
        }

        void AVJarvis_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            habilitarReconocimiento = false;
        }

        void reconocedor_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            speech = e.Result.Text;

            Process myProcess = new Process();


            if (habilitarReconocimiento == true)
            {
                
            switch (speech)
            {



                case "Uno":
                    //AVJarvis.SpeakAsync("Buenos Dias Señor" + "Freddy");
                    //lblReconocimiento.Content = "";
                    //lblReconocimiento.Content = speech;
                    
//this.btnTicTacToe1.Click +=delegate(object sender, EventArgs e); 

                    this.btnTicTacToe1.Click += new System.EventHandler(this.btnTicTacToe1_Click);
 
                    
        {
            objTwoUsersControl.MarkButton(btnTicTacToe1);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


        }





                    break;


                case "Dos":
                         this.btnTicTacToe2.Click += new System.EventHandler(this.btnTicTacToe2_Click);
 
                    
        {
            objTwoUsersControl.MarkButton(btnTicTacToe2);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


        }

                    //AVJarvis.SpeakAsync("Abrir el buscador" + ". . . . .");
                    //System.Diagnostics.Process.Start("https://www.google.com/");
                    //lblReconocimiento.Content = "";
                    //lblReconocimiento.Content = speech;
                    break;


                case "Tres":
                         this.btnTicTacToe3.Click += new System.EventHandler(this.btnTicTacToe3_Click);
 
                    
        {
            objTwoUsersControl.MarkButton(btnTicTacToe3);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


        }
                    //AVJarvis.SpeakAsync("Abriendo correo" + ". . . . .");
                    //System.Diagnostics.Process.Start("https://www.hotmail.com/");
                    //lblReconocimiento.Content = "";
                    //lblReconocimiento.Content = speech;
                    break;
                //case "Word":
                //    AVJarvis.SpeakAsync("Abriendo  word" + ". . . . .");
                //    System.Diagnostics.Process.Start("winword");
                //    lblReconocimiento.Content = "";
                //    lblReconocimiento.Content = speech;
                //    break;

                   // ProcessStartInfo startInfo = new ProcessStartInfo();
                case "Cuatro":
                  //  AVJarvis.SpeakAsync("Abriendo  tic tac" + ". . . . .");
                         this.btnTicTacToe4.Click += new System.EventHandler(this.btnTicTacToe4_Click);
 
                    
        {
            objTwoUsersControl.MarkButton(btnTicTacToe4);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


        }


                //    myProcess.StartInfo.FileName = @"C:\Users\johana\Desktop\WinAppTicTacToe2\WinAppTicTacToe\bin\Debug\WinAppTicTacToe";
                //myProcess.StartInfo.CreateNoWindow = true;
                //myProcess.Start();
                
                //App.Current.Shutdown();
                   // System.Diagnostics.Process.Start(@"C:\Users\johana\Desktop\WinAppTicTacToe2\WinAppTicTacToe\bin\Debug\WinAppTicTacToe.exe");
                    //lblReconocimiento.Content = "";
                    //lblReconocimiento.Content = speech;
                    break;



                case "Cinco":
                    //  AVJarvis.SpeakAsync("Abriendo  tic tac" + ". . . . .");
                    this.btnTicTacToe5.Click += new System.EventHandler(this.btnTicTacToe5_Click);
                    {
                        objTwoUsersControl.MarkButton(btnTicTacToe5);
                        objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


                    }


                    break;

                case "Seis":
                    //  AVJarvis.SpeakAsync("Abriendo  tic tac" + ". . . . .");
                    this.btnTicTacToe6.Click += new System.EventHandler(this.btnTicTacToe6_Click);
                    {
                        objTwoUsersControl.MarkButton(btnTicTacToe6);
                        objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


                    }


                    break;

                case "Siete":
                    //  AVJarvis.SpeakAsync("Abriendo  tic tac" + ". . . . .");
                    this.btnTicTacToe7.Click += new System.EventHandler(this.btnTicTacToe7_Click);
                    {
                        objTwoUsersControl.MarkButton(btnTicTacToe7);
                        objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


                    }


                    break;


                case "Ocho":
                    //  AVJarvis.SpeakAsync("Abriendo  tic tac" + ". . . . .");
                    this.btnTicTacToe8.Click += new System.EventHandler(this.btnTicTacToe8_Click);
                    {
                        objTwoUsersControl.MarkButton(btnTicTacToe8);
                        objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


                    }


                    break;


                case "Nueve":
                    //  AVJarvis.SpeakAsync("Abriendo  tic tac" + ". . . . .");
                    this.btnTicTacToe9.Click += new System.EventHandler(this.btnTicTacToe9_Click);
                    {
                        objTwoUsersControl.MarkButton(btnTicTacToe9);
                        objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


                    }


                    break;



                case "Adios asistente":
                    AVJarvis.Speak("Hasta pronto señor" + "Freddy");
                    this.Close();
                  //  Close();
                    break;

                default:
                    break;
            }

            }
        }


        public frmTicTacToe()
        {
            InitializeComponent();
            InsertDataList();
        }

        private void InsertDataList()
        {
            ButtonList.Add(btnTicTacToe1);
            ButtonList.Add(btnTicTacToe2);
            ButtonList.Add(btnTicTacToe3);
            ButtonList.Add(btnTicTacToe4);
            ButtonList.Add(btnTicTacToe5);
            ButtonList.Add(btnTicTacToe6);
            ButtonList.Add(btnTicTacToe7);
            ButtonList.Add(btnTicTacToe8);
            ButtonList.Add(btnTicTacToe9);



            //reverse invierte la lista
        
        
        }



        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.InitializeData(ButtonList, grbTicTacToe);
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void mnuHelpContent_Click(object sender, EventArgs e)
        {

        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnTicTacToe1_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe1);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);


        }

        private void btnTicTacToe2_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe2);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe3_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe3);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe5_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe5);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe4_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe4);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe6_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe6);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe9_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe9);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe8_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe8);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void btnTicTacToe7_Click(object sender, EventArgs e)
        {
            objTwoUsersControl.MarkButton(btnTicTacToe7);
            objTwoUsersControl.CheckWinner(ButtonList, grbTicTacToe);
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {
            objTwoUsersControl.InitializeData(ButtonList, grbTicTacToe);
            cargarGramaticas();
        }

        private void grbMessages_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
