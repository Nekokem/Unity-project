using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;

public class lists : MonoBehaviour {

	public List<string> myFoodList;
	public List<string> myHouseList;
	public List<string> myWeaponList;
	//lists are not a function it's an object.
	public string[] myWeaponArray;

	// Use this for initialization
	void Start () {
		myWeaponList.Add ("Sword");
		//myWeaponList.Remove ("Ax");
		myWeaponList.Add ("Bow");
		//myWeaponList.RemoveAt (1);


		myFoodList.Add("Sushi");
		myFoodList.Add ("Plum");
		myFoodList.Remove ("Tomato");

		myHouseList.Add ("Table");
		myHouseList.Add ("Kitchen");
		myHouseList.Add ("Chair");
		myHouseList.Add ("Bathroom");
	}


	public void AddToList(){
		myWeaponList.Add ("Stick");	
	}
}
//array doesn't change while playing the game
//list is dynamic