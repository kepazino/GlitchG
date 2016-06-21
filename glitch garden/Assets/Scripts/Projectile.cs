using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed, damage;
	public float health = 2;

	// Use this for initialization
	void Start () {
		 //GetComponent<Rigidbody2D> ().AddForce(new Vector2(speed,0))  ;
		//Invoke("DestroyProjectile",10);//IM GONNA TRY ONBECAMEINVISIBLE FOR PRACTICE AND ITS EASIER
		//invisible doesnt work because the body is what needs to become invisible
	}
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (name+" pojectile hitting something");
		if ((other.GetComponent<enemy> ()) || (other.GetComponent<Projectile> ())) {
			other.GetComponent<Health> ().health -= 2;//hadproblems when the variable was static
			Destroy (gameObject);
			//saludEnemigo.beingAttacked = true;
		}

	}
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2 (speed*Time.deltaTime, 0));

	}
	void DestroyProjectile(){
		Destroy (gameObject);
	}
	/*void OnBecameInvisible(){
		DestroyProjectile ();
	}*/

}
