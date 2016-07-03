/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cedula;

import java.util.Scanner;

/**
 *
 * @author DARO
 */
public class Cedula {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int i;
        int a,b,c,d,e,f,g,h,k;
        double a1,b1,c1,d1,e1,f1,g1,h1,k1, sumcoef, res, compA, compB;
        int numCed[]=new int [10]; // num de elmentos mas 1 osea 5 mas 1
        int coef[]= new int[10];
        
        coef[0]=2;
        coef[1]=1;
        coef[2]=2;
        coef[3]=1;
        coef[4]=2;
        coef[5]=1;
        coef[6]=2;
        coef[7]=1;
        coef[8]=2;
       
        
        Scanner num=new Scanner(System.in);
        //System.out.println("Ingrese numeros");
        
        
        System.out.println("Ingrese numero de cedula uno a la vez, luego presion Enter");
        for(i=1; i<10; i++){
            // System.out.println("Ingrese numeros");
        numCed[i]=num.nextInt();
        
        
        }
        compB=num.nextDouble();
       
        a=coef[0]*numCed[1];
        b=coef[1]*numCed[2];
        c=coef[2]*numCed[3];
        d=coef[3]*numCed[4];
        e=coef[4]*numCed[5];
        f=coef[5]*numCed[6];
        g=coef[6]*numCed[7];
        h=coef[7]*numCed[8];
        k=coef[8]*numCed[9];
        
     
        if((a/10)==1){
        a1=Math.floor(a/10)+(a%10);
        }else{
        a1=a;
        }
        
        if((b/10)==1){
        b1=Math.floor(b/10)+(b%10);
        }else{
        b1=b;
        }
        
        if((c/10)==1){
        c1=Math.floor(c/10)+(c%10);
        }else{
        c1=c;
        }
        
            if((d/10)==1){
        d1=Math.floor(d/10)+(d%10);
        }else{
        d1=d;
        }
        
                if((e/10)==1){
        e1=Math.floor(e/10)+(e%10);
        }else{
        e1=e;
        }
        
                     if((f/10)==1){
        f1=Math.floor(f/10)+(f%10);
        }else{
        f1=f;
        }
                     if((g/10)==1){
        g1=Math.floor(g/10)+(g%10);
        }else{
        g1=g;
        }
        
                        if((h/10)==1){
        h1=Math.floor(h/10)+(h%10);
        }else{
        h1=h;
        }
                        
                    //  double  k2=k/10;
       if(k/10==1){
       k1=(k/10)+(k%10);
       
       
        }else{
             //k1=(k/10)+(k%10);
        k1=k;
        }
        
        
        sumcoef=a1+b1+c1+d1+e1+f1+g1+h1+k1;
        
        
        
          //System.out.print(sumcoef);
       
        //System.out.print(sumcoef);
        
        res=sumcoef%10;
        compA=10-res;
        
        
        if(compA==compB || res==0){
            System.out.println("Cedula correcta");
        
        }else{
            System.out.println("Cedula incorrecta");
        
        }
        
         for(i=1; i<10; i++){
      System.out.print(numCed[i]);
      //System.out.print(compB);
        
        
        }
        
        
        
        
        
        
        
    }
    
}
