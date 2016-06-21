using UnityEngine;
using System.Collections;

public class chick : MonoBehaviour {
	private Animator anim;
	private enemy attacker;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<enemy>();
	}
	void OnTriggerEnter2D (Collider2D collider) {
		GameObject obj = collider.gameObject;

		// Leave the method if not colliding with defender
		if (!obj.GetComponent<Defenders>()) {
			return;
		}

		anim.SetBool ("isAttacking", true);
		attacker.attack (obj);
	}
	// Update is called once per frame
	void Update () {

	}

}//cant finish with a space or an extra line not bracketed