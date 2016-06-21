using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {
	public GameObject[] Enemies;
	public List<int> listaAleatoria;
	public float timer;
	public int lane;
	// Use this for initialization
	void Start () {
		lane = Mathf.RoundToInt (transform.position.x);
		//SpawnEnemy();



	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject enemy in Enemies) {
			if (isTimeToSpawn (enemy)) {
				SpawnEnemy (enemy);
			}
		}
	}

	bool isTimeToSpawn(GameObject enemy){
		float threshold = (1 / (enemy.GetComponent<enemy> ().spawnFrequency )* Time.deltaTime/8);//spawn frequency 
		/*spawn frequency of two seconds would make the spawn probability of spawning of 0.5 every second
		 divide by five at the end to make it even less likelyand because we have five lines
		 */
		return (Random.value<threshold);
	}
	
	
	//MYWAY WITH A TIMMER	
		/*timer+=Time.deltaTime;
		foreach (GameObject enemy in Enemies) {
			if (isTimeToSpawn (enemy)) {
				SpawnEnemy (enemy);
				timer += 1;
			}
		}
	}*/
	/*void SpawnEnemy(){
		foreach (int listelement in listaAleatoria) {
			//int i = Random.Range (0, 3);
			Vector2 position = new Vector2 (10, listelement);
			GameObject newEnemy = Instantiate (Enemies [listelement], position, Quaternion.identity)as GameObject;
		}
	}*/

	/*bool isTimeToSpawn(GameObject enemigo){
		return((Mathf.Round(timer)%enemigo.GetComponent<enemy>().spawnFrequency)==0);
	}*/

	void createRandomList(){
		List<int> listaAleatoria = new List<int>();
		while (listaAleatoria.Count < 3) {
			int nuevoAleatorio = Random.Range (0, 6);
			if (!listaAleatoria.Contains (nuevoAleatorio))
				listaAleatoria.Add (nuevoAleatorio);
		}
		foreach (int i in listaAleatoria) {
			print (i);
		}

	}

	void SpawnEnemy(GameObject enemy){
		GameObject newEnemy = Instantiate (enemy, this.transform.position, Quaternion.identity) as GameObject;
		newEnemy.transform.parent = this.transform;
	}
}
