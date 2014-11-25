using UnityEngine;
using System.Collections;

public class MovTest : MonoBehaviour {
	public GameObject NodoA;
	public GameObject NodoB;
	public GameObject NodoC;
	public GameObject NodoD;
	public GameObject NodoE;
	public GameObject NodoF;
	public GameObject NodoG;
	public GameObject NodoH;
	public GameObject NodoI;
	public GameObject NodoJ;
	public GameObject NodoK;
	public GameObject NodoL;
	public GameObject NodoM;
	public GameObject NodoN;
	public GameObject NodoO;
	public GameObject NodoP;
	public GameObject NodoQ;
	public GameObject NodoR;
	public GameObject NodoS;
	public GameObject NodoT;
	public GameObject NodoU;
	public GameObject NodoV;
	public GameObject NodoW;
	public GameObject NodoX;
	public GameObject NodoY;
	public GameObject NodoZ;
	public GameObject NodoA1;
	public int[,] Adyacencia;
	public GameObject[] nodos_Array;
	void Awake()
	{
		//Asignacion de Nodos.
		NodoA=GameObject.FindGameObjectWithTag("Nodo A");	
		NodoB=GameObject.FindGameObjectWithTag("Nodo B");	
		NodoC=GameObject.FindGameObjectWithTag("Nodo C");	
		NodoD=GameObject.FindGameObjectWithTag("Nodo D");	
		NodoE=GameObject.FindGameObjectWithTag("Nodo E");	
		NodoF=GameObject.FindGameObjectWithTag("Nodo F");	
		NodoG=GameObject.FindGameObjectWithTag("Nodo G");	
		NodoH=GameObject.FindGameObjectWithTag("Nodo H");	
		NodoI=GameObject.FindGameObjectWithTag("Nodo I");	
		NodoJ=GameObject.FindGameObjectWithTag("Nodo J");	
		NodoK=GameObject.FindGameObjectWithTag("Nodo K");	
		NodoL=GameObject.FindGameObjectWithTag("Nodo L");	
		NodoM=GameObject.FindGameObjectWithTag("Nodo M");	
		NodoN=GameObject.FindGameObjectWithTag("Nodo N");	
		NodoO=GameObject.FindGameObjectWithTag("Nodo O");	
		NodoP=GameObject.FindGameObjectWithTag("Nodo P");	
		NodoQ=GameObject.FindGameObjectWithTag("Nodo Q");	
		NodoR=GameObject.FindGameObjectWithTag("Nodo R");	
		NodoS=GameObject.FindGameObjectWithTag("Nodo S");	
		NodoT=GameObject.FindGameObjectWithTag("Nodo T");	
		NodoU=GameObject.FindGameObjectWithTag("Nodo U");	
		NodoV=GameObject.FindGameObjectWithTag("Nodo V");	
		NodoW=GameObject.FindGameObjectWithTag("Nodo W");	
		NodoX=GameObject.FindGameObjectWithTag("Nodo X");	
		NodoY=GameObject.FindGameObjectWithTag("Nodo Y");	
		NodoZ=GameObject.FindGameObjectWithTag("Nodo Z");	
		NodoA1=GameObject.FindGameObjectWithTag("Nodo A1");	
		//Creacion de Arreglo que contiene los nodos.
		nodos_Array=new GameObject[]{NodoA,NodoB,NodoC,NodoD,NodoE,NodoF,NodoG,NodoH,NodoI,NodoJ,NodoK,NodoL,NodoM,NodoN,NodoO,NodoP,NodoQ,NodoR,NodoS,NodoT,NodoU,NodoV,NodoW,NodoX,NodoY,NodoZ,NodoA1};
		//print (nodos_Array [0].transform.position.x);
		//Arreglo de mariz de adyacencia.
		Adyacencia=new int[,]{
			//A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,A1
			{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//A
			{0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//B
			{0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//C
			{0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//D
			{0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//E
			{0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//F
			{0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//G
			{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//H
			{0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//I
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//J
			{0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//K
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//L
			{0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,1,0,0,0,0,0},//M
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0},//N
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},//O
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},//P
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//Q
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0},//R
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},//S
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0},//T
			{0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0},//U
			{0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0},//V
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0},//W
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//X
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},//Y
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},//Z
			{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0}};//A1
	}
		// Update is called once per frame
	void Update () {
		if (transform.position.x > NodoD.transform.position.x) {
			float translation=Time.deltaTime*10;
			Vector3 Posicion_Nodo=NodoD.transform.position;
			transform.position=Vector3.MoveTowards(transform.position,Posicion_Nodo,translation);
			transform.LookAt(transform.position);
			//transform.position=Vector3.RotateTowards(transform.position,Posicion_Nodo,0.10f,translation);
				}
		}

}