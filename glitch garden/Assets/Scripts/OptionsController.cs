using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class OptionsController : MonoBehaviour {
	public Slider VolumeSlider,DifficultySlider;//THIS IS SO MUCH MORE TIDY!!!!!!!!!!!!1
	private MusicManager music;

	// Use this for initialization
	void Start () {
		VolumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		music = GameObject.FindObjectOfType<MusicManager>();//this find the music in the scene
		DifficultySlider.value=PlayerPrefsManager.GetDifficulty();

	}
	
	// Update is called once per frame
	void Update () {
		PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
		music.GetComponent<AudioSource> ().volume = VolumeSlider.value;



	}
	public void SaveAndExit(){//para que aparezca en el inspector se hace public
		PlayerPrefsManager.SetDifficulty (Mathf.RoundToInt(DifficultySlider.value));
		GameObject.FindObjectOfType<LevelManager> ().LoadLevel ("01aStart");
		PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
	}


	public void Default(){
		VolumeSlider.value = 0.5f;
		DifficultySlider.value = 2;
	}
}
