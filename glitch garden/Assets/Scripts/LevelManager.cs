using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public  void LoadLevel(string level){
		SceneManager.LoadScene (level);
	
	}
	public void Quit(){
		Application.Quit ();
		//print ("coming out");
	
	}
	public void LoadNextLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}
