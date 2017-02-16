using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
	//data type first then identifier
	//array is a container of variibles

	public string[] animals;

	public string animal = "Wolf";

	int i = 0;
	public string[] colors;

	public string[] food;

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
			

		while (i < colors.Length) 
		{
			print (colors[i]);
			i++;
		}
	
		i = 0;
		while (i < animal.Length) {
			print (animal[i]);
			i++;
		}
			
		i = 0;
		while (i < food.Length) {
			print (food [i]);
			i++;
		}

		print("Done.");
	}

}


//if and while loops are syntactally the same.
//while as long as it's true it will never stop running.
//iterator makes something that increases pr decreases like "i"
//very fast
//.length is a paramiter of an arry, a collection of strings.