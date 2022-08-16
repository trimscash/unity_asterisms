using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsterismData 
{
    public List<int> Stars=new List<int> {};
	public List<List<int>> AdjancencyMatrix=new List<List<int>>{};

    public AsterismData(List<int> stars,List<List<int>> adjancencyMatrix){
        Stars=new List<int>(stars);
        AdjancencyMatrix=new List<List<int>>(adjancencyMatrix);
    }

    int getStarsData(int x){
        return (x>=0&&Stars.Count>x)? Stars[x]:-1;
    }
    int getAdMatrixData(int x,int y){
        if(AdjancencyMatrix.Count>x&&0<=x){
            if(AdjancencyMatrix[x].Count > y && 0 <= y){
			return AdjancencyMatrix[x][y];
            }else{
                return -1;
            }
        }else{
            return -1;
        }
    }
}
