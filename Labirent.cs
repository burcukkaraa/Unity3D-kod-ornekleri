using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirent : MonoBehaviour {

	public float seviye = 3;
	float rastgele1 ;
	float rastgele2 ;
	float i = 10 ;
	int v = 0 ;


	void Start () {

		rastgele1 = Random.Range (0, 30);
		rastgele2 = Random.Range (0, 20);
		print (rastgele1);
	
	}
	

	void Update () {

		if (v == 1) {
			if (Time.fixedTime >= (i + rastgele1)) {
				if (transform.position.y >= 0) {
					transform.position += Vector3.down * Time.deltaTime;

					if (transform.position.y <= 0) {
						if (Time.fixedTime >= rastgele2) {
							v = 0;
						}
					}
				}
			} 
		} else if (Time.fixedTime >= rastgele1) {
			if (transform.position.y <= seviye) {
				transform.position -= Vector3.down * Time.deltaTime;

				if (transform.position.y >= seviye) {
					v = 1;
				}
			}
		}
		
	}
}
