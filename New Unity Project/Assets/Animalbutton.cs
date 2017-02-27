using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animalbutton : MonoBehaviour {

	public ProblemSolve AnimalList;
	public string Fish = "Fish";

	public void AddFishToList()
	{
		AnimalList.Animals.Add(Fish);
	
	}

}
