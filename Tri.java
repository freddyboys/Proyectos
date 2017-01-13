/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tri;
import java.util.Scanner;
/**
 *
 * @author DARO
 */
public class Tri {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int pivot,a,b;
        int i;
        int acum=0;
        int suma;
        int raiz;
        Scanner sc= new Scanner(System.in);
       
        
        
        
       System.out.println("Ingrese el numero pivot");
       pivot=sc.nextInt();
        raiz=pivot;
       
       
       for(i=0;i<14;i++){
       
         System.out.println("Ingrese nodo izquierdo");
       a=sc.nextInt();
       
        System.out.println("Ingrese nodo derecho");
       b=sc.nextInt();
       /*
       System.out.println("----------");
       System.out.println(pivot);
         System.out.println(a);
         System.out.println(b);*/
         if(a>b){
             pivot=a;
         }
         else{
             pivot=b;
         }
         System.out.println("nuevo pivot");
       System.out.println(pivot);
         acum=acum+pivot;
         
         
           System.out.println("acum");
       System.out.println(acum);
       }
       
       suma=acum+raiz;
        System.out.println("total");
       System.out.println(suma);
       
    }
    
}
