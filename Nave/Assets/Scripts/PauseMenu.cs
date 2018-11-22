using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			if(GameIsPaused){
				Resume();
			}else {
				Pause();
			}
		}
	}
	//codigo para pausar jogo
	public void Resume(){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
	//depende de uma cena a ser criada, implementação futura
	public void LoadMenu(){
		Debug.Log("Loading menu...");
	}

	public void QuitGame(){
		Debug.Log ("Quitting game...");
	}
}
