/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package herencia2;
//import java.util.*;
import java.util.Scanner;



class Persona{
	private String nombre,cedula;
	private int edad;

	public Persona(String A, String B,int C){

		nombre=A;
		cedula=B;
		edad=C;
	}

	public String getCedula() {
		return cedula;
	}

	public void setCedula(String cedula) {
		this.cedula = cedula;
	}

	public void MostrarP(){
		System.out.println("Nombre: "+nombre);
		System.out.println("Cedula: "+cedula);
		System.out.println("Edad: "+edad);

	}
}

class Docente extends Persona {
	private String titulo;
	private int sueldo;

	public Docente(String a, String b,int c){ 
		super(a,b,c);
		
		Scanner y = new Scanner(System.in);
		System.out.println("Ingrese titulo de la persona  "); 
		titulo = y.next();
		do{
		System.out.println("Ingrese sueldo de la persona  "); 
		sueldo = y.nextInt();
		}while(sueldo<340||sueldo>3000);
	}

	public void MostrarD(){
		System.out.println("Titulo: "+titulo);
		System.out.println("Sueldo: "+sueldo);	
	}
}

class Alumno extends Persona{
	private String ID,carrera;

	public Alumno(String a ,String b,int c ){
		super(a,b,c);
		
		Scanner t= new Scanner(System.in);

		System.out.println("Ingrese ID del alumno:  "); 
		ID = t.next();
		System.out.println("Ingrese carrera a la que pertenece el alumno: "); 
		carrera = t.next();	
	}
	public void MostrarA(){
		System.out.println("ID: "+ID); 
		System.out.println("Carrera: "+carrera); 
	}
}

public class Herencia2 {

	public static void main(String[] args) {
            
		Scanner x = new Scanner(System.in);
		int longi,i,j;

		System.out.print("Ingrese el numero de clientes: ");
		longi= x.nextInt();
		while(longi <1||longi >20){
			System.out.print("\n Digite un numero de objetos validos");
			longi=x.nextInt();
		}

		Docente P1[]= new Docente[longi];
		Alumno P2[] = new Alumno [longi];

		// Docente
		String N1[] = new String [longi];
		String Ce1[] = new String [longi];
		int  E1[] = new int [longi];

		//Alumno
		String N2[] = new String [longi];
		String Ce2[] = new String [longi];
		int  E2[] = new int [longi];

		for(i=0;i<longi;i++){
			System.out.println("\n Docente N°" +(i+1)+" :");

			System.out.println("Ingrese su nombre: ");
			N1[i] = x.next();
			do{
				System.out.println("Ingrese su cedula: ");
				Ce1[i] = x.next();
			}while(Ce1[i].length()<10);
			System.out.println("Ingrese su edad: ");
			E1[i] = x.nextInt();

			P1[i] = new Docente( N1[i], Ce1[i], E1[i]);

			System.out.println("\n Alumno N°" +(i+1)+" :");

			System.out.println("Ingrese su nombre: ");
			N2[i] = x.next();
			do{
				System.out.println("Ingrese su cedula: ");
				Ce2[i] = x.next();
			}while(Ce1[i].length()<10);
			System.out.println("Ingrese su edad: ");
			E2[i] = x.nextInt();

			P2[i]= new Alumno(N2[i], Ce2[i],E2[i]);
		}

		System.out.println("Ingrese el # de cedula de la persona que desea encontrar:  ");
		String cedula;
		cedula=x.next();

		for(i=0;i<longi;i++){
			if(cedula.equalsIgnoreCase(P1[i].getCedula())){
				System.out.println("la persona que usted busca: ");
				P1[i].MostrarP();
				P1[i].MostrarD();
			}else{
				if(cedula.equalsIgnoreCase(P2[i].getCedula())){
					System.out.println("la persona que usted busca: ");
					P2[i].MostrarP();
					P2[i].MostrarA();
				}
			}
		}
	}
}
