using UnityEngine;
using System.Collections;
[RequireComponent(typeof (Rigidbody2D))]
public class enemy : MonoBehaviour {

	//[Range(-1f,5f)]public float currentSpeed=4;//establece un rango en el inspector
	//public  animationWhenWalking;
	private float currentSpeed;
	public GameObject currentTarget;
	[Tooltip("average spawn time")]//this shows a note  of the variables in the inspector
	public float spawnFrequency;
	private Animator animator;

	// Use this for initialization
	void Start () {
		//esto anadiria el rigidbody por script mas facil y rapido, y no lo tengo que hacer desde el menu
		int difficulty=PlayerPrefsManager.GetDifficulty();
		spawnFrequency -= difficulty;//aumenta la freuencia de spawn con mayor dificultad

		gameObject.AddComponent<Rigidbody2D>().isKinematic=true;
		animator = GetComponent<Animator> ();
	}
	/*void OnTriggerEnter2D(Collider2D other){
		Debug.Log (name+" trigger entered");//name is the name of this object
		GameObject currentTarget=other.gameObject as GameObject;
		//print (name + " attacking " + currentTarget);

	}*/

	void StrikeCurrentTarget(float damage){
		if (currentTarget) {
			Health health =currentTarget.GetComponent<Health> ();
			if (health) {
				health.DealDamage (damage);
			}
		}
	}
	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}


	// Update is called once per frame
	void Update () {
		
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			animator.SetBool ("isAttacking", false);
		}


		/*if (Button.selectedDefender) {
			//print (Button.selectedDefender.name + "this is from enemy.cs");
		}*/
		/*if (GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).IsName (animationWhenWalking)){
			//transform.position += Time.deltaTime * Vector3.left * walkSpeed; esto sirve pero tambien lo de abajo
			transform.Translate(Time.deltaTime*Vector3.left*walkSpeed);
		}*/
	}
	public void attack(GameObject obj){
		currentTarget = obj;
	}
}
