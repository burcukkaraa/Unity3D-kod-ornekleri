using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



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
