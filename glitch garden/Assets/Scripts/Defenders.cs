using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {
	public StarsDisplay starsDisplay;
	public int starCost;
	// Use this for initialization
	void Start () {
		starsDisplay = GameObject.FindObjectOfType<StarsDisplay> ();
	}
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (name+" Defender hit");
		GetComponent<Animator> ().SetBool ("isAttacking", true);
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void AddStars(int stars){
		starsDisplay.AddStars (stars);

	}


}