using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

	public string owner = "Bob";//scope lives in the class it's a class member
	private string renter = "Kate";
	public string renterDog= "Sugar"; // Can be seen by Unity
	private string renterChild = "Chris"; // Can't be seen by Unity

	public void Awake()
	{
		string cat = "Joe";//can only be seen in Awake
		string food = "Tuna";
		if (cat == "Joe") 
		{
			string mouse = "Helen";
			print (cat + " ate " + mouse);
			print (renter);
		}
		if (food == "Tuna") 
		{
			string mouseFood = "Cheese";
			print (cat + " is distracted by " + food);
		}
		print (renter);
		print (cat);
		print (owner);
	}


	public void Start () 
	{
		string cat = "Frank";
		if (renterDog == "Sugar") {
			print (cat + " is scared of " + renterDog);
		}
		print (cat);
		print (owner);
	}
	
}
