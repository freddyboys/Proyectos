

using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;



public class TicTacToeControl : MonoBehaviour {
	public GameState gameState = GameState.Opening; //What gamestate to start on

	public SquareState winner = SquareState.Clear;
	public SquareState[] board = new SquareState[9];
	public bool xTurn = true;


	//speech recognition
	Thread receiveThread;
	UdpClient client;
	public int port = 86; // DEFAULT UDP PORT !!!!! THE QUAKE ONE ;)
	string strReceiveUDP = "";
	string LocalIP = String.Empty;
	string hostname;

	public void Start()
	{
		Application.runInBackground = true;
		init();  

		
	}

	private void init()
	{
		receiveThread = new Thread( new ThreadStart(ReceiveData));
		receiveThread.IsBackground = true;
		receiveThread.Start();
		hostname = Dns.GetHostName();
		IPAddress[] ips = Dns.GetHostAddresses(hostname);
		if (ips.Length > 0)
		{
			LocalIP = ips[0].ToString();
			//Debug.Log(" 192.168.1.3 : "+LocalIP);
			//192.168.1.3 : 192.168.56.1
			//Debug.Log("192.168.1.3 :"+ "192.168.56.1");
			Debug.Log(" MY IP : "+LocalIP);
		}
	}

	private  void ReceiveData()
	{
		client = new UdpClient(port);
		while (true)
		{
			try
			{
				IPEndPoint anyIP = new IPEndPoint(IPAddress.Broadcast, port);
				byte[] data = client.Receive(ref anyIP);
				strReceiveUDP = Encoding.UTF8.GetString(data);
				// ***********************************************************************
				// Simple Debug. Must be replaced with SendMessage for example.
				// ***********************************************************************
				Debug.Log(strReceiveUDP);
				
				// ***********************************************************************
			}
			catch (Exception err)
			{
				print(err.ToString());
			}
		}
	}
	public GUIStyle style=null;



	
	public void NewGame() {
		xTurn = true;
		board = new SquareState[9]; //New board
	}
	
	public void OnGUI() {
		switch (gameState) {
		case GameState.Opening:
			DrawOpening ();
			break;
		case GameState.MultiPlayer:
			DrawGameBoard ();
			break;
		case GameState.GameOver:
			DrawGameOver ();
			break;
		}
		
	}
	
