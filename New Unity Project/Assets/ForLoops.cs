using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {

	public List<string> cars;
	public List<string> music;
	public List<string> food;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < cars.Count; i++) 
		{
			print (cars [i]);
		}

		for (int i = 0; i < music.Count; i++) {
		
			print (music [i]);
		}
		for (int i = 0; i < food.Count; i++) {
		
			print (food [i]);
		
		}
	
	}

}
// ++ = add one