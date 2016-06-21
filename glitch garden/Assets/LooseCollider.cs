using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LooseCollider : MonoBehaviour {
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.GetComponent<enemy> ()) {
			
			levelManager.LoadLevel ("03b loose");

		}
	}

}
