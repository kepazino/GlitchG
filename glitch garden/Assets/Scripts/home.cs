using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class home : MonoBehaviour {
	public float tiempo=2;
	void Comienzo(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	
	}

	// Use this for initialization
	void Start () {
		Invoke("Comienzo",tiempo);
		GetComponent<AudioSource> ().volume = PlayerPrefsManager.GetMasterVolume ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
