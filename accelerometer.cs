using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.IO;
using System.Text;
//using Excel= Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;




public class accelerometer : MonoBehaviour {

    Vector3 ilkPozisyon;
    public Rigidbody rb;


    void Start()
    {
        ilkPozisyon = Input.acceleration;
        rb = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
		rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")) * 10);
		rb.AddForce(new Vector3(Input.acceleration.x - ilkPozisyon.x,0, -Input.acceleration.y + ilkPozisyon.y) * 30);
    }

	
	
	
       
}
