using UnityEngine;
using System.Collections;


[RequireComponent (typeof(enemy))]
public class Fox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		GameObject obj = other.gameObject;
		if (!other.GetComponent<Defenders> ()) {
			return;}//se sale de la funcion si no se choca con un defender
		if (other.GetComponent<cactus> ()) {//si el objeto con el que colisiona es uno que tiene el script cactus
			Invoke ("foxjump", 1f);

		} else if (other.GetComponent<Defenders> ()) {
			//GetComponent<Animator> ().Play ("Fox Attack", 0);
			GetComponent<enemy>().attack (obj);
			GetComponent<Animator> ().SetBool ("isAttacking", true);

					
		}
	}
	// Update is called once per frame
	void Update () {
		/*if (GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName ("fox jump")) {
			//transform.position += Time.deltaTime * Vector3.left * walkSpeed; esto sirve pero tambien lo de abajo
			transform.Translate(Time.deltaTime*Vector3.left*GetComponent<enemy>().walkSpeed*2);
			//COMO SE VE AQUI, LA VARIABLE NO TIENE PQ SER ESTATICA PARA PODER ACCEDEr

		}*/
	}
	void foxjump(){
		GetComponent<Animator> ().SetTrigger("FoxJump");
	}
}
