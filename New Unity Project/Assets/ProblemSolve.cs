using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemSolve : MonoBehaviour {

	public List<string> Animals;

	// Use this for initialization
	void Start () {

		foreach (string item in Animals) {
			if (item == "Cat") {
				print (item);
			} 
		
		}
		
		}



	}
