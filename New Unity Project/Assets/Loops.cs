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

	public string[] utauloids;

	public string[] clothes;

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
			
		foreach (string item in colors) { //this says for each item that is a string in the colors array,
			if (item == "Yellow") {      //check if the item = yellow and if it does print yellow
				print (item);			//if not print not yellow
			} 
			else {
				print ("Not Yellow");
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