using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elseClause : MonoBehaviour {

	public string password;
	public bool userAgreement;
	public string favoriteAnimal;
	public int num1 = 4;
	public string cleanRoom;


	// Use this for initialization
	void Start () {
		// && = and || = or
		if (password == "OU812" && userAgreement) {
			print ("Correct");
		} else {
			print ("Incorrect");
		}
			
		if (favoriteAnimal == "Penguine") {
		
			print ("favorite");
		} else {
			print ("not favorite");
		}
	
		if (num1 == 4) {
		
			print ("true");

		} else {
		
			print ("false");
		}
	
		if (cleanRoom == "yes") {
		
			print ("room is clean");
		} else {
		
			print ("room is not clean");
		}
	
	}


}
// else clauses cannot exist without an if statment and is the opposite of an if statment
/* elseif clause is impetween the if and else 
 * do not copy and paste code!!! Never use the else if statment.
 * if statments are only used when the variable is constant or with two opptions. 
 * (if the variable have more then one possible
 * out come then don't use an if statment)
 */