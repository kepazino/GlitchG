using UnityEngine;
using System.Collections;

public class autoLoadNextLevel : MonoBehaviour {
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GetComponent<LevelManager> ();
		Invoke ("LoadNext", 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void LoadNext(){
		levelManager.LoadNextLevel ();
	}
}
