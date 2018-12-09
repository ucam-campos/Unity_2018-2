using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour {
	static int pontos;

	public static int pegaPontos(){
		return pontos;

	}

	public static void adiciona(){
	pontos++;

	}

	public static void recomecar(){
	pontos = 0;

	}
}
