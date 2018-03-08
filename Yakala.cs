using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;





public class Yakala : MonoBehaviour {


	public GameObject oyuncu;
	public Material[] materyal;
	int sayi ;

	public Text tablo;
	int puan ;

	public int can = 20;
	public Text cantablo;

	float sure;
	public Text suretex;

	float toplam;

	public Text topla;

	public GameObject kazanmenusu;
	public GameObject kaybetmenusu;

	public BolumKontrol deger;



	public int bolum;

	void Start () {



		can = deger.saglık;

		kaybetmenusu.SetActive(false);
		kazanmenusu.SetActive (false);

		tablo.text = "Puan:" + puan.ToString ();
		cantablo.text = "Can:" + can.ToString ();


		sayi = Random.Range (0, 5);
		oyuncu.GetComponent <Renderer> ().material = materyal [sayi];
		print ("T" + materyal [sayi]);




	}




	void OnCollisionEnter( Collision temas)
	{

		Debug.Log("temas ettim: " + temas.gameObject.name); 


		if (temas.gameObject.name=="T"+materyal[sayi]+"(Clone)")
		{
			puan = puan + 10;
			tablo.text = "Puan : " + puan.ToString ();
			Destroy (temas.gameObject);
		}

		else if (temas.gameObject.tag == "dusman")

		{
			can = can - 1;
			cantablo.text = "Can : " + can.ToString();
			Destroy (temas.gameObject);
		}
	}




	void Update ()
	{
		sure += Time.deltaTime;
		suretex.text=sure.ToString("f1");

		if (puan==100)
		{
			bolum = bolum++;
			toplam = 100*can/sure;
			topla.text=toplam.ToString("f1");
			kazanmenusu.SetActive (true);
			Time.timeScale = 0;
		}

		else if (can==0)
		{
			kaybetmenusu.SetActive(true);
			SceneManager.LoadScene(0);

		}

	}	

	public void yenile ()
	{
		SceneManager.LoadScene (0);

	}




}
