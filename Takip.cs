using System.Collections;
using UnityEngine;


public class Takip: MonoBehaviour {

	public GameObject oyuncu;
	public Vector3 konum;




	void Start () {

		konum = transform.position - oyuncu.transform.position;
		
	}
	

	void Update () {

		transform.position = oyuncu.transform.position + konum;
		
	}
}
