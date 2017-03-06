using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

	public string owner = "Bob";//scope lives in the class it's a class member
	private string renter = "Kate";

	public void Awake()
	{
		string cat = "Joe";//can only be seen in Awake

		if (cat == "Joe") 
		{
			string mouse = "Helen";
			print (cat + " ate " + mouse);
			print (renter);
		}
		print (renter);
		print (cat);
		print (owner);
	}


	void Start () 
	{
		string cat = "Frank";
		print (cat);
		print (owner);
	}
	
}
