/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package matrizunidimensional;

import java.util.Scanner;

/**
 *
 * @author johana
 */
public class MatrizUnidimensional {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        int nElementos;
        System.out.print("Numero de elementos de la matriz: ");
        Scanner x = new Scanner(System.in);
        nElementos = x.nextInt();
        int[]m=new int[nElementos];
        int i=0;
        
        System.out.println("Introducir los valores--> ");
        for(i=0 ;i< nElementos; i++)
        {
            System.out.print("m["+i+"]=");
            m[i]=x.nextInt();
            
        }
        
        System.out.println();
        for(i=0;i<nElementos;i++)
            System.out.print(m[i]+" ");
        System.out.println("Fin");
            
        
        
        
        
        
        
    }
    
}
