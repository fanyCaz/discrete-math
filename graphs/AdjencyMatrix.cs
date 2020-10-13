using System;

namespace graphs{
    class AdjencyMatrix{
        int[][] matrix;
        public AdjencyMatrix(int nodes){
            matrix = new int[nodes][];
            
        }
        
        public int valorEn(int i, int j){
            return matrix[i][j];
        }

        public void agregarPesos(int nodo, int[] pesos){
            matrix[nodo] = pesos;
        }

        public void imprimirMatriz(){
            for(int i= 0; i < matrix.Length; i++){
                for(int j=0; j < matrix.Length; j++){
                    Console.Write($"{matrix[i][j]} | ");
                }
                Console.Write("\n");
            }
        }
        public int Longitud(){
            return matrix.Length;
        }

        
    }
}