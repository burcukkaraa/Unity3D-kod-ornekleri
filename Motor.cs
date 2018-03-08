using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {


	public GameObject oyuncu;
	public GameObject kure;
	public int adet = 50;

    

	public Material [] materyal ;
	int sayi = -1 ;
	int denkle ;



	void Start () {

        

		for (int i = 0; i < adet; i++) 
		{

			sayi++;
			sayi = sayi % materyal.Length;
			kure.GetComponent <Renderer> ().material = materyal [sayi];


			Vector3 position = new Vector3 (Random.Range (-8.0F, 8.0F), 3, Random.Range (-8.0F, 8.0F));
			Instantiate (kure, position, Quaternion.identity);


			kure.name = "T" + materyal [sayi];


			if (sayi > 3) {
				kure.name = "T" + materyal [0];
			} else if (sayi <= 3) {

				kure.name = "T" + materyal [sayi +1];
			}
		}
		
	}
	

}
