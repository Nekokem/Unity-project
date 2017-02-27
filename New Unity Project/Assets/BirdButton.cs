using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdButton : MonoBehaviour {

	public ProblemSolve AnimalList;
	public string Bird = "Bird";


	public void AddBirdToList(){
	
		AnimalList.Animals.Add (Bird);
	
	}

}
