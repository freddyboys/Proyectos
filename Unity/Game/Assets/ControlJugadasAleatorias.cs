using UnityEngine;
using System.Collections;


public class ControlJugadasAleatorias : MonoBehaviour {
	private string mBandera;        
	private int mNumeroJugada;        
	private int mControlJuego;   
	public SquareState[] board = new SquareState[9];
	private int[] mArregloJugadas = new int[9];

	//public TicTacToeControl casilleros = new TicTacToeControl[9];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public ControlJugadasAleatorias()
	{
		for (int i = 0; i < mArregloJugadas.Length; i++)
			mArregloJugadas[i] = 0;
		
		mBandera = "X";
		mNumeroJugada = 1;
		mControlJuego = 0;
	}
	public void InicializarDatos()
	{
		for (int i = 0; i < mArregloJugadas.Length; i++)
			mArregloJugadas[i] = 0;
		
		mBandera = "X";
		mNumeroJugada = 1;
		mControlJuego = 0;
	}

	/*
	private int GenerarJugadaAleatoriaPC()
	{
		int indice = 0;
		Random NumeroRandomico = new Random();
		
		do
		{
			indice = NumeroRandomico();
			if (mArregloJugadas[indice] == 0 && indice < mArregloJugadas.Length)
				return indice;
			//SetControl(boardIndex1);
		}
		while (true);
	}*/
	
	/*
	
	private int GenerarJugadaAleatoriaPC()
	{
		int indice = 0;
		Random NumeroRandomico = new Random();
		
		do
		{
			indice = NumeroRandomico.Equals(0, 9);
			if (mArregloJugadas[indice] == 0 && indice < mArregloJugadas.Length)
				return indice;
		}
		while (true);
	}*/


}
