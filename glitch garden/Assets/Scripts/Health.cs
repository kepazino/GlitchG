using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health=100f;//just in case it doesnt get set in the inspector


	// Use this for initialization
	void Start () {

			
	}

	void Update () {
		
	//takingDamage ();
	}

		
	
	/*void OnTriggerEnter2D(Collider2D other){
		if ((imEnemy)&&(other.GetComponent<Defenders> ()) ){
				beingAttacked = true;
			}
		 if( (!imEnemy)&&(other.GetComponent<enemy> ()) ){
				beingAttacked = true;
			
		}
	}*/
	/*void OnTriggerExit2D(Collider2D other){
		if ((imEnemy)&&(other.GetComponent<Defenders> ()) ){
			beingAttacked = false;
		}
		if( (imEnemy==false)&&(other.GetComponent<enemy> ()) ){
			beingAttacked = false;
			print ("being attacked is " + beingAttacked);

		}
	}*/
	/*void takingDamage(){
		if ((beingAttacked)&&(health>0)){
			//print (name + "being attacked");
			health -=Time.deltaTime*15 ;}
		if (health <= 0) {
			Destroy (gameObject);}	
	}*/
	public void DealDamage(float damage){
		health -= damage;
		if (health < 0) {
		//optionally tigger an animation
		DestroyObject();
		}
	}

	public void DestroyObject(){
		Destroy (gameObject);// i could call this from a death animation 
	}

}