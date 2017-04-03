using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//Check for truth with one object
		if (2+2 == 4) {
		
			print (true);
		}
	
		if (2+2 != 5) {
			print (true);
		
		}

		int nums = 2 + 2;
	
		//Check for true and false in a single statement 
		if (nums == 5) {
			print (true);
		} 

		/*else if (nums == 6) {
			print (nums);
		}
		do not use!!*/

		else {
			print (false);
		}

		//Check for three or more values.

		switch (nums) {

		case 6:
			print ("Well done you have" + nums);
			break;
		case 7:
			print ("Too bad you have" + nums);
			break;
		case 8:
			print ("Stop Drilling you have" + nums);
			break;
		default:
			print (nums);
			break;

		}

	}

}