	public void DrawGameBoard() {
		float width = 75;
		float height = 75;
		int indice = 0;


		for(int y=0;y<3;y++) {
			for(int x=0;x<3;x++) {
				int boardIndex = (y * 3) + x;
				Rect square = new Rect(x * width, y * height, width, height);
				
				string owner = board[boardIndex] == SquareState.XControl ? "X" : board[boardIndex] == SquareState.OControl ? "O" : "";




				if(board[boardIndex] == SquareState.Clear) {
					if(GUI.Button(square, owner))
						SetControl(boardIndex);
				}
				else GUI.Label(square, owner);
			}
			
		}
		/*CON VOZZZZZZZZZZ
		//
		// int intelligence = 9;
		//if(board[0]

		//switch (intelligence){
		//case 1:
		//celda1

		//bool overGUI = false
		//AUIIIIIIIIIII
		   int boardIndex=0;
		   int boardIndex1=1;
		   int boardIndex2=2;
		   int boardIndex3=3;
		   int boardIndex4=4;
		   int boardIndex5=5;
		   int boardIndex6=6;
		   int boardIndex7=7;
		   int boardIndex8=8;




		   Rect square = new Rect(0 * width, 0 * height, width, height);

		   string owner = board[boardIndex] == SquareState.XControl ? "X" : board[boardIndex] == SquareState.OControl ? "O" : "";

		   if(board[boardIndex] == SquareState.Clear) {

			//if(GUI.Button(square, owner))

				GUI.Button(square, owner);
			//GUI.Label(square, owner);
			//GUI.Label(square, owner);
			if (strReceiveUDP == "cuadro uno") {	
				SetControl(boardIndex);
				//SetControl(indi);
				//SetControl (indice);

				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=(NumeroRandomico.Next(0, 8))-(0);
				Debug.Log(indice);

				SetControl (indice);
				

			}
			//SetControl(boardIndex1);

		}

		else GUI.Label(square, owner);
		


		//celda 2
		 //int boardIndex1=1;
		Rect square1 = new Rect(1 * width, 0 * height, width, height);
		string owner1 = board[boardIndex1] == SquareState.XControl ? "X" : board[boardIndex1] == SquareState.OControl ? "O" : "";
		if(board[boardIndex1] == SquareState.Clear) {
			GUI.Button(square1, owner1);
			if (strReceiveUDP == "cuadro dos") {	
				SetControl(boardIndex1);
				//SetControl(boardIndex);
				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);


			}
		}
		else GUI.Label(square1, owner1);



		//int boardIndex2=2;
		Rect square2 = new Rect(2 * width, 0 * height, width, height);
		string owner2 = board[boardIndex2] == SquareState.XControl ? "X" : board[boardIndex2] == SquareState.OControl ? "O" : "";
		if(board[boardIndex2] == SquareState.Clear) {
			GUI.Button(square2, owner2);
			if (strReceiveUDP == "cuadro tres") {	
				SetControl(boardIndex2);
				//SetControl(boardIndex);
				//SetControl(boardIndex1);
				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);

				}
		}
		else GUI.Label(square2, owner2);

		//}
		//int boardIndex3=3;
		Rect square3 = new Rect(0 * width, 1 * height, width, height);
		string owner3 = board[boardIndex3] == SquareState.XControl ? "X" : board[boardIndex3] == SquareState.OControl ? "O" : "";
		if(board[boardIndex3] == SquareState.Clear) {
			GUI.Button(square3, owner3);
			if (strReceiveUDP == "cuadro cuatro") {	
				SetControl(boardIndex3);
				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);

					}
		}
		else GUI.Label(square3, owner3);
		//


		//int boardIndex4=4;
		Rect square4 = new Rect(1 * width, 1 * height, width, height);
		string owner4 = board[boardIndex4] == SquareState.XControl ? "X" : board[boardIndex4] == SquareState.OControl ? "O" : "";
		if(board[boardIndex4] == SquareState.Clear) {
			GUI.Button(square4, owner4);
			if (strReceiveUDP == "cuadro cinco") {	
				SetControl(boardIndex4);

				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);
						}
		}
		else GUI.Label(square4, owner4);



		//int boardIndex5=5;
		Rect square5 = new Rect(2 * width, 1 * height, width, height);
		string owner5 = board[boardIndex5] == SquareState.XControl ? "X" : board[boardIndex5] == SquareState.OControl ? "O" : "";
		if(board[boardIndex5] == SquareState.Clear) {
			GUI.Button(square5, owner5);
			if (strReceiveUDP == "cuadro seis") {	
				SetControl(boardIndex5);
				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);
							}
		}
		else GUI.Label(square5, owner5);
		


		//int boardIndex6=6;
		Rect square6 = new Rect(0 * width, 2 * height, width, height);
		string owner6 = board[boardIndex6] == SquareState.XControl ? "X" : board[boardIndex6] == SquareState.OControl ? "O" : "";
		if(board[boardIndex6] == SquareState.Clear) {
			GUI.Button(square6, owner6);
			if (strReceiveUDP == "cuadro siete") {	
				SetControl(boardIndex6);
				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);
								}
		}
		else GUI.Label(square6, owner6);


		//int boardIndex7=7;
		Rect square7 = new Rect(1 * width, 2 * height, width, height);
		string owner7 = board[boardIndex7] == SquareState.XControl ? "X" : board[boardIndex7] == SquareState.OControl ? "O" : "";
		if(board[boardIndex7] == SquareState.Clear) {
			GUI.Button(square7, owner7);
			if (strReceiveUDP == "cuadro ocho") {	
				SetControl(boardIndex7);
				
				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);
									}
		}
		else GUI.Label(square7, owner7);
		

		//int boardIndex8=8;
		Rect square8 = new Rect(2 * width, 2 * height, width, height);
		string owner8 = board[boardIndex8] == SquareState.XControl ? "X" : board[boardIndex8] == SquareState.OControl ? "O" : "";
		if(board[boardIndex8] == SquareState.Clear) {
			GUI.Button(square8, owner8);
			if (strReceiveUDP == "cuadro nueve") {	
				SetControl(boardIndex8);

				System.Random NumeroRandomico = new System.Random();
				//Random(a, i);
				indice=NumeroRandomico.Next(0,8);
				SetControl (indice);



										}
		}
		else GUI.Label(square8, owner8);
		

		/*
		int a  =  boardIndex;
		int b  =  boardIndex1;
		int c  =  boardIndex2;
		int d  =  boardIndex3;
		int e  =  boardIndex4;
		int f  =  boardIndex5;
		int g  =  boardIndex6;
		int h  =  boardIndex7;
		int i  =  boardIndex8;
*/
	
//		System.Random NumeroRandomico = new System.Random();
		//Random(a, i);
		//indice=NumeroRandomico.Next(boardIndex1, boardIndex8);
		//indice = NumeroRandomico;
//		SetControl (indice);



		Rect turnRect = new Rect(300, 0, 100, 100);
		string turnTitle = xTurn ? "X's Turno!" : "O's Turno!";
		GUI.Label(turnRect, turnTitle);
	


		//GUILayout.Label(strReceiveUDP,style);

	}
	/*
	public int arreglo(){
		int indice = 0;


		System.Random NumeroRandomico = new System.Random();
		//Random(a, i);
		indice=NumeroRandomico.Next(Dr, boardIndex8);
		return indice;


		}*/




	public void DrawOpening() {
		Rect titleRect = new Rect (0, 0, 300, 75);
		GUI.Label (titleRect, "Tic-Tac-Toe");
		
		Rect multiRect = new Rect (titleRect.x, titleRect.y + titleRect.height, titleRect.width, 75);
		
		if (GUI.Button (multiRect, "Nueva Partida")) {
			NewGame ();
			gameState = GameState.MultiPlayer;
			//Start();
			//init();
		}
	}
	
	public void DrawGameOver() {
		Rect winnerRect = new Rect (0, 0, 300, 75);
		string winnerTitle = winner == SquareState.XControl ? "X Gana!" : winner == SquareState.OControl ? "O Gana!" : "Empate!";
		GUI.Label (winnerRect, winnerTitle);
		
		winnerRect.y += winnerRect.height;
		if (GUI.Button (winnerRect, "Menu Principal"))

			gameState = GameState.Opening;

	}
	
	public void SetControl(int boardIndex) {
		if(boardIndex < 0 || boardIndex >= board.Length) return;
		
		board[boardIndex] = xTurn ? SquareState.XControl : SquareState.OControl;
		xTurn = !xTurn;
	}
	public void LateUpdate() {
		if (gameState != GameState.MultiPlayer) return;
		for(int i=0;i<3;i++) {
			if(board[i] != SquareState.Clear && board[i] == board[i + 3] && board[i] == board[i + 6]) {
				SetWinner(board[i]);
				return;
			}
			else if(board[i * 3] != SquareState.Clear && board[i * 3] == board[(i * 3) + 1] && board[i * 3] == board[(i * 3) + 2]) {
				SetWinner(board[i * 3]);
				return;
			}
		}
		
		if(board[0] != SquareState.Clear && board[0] == board[4] && board[0] == board[8]) {
			SetWinner(board[0]);
			return;
		}
		else if(board[2] != SquareState.Clear && board[2] == board[4] && board[2] == board[6]) {
			SetWinner(board[2]);
			return;
		}
		
		for(int i=0;i<board.Length;i++) {
			if(board[i] == SquareState.Clear)
				return;
		}
		SetWinner(SquareState.Clear);
	}
	
	public void SetWinner(SquareState toWin) {
		winner = toWin;
		gameState = GameState.GameOver;
	}
	





	public string UDPGetPacket()
	{
		return strReceiveUDP;
	}
	
	void OnDisable()
	{
		if ( receiveThread != null) receiveThread.Abort();
		client.Close();
	}



}

