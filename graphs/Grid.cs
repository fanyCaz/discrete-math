using System;
using System.Collections.Generic;

namespace graphs{
    class Grid{
        static int R = 0;   //number of rows
        static int C = 0;   //number of columns
        // receives row and column like a position (r,c)
        public static void DirectionVectors(int r , int c){
            //north,south,east,west
            int[] dr = new int[]{-1,1,0,0}; //direction rows
            int[] dc = new int[]{0,0,1,-1}; //direction columns

            for(int i= 0; i< 4; i++){
                int rr = r + dr[i]; //new row
                int cc = c + dc[i]; //new column
                //check if this isn't out bounds
                if(rr < 0 || cc < 0){
                    continue;
                }
                if(rr >= R || cc >= C){
                    continue;
                }
            }
        }
    }
}