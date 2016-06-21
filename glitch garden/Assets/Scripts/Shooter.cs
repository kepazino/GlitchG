using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject projectile;
	public Transform gun;
	private GameObject projectileParent;
	private Animator animador;
	private EnemySpawner myLineSpawner;
	// Use this for initialization
	void Start () {
		animador = GetComponent<Animator> ();
		setMyLaneSpawner ();
		print (transform.position.y);
		//InvokeRepeating ("disparo", 1, 2);
		//this is my way look down
		/*if (GameObject.FindObjectOfType<Projectile> ()) {
			projectileParent = GameObject.FindObjectOfType<Projectile> ().gameObject;
		} else {
			//projectileParent=GameObject.Find("Projectiles").gameObject;
			//projectileParent = Instantiate (projectile, Vector3.down, Quaternion.identity)as GameObject;
			projectileParent = new GameObject ("Projectiles");//no need to instantiate^^^
		}*/
			
		if (GameObject.Find ("Projectiles")) {
			projectileParent = GameObject.Find ("Projectiles");
		} else {
			projectileParent = new GameObject ("Projectiles");
		}

	}
	void setMyLaneSpawner(){
		EnemySpawner[] Spawners = GameObject.FindObjectsOfType<EnemySpawner> ();//store all the spawners en un array
		foreach(EnemySpawner spawner in Spawners){
			if(spawner.transform.position.y==transform.position.y){
				myLineSpawner = spawner;
				print (spawner.transform.position);
				return;//this exits the function
			}
		}
		Debug.LogError (name + "hasnt got a spawner ahead");
	}
	
	// Update is called once per frame
	void Update () {
		print ("defender in the lane" + defenderInTheLane ());
		animador.SetBool ("isAttacking", defenderInTheLane());
		//Debug.DrawLine (transform.position, transform.position + 10 * Vector3.right);

	}
	void disparo(){
			GameObject proyectile = Instantiate (projectile, gun.position, Quaternion.identity) as GameObject;
			proyectile.transform.parent = projectileParent.transform;
	}
	bool defenderInTheLane(){
		if (myLineSpawner.transform.childCount <= 0) {
			return false;
		}
		foreach (Transform enemy in myLineSpawner.transform) {
			if (enemy.transform.position.x > transform.position.x) {
				return true;}//sale de la funcion automaticamente
			
		}
		//RaycastHit other;
		//Debug.DrawLine (transform.position,transform.position +Vector3.right);
		//Physics.Raycast(transform.position,transform.position+ Vector3.right*10,out other);
		//Physics.Raycast(transform.position,transform.position+Vector3.right,out other,10);
		//return (myLineSpawner.transform.childCount>0)&&(myLineSpawner.transform.GetChild(0).transform.position.x>transform.position.x);
		return false;//if they are at the back of me and there are children ie none of the previous conditions has been met
	}
			
}
