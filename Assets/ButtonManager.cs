using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewPlayGame(string playGame){
		SceneManager.LoadScene (playGame);
	}
	public void Setting(string setting){
		SceneManager.LoadScene (setting);
	}
	public void exitGame(){
		Application.Quit ();
	}
}
