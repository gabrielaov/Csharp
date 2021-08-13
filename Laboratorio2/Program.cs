using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 1 A 4
            int[] array = new int[5] {10, 20, 30, 40, 50};
            int i;
            for (i = 0; i < array.Length; i++){
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
                
            }
            //foreach (int il in array){
            //Console.WriteLine(il);}
            
            */

            /*EXERCICIO 5
            string[] str = new String[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < str.Length; iStr++){
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

            foreach (var item in str)
            {
                Console.WriteLine(item);
            }

            */

            /*EXERCICIO 6 7 8
            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++){
                Console.WriteLine("Indice = " + iDate + " & Date = " + dt[iDate].ToShortDateString());
            }

            int cont = 0;
            foreach (var item in dt)            
            {
                cont++;
                Console.WriteLine("Indice = " + cont +" & Date = " + item.ToShortDateString());
            }

            */

            /*
            EXERCICIO 1
            int [] array1 = new int[100];
            int [] array2 = new int[100];

            for (int i = 0; i < array1.Length; i++){
                array1[i] = i;
            }

            for (int j = 0; j < array1.Length; j++){
                array2[j] = array1[j];
            }

            foreach (var item in array1){
                Console.Write("\n" + item);
            }

            foreach (var item2 in array2)
            {
                Console.Write("\n" + item2);
            }
            {   
            }
            */

            /*EXERCICIO 2 COM ARRAY MULTIDIMENCIONAL

            int [,] matriz = { {1, 2, 3, 4, 5}, {7, 2, 9, 4, 5}, {9, 2, 5, 4, 4}, {1, 8, 9, 5, 5}, {4, 2, 7, 7, 5} };   

            for (int i = 0; i < 5; i++){
                Console.Write("\n");
                for (int j = 0; j < 5; j++){
                    Console.Write(matriz[i, j] + " ");
                }
            }
            
            Console.WriteLine("");

            for (int k = 0; k < 5; k++){
                int soma = 0;
                for (int l = 0; l < 5; l++){                         
                    soma += matriz[l,k];                             
                }
                Console.WriteLine("Soma da coluna " + (k+1) + ": " + soma);
            }

            */

            /*EXERCICIO 2 COM ARRAY JAGGED

            int[][] matriz = { new int [] {1, 2, 3, 4, 5}, new int [] {1, 2, 3, 4, 5}, new int [] {1, 2, 3, 4, 5}, new int [] {1, 2, 3, 4, 5}, new int [] {1, 2, 3, 4, 5} };

             for (int i = 0; i < matriz.Length; i++){
                Console.Write("\n");
                for (int j = 0; j < 5; j++){
                    Console.Write(matriz[i][j] + " ");
                }
            }     

            Console.WriteLine("");

            for (int k = 0; k < matriz.Length; k++){
                int soma = 0;
                for (int l = 0; l < 5; l++){                         
                    soma += matriz[l][k];                             
                }
                Console.WriteLine("Soma da coluna " + (k+1) + ": " + soma);
            }     

        */
        }
    }
}
