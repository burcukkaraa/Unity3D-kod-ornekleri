using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

  void  OnGUI (){
  string yazi = "Input.acceleration: " + Input.acceleration;
  yazi += "\nInput.deviceOrientation: " + Input.deviceOrientation;
  yazi += "\nScreen.orientation: " + Screen.orientation;
  GUI.Label( new Rect( 0, 0, Screen.width, Screen.height ), yazi );
  if( GUI.Button( new Rect( 400, 0, 100, 50 ), "Orientation" ) )
  {
    if( Screen.orientation == ScreenOrientation.Portrait )
      Screen.orientation = ScreenOrientation.LandscapeLeft;
    else
      Screen.orientation = ScreenOrientation.Portrait;
  }
}


	
	void Start ()
    {
		
	}
	
	
	void Update () 
    {
		
	}
}
