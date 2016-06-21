using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class StarsDisplay : MonoBehaviour {
	
	public Text stars;
	public  int estrellas=50;
	public enum enoughStars {SUCCESSO,FAILURO};
	// Use this for initialization
	void Start () {
		stars = GetComponent<Text> ();//asi no tengo que arrastrarlo, no necesito buscar un gameobject
		//pq solo busco el component del mismo gameobjectMANERA ELEGANTE DE CONSEGUIR EL TEXTO
		//stars.text = estrellas.ToString ();
		UpdateDisplay();


	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void UpdateDisplay(){
		stars.text = estrellas.ToString ();
	}
	public void AddStars(int amount){
		estrellas += amount;
		stars.text = estrellas.ToString ();// to update display
	}
	public enoughStars UseStars(int amount){
		if (estrellas >= amount) {
			estrellas -= amount;
			stars.text = estrellas.ToString ();
			//print (amount + " estrellas destruidas");
			return enoughStars.SUCCESSO;
		}
			return enoughStars.FAILURO;
	}

}
