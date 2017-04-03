using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour {

	public List <GameObject> powerUPList;
	public List <GameObject> cubelist;
	public List <GameObject> spherelist;
	public List <GameObject> capsulelist;

	// Use this for initialization
	public void CheckData () {
	
		foreach (GameObject item in powerUPList) 
		{
			print (item);


			switch (item.name) 
			{

			case "Cube":
				cubelist.Add (item);
				break;
			case "Sphere":
				spherelist.Add (item);
				break;
			case "Capsule":
				capsulelist.Add (item);
				break;
			}

		}

	}
}
