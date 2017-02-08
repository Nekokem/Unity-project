using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elseClause : MonoBehaviour {

	public string password;
	public bool userAgreement;

	// Use this for initialization
	void Start () {
		// && = and || = or
		if (password == "OU812" && userAgreement) {
			print ("Correct");
		} 

		else {
			print ("Incorrect");
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