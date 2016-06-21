using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelMusicChangeArray;


	void Awake () {
		DontDestroyOnLoad(gameObject);
		GetComponent<AudioSource> ().volume = PlayerPrefsManager.GetMasterVolume();
		}
		
	
void OnLevelWasLoaded(int level){
		bool differentClip =!(levelMusicChangeArray[level] == GetComponent<AudioSource> ().clip);
		
		if (levelMusicChangeArray [level]&&differentClip) {
			GetComponent<AudioSource> ().clip = levelMusicChangeArray [level];
			GetComponent<AudioSource> ().Play();
			GetComponent<AudioSource> ().loop = true;
			GetComponent<AudioSource> ().volume = PlayerPrefsManager.GetMasterVolume();
		}

}
	void Update(){
		//GetComponent<AudioSource> ().volume = PlayerPrefsManager.GetMasterVolume();
	}

}
