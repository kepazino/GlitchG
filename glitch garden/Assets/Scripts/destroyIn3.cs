using UnityEngine;
using System.Collections;

public class destroyIn3 : MonoBehaviour {
	void destroyThis(){
		Destroy (gameObject);
	}
	// Use this for initialization
	void Start () {
		Invoke ("destroyThis", 2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
