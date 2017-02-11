using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFstatment : MonoBehaviour {
	// else clauses are opposite if statmanets
	public bool myBool; // default false
	public string myString = "Dog";
	public int num1; // default 0
	public int num2;

	// Use this for initialization
	void Start () {
		//if's have to be in a function
		if (myBool)
		{
			print (true);
		}

		if(myString == "Cat") 
		{
			print ("Cat");
		}

		if (!myBool) {
			print (false);
		}

		if(myString != "Cat")//!= is not true
		{
			print (myString);
		}

		if (num1 + num2 == 7) {
		
			print (7);

		}

		if(num1 + num2 != 7){

			print (num1 + num2);
		}

		/* Bad if statments
		 * public string animal = "cat"
		 * if(animal == "cat")
		 * print("cat")
		 * if(animal == "dog")
		 * print("dog")
		 * if(animal == "bird")
		 * print("bird")
		 * if(animal == "mole")
		 * print("mole")
		 */

	}
	

}
