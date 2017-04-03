using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigButton : MonoBehaviour {

	public ProblemSolve AnimalList;
	public string Pig = "Pig";

	public void AddPigToList()
	{
	
		AnimalList.Animals.Add (Pig);

	}
}
