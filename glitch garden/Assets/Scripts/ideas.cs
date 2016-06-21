using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ideas : MonoBehaviour {
	//we need to check from the ones we have left
	//pick an non used number from the ones remaining
	// Use this for initialization
	void Start () {
		 


		List<int> listaAleatoria = new List<int>();
		while (listaAleatoria.Count < 11) {
			int nuevoAleatorio = Random.Range (0, 20);
			if (!listaAleatoria.Contains (nuevoAleatorio))
				listaAleatoria.Add (nuevoAleatorio);
		}

		for (int i = 0; i < 11; i++) {
			//print (listaAleatoria[i]);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
