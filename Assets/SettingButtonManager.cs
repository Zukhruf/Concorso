using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingButtonManager : MonoBehaviour {

	public void back (string mainMenu){
		SceneManager.LoadScene (mainMenu);
	}
	public void soundOff(){
		AudioListener.volume = 0f;
	}
	public void soundOn(){
		AudioListener.volume = 1f;
	}
}
