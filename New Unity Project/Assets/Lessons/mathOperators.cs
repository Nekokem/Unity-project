using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathOperators : MonoBehaviour {


	public int addition = 12 + 4;
	public int subtraction = 12 - 4;
	public float division = 5 / 2;
	public int multiplication = 10 * 2;
	public int remainder = 7 % 2;

	// Use this for initialization
	void Start () {

		addition += 9; //add to
		subtraction -= 10; // subtract from
		addition += 3;
		addition = 1; // scrapted everything else
		multiplication *= 4;

	}
	
		// The + added two variable values together. "a + b"
		// The - subtractes the second variable value from the first. "a - b"
		// The * multiplies the two variable values together. "a * b" 
		// The / divides the numerator by th denominator. "a / b" needs to be a float
		// The % divides by a number and gives a remainder
		// The -- ????
		// The ++ ???
		// == makes the values of the variables equal
		//ints never round.
		
}
