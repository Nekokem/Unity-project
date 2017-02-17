using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			print ("I hit A");
			}
		}


	}
// you need Update for key inputs
/* getkey = both down and up
 * getkeydown = only when pressed(down)
 * getkeyup = only when not pressed(up)*/