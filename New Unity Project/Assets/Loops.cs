using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
	//data type first then identifier
	//array is a container of variibles

	public string[] animals;

	public string animal = "Wolf";

	// Use this for initialization
	void Start () {

		foreach (string animalInAnimals in animals) {
			if (animal == animalInAnimals) {
				print ("I have a match, it is " + animalInAnimals);
			}

			else {
				print (animalInAnimals + " is not a match");
			}
		
		}
	
		
		
		}
	

}
