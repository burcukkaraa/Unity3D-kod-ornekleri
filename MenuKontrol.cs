using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuKontrol : MonoBehaviour {

	public GameObject durdurmamenusu;
	public bool durdur;
	public GameObject fon;
	bool seskontrol;


	void Start () {

		seskontrol = true;
		durdur = false;
		fon.GetComponent<AudioSource>().Play();
		
	}
	public void ses()
	{
		if (seskontrol) {
			seskontrol = false;
			fon.GetComponent<AudioSource> ().Stop ();
		} else {
			seskontrol = true;
			fon.GetComponent<AudioSource> ().Play ();
		}
	}
	void Update () {

		if (durdur)

		{
			oyundur(true);

		}
		else 
		{
			oyundur(false);

		}
		if (Input.GetButtonDown ("Cancel"))

		{
			durdurbuton ();
		}

	}

	void oyundur (bool bilgi)
	{
		if (bilgi)
		{
			Time.timeScale = 0.0f;
		}
		else
		{
			Time.timeScale = 1.0f;
		}

		durdurmamenusu.SetActive (bilgi);
	}


	public void durdurbuton()
	{
		if (durdur)
		{
			durdur=false;
		}
		else
		{
			durdur = true;
		}


	

	}

	public void cıkıs()
	{
		Application.Quit ();
	}
}

	

