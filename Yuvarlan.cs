using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuvarlan : MonoBehaviour {



	public float hiz ;


	void Update () {

		Vector3 yuvarla = new Vector3 (Random.Range (-20.0F, 20.0F), 0, Random.Range (-20.0F, 20.0F));
		GetComponent<Rigidbody> ().AddForce (yuvarla * hiz * Time.deltaTime);
		
	}
}
