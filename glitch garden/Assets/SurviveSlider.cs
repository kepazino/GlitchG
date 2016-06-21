using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SurviveSlider : MonoBehaviour {
	private Slider surviveSlider;
	private LevelManager levelManager;
	private AudioSource winSound;
	public Text winText;
	//public AudioClip sonidoGanador;
	public float Timer;

	// Use this for initialization
	void Start () {
		winSound =gameObject.GetComponent<AudioSource> ();
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		surviveSlider = GameObject.FindObjectOfType<Slider> ();
		surviveSlider.value = Timer;
		winText.enabled = false;
		print ("winSound" + winSound);

	}
	
	// Update is called once per frame
	void Update () {
		surviveSlider.value -= Time.deltaTime;
		if (surviveSlider.value <= 0) {
			winSound.Play();
			winText.enabled = true;
			//AudioSource.PlayClipAtPoint(sonidoGanador,Vector2.zero,0.5f);esta distorsionado
			Invoke("loadNextLevel",winSound.clip.length);
		}
	}
	void loadNextLevel(){
		levelManager.LoadNextLevel ();
	}
}
