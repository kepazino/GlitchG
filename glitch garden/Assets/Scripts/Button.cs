using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	private Button[] buttonArray;
	public  GameObject prefab;
	public static GameObject selectedDefender;//because there is only one selected in the entiregame, 
	//as this will be the one to put on screen


	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button> ();//pilla todos los objetos con script button de la escena
		//NEEDS THE S AFTER OBJECT

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		//print ("button clicked");
		foreach (Button thisButton in buttonArray){//thisbutton es el nombre que le ponemos a cADA elemento del array
			thisButton.GetComponent<SpriteRenderer> ().color = Color.black;//sabiendo ahora el nombre simplemente lo manipulamos aqui
		}
		GetComponent<SpriteRenderer> ().color =Color.white;//other way without the coordinates to set a color
		selectedDefender=prefab;//lo hemos anadido a cada uno arrastrandolo en el inspector

		//print (selectedDefender.name);

	}


	/*void OnMouseOver(){
		print ("button clicked");
		GetComponent<SpriteRenderer> ().color = new Vector4 (1, 1, 1, 1);
	}
	void OnMouseExit(){
		print ("button clicked");
		GetComponent<SpriteRenderer> ().color = new Vector4 (0, 0, 0, 1);
	}*/
}