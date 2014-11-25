using UnityEngine;
using System.Collections;

public class Dijsktra : MonoBehaviour {
	public GameObject Jugador,A,B,C;
	public int [,] Casillas=new int [20,20];//1 =ocupado //0= libre
	public GameObject[,] Nodos = new GameObject[20, 20];
	void llena_Nodos()
	{

	}
	void construye_Laberinto()
	{
		int filaSup = 0;
		int filaInf = 20;
		//Se llenan nodos ocupados en las paredes del laberinto externas
		for (int i=0; i <20; i++){
			//Para llenar la fila superior.
			Casillas[i,filaSup]=1;
			//Para llenar fila inferior
			Casillas[filaInf,i]=1;
			//Para llenar columna izquierda
			Casillas[i,filaSup]=1;
			//Para llenar columna derecha
			Casillas[filaInf,i]=1;
		}

		//Columna 1
		Casillas[2,1]=1;
		Casillas[4,1]=1;
		//Columna 2
		Casillas[2,2]=1;
		Casillas[4,2]=1;
		//Columna 3
		Casillas[2,3]=1;
		Casillas[4,3]=1;
		//Columna 4
		Casillas[2,4]=1;
		for (int i=4; i<18; i++)	
		Casillas [i, 4] = 1;
		//Columna 5
		Casillas[2,5]=1;
		Casillas[17,5]=1;
		//Columna 6
		Casillas[2,6]=1;
		for(int i=4;i<18;i++) 
		Casillas[i,6]=1;
		//Columna 7
		Casillas[2,7]=1;
		//Columna 8
		for(int i=2;i<18;i++)
		{
			if(i!=7||i!=8)
				Casillas[i,8]=1;
		}
		//Columna 9
		Casillas[17,9]=1;
		//Columna 10
		for(int i=1;i<18;i++)
		{
			if(i!=3||i!=4||i!=5||i!=7||i!=16||i!=18)
			Casillas[i,10]=1;
		}
		//Columna 11-16
		for(int i=11;i<17;i++)
		{
		Casillas[2,i]=1;
		Casillas[6,i]=1;
		Casillas[8,i]=1;
		Casillas[15,i]=1;
		Casillas[17,i]=1;
		}
		//Columna 17
		for(int i=2;i<19;i++)
		{
			if(i==2||i==6||i==8||i==9||i==10||i==11||i==15||i==17||i==18)
				Casillas[i,17]=1;
		}
		//Columna 18
		Casillas[2,18]=1;
		Casillas[6,18]=1;
		Casillas[15,18]=1;
	}
	
}
