using UnityEngine;
using System.Collections;


public class DefenderSpawner : MonoBehaviour {
	private GameObject defendersParent;
	// Use this for initialization
	private StarsDisplay starsDisplay;


	void Start () {
		
		if (GameObject.Find("defendersParent") ){
			defendersParent= GameObject.Find("defendersParent");
		} else {
			defendersParent=new GameObject ("defendersParent");
		}
		starsDisplay=GameObject.FindObjectOfType<StarsDisplay>();//this is another way of accessing functions 
		//underneath in this script , rather than making them static
	}
	
	// Update is called once per frame
	void Update () {

		/*if ((Button.selectedDefender)&&(Input.GetMouseButtonDown(2))){

			Vector2 posicion=  new Vector2 (Input.mousePosition.x,Input.mousePosition.y);
			GameObject newDefender= Instantiate (Button.selectedDefender, posicion, Quaternion.identity)as GameObject;

		}*/	



	}

	void OnMouseDown(){
		//print (Input.mousePosition);
		Vector2 posicionClickeada = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x,Input.mousePosition.y));
		//^^^ necesario para grabar la posicion clickeada, sino las coordinadas son 214,50,...NEEDS CAMERAMAIN^^^^^PQ????
		if (starsDisplay.UseStars(Button.selectedDefender.GetComponent<Defenders>().starCost)==StarsDisplay.enoughStars.SUCCESSO) {
			Vector2 roundedInput = new Vector2 (Mathf.Round (posicionClickeada.x), Mathf.Round (posicionClickeada.y));
			GameObject newDefender = Instantiate (Button.selectedDefender, roundedInput, Quaternion.identity)as GameObject;
			newDefender.transform.parent = defendersParent.transform;
			starsDisplay.UseStars (newDefender.GetComponent<Defenders>().starCost);
		} 
		else {
			starsDisplay.stars.text = "!";
		}


	}
	void CalculateWorldPointOfMouseClick(){
	
	
	}
}
