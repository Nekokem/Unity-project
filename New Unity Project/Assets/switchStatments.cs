using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchStatments : MonoBehaviour {

	public enum ColorsChoices {RED,GREEN,BLUE}; //enums can add choices and move things around and not mess it up.
	public ColorsChoices playercolor;

	public int FoodChoices = 3;
	public int Math = 1;

	public enum GameStates
	{
		LOADING,
		STARTING,
		PLAYING,
		ENDING
	}

	public GameStates currentGameState = GameStates.LOADING;

	// Use this for initialization
	void Start () {
	

		switch (playercolor)
		{

		case ColorsChoices.RED:
			print("This gives access to all power-ups");
			break;

		}
		switch (playercolor)
		{

		case ColorsChoices.GREEN:
			print("This gives access to all weapons");
			break;

		}

		switch (playercolor)
		{

		case ColorsChoices.BLUE:
			print("Just Dies");
			break;


		/*default:   // prints any other thing solution
			print (color);
			break;*/
		}
	
		switch (FoodChoices) {

		case 3:
			print ("Very Expensive.");
			break;
		case 2:
			print ("Not very expensive but not cheep.");
			break;
		case 1:
			print ("Cheap.");
			break;
		default:
			print ("Free!!");
			break;
		}
	
		switch (Math) {

		case 1:
			print ("I can do this!!");
			break;
		case 2:
			print ("I hate math");
			break;
		case 3:
			print ("WHY DID YOU HAVE TO ADD LETTERS!!!");
			break;
		case 4:
			print ("I'm out!");
			break;
		}
	}


}

// switchs are better then if/else
// to variable for us
//Enum give us constant values you can compare it to a value
// enums are bette thee switch
// switchs are for more then two answers