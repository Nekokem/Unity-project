using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

	public InputField display;


	public void AddNumber (int number)
	{
	
		display.text += number.ToString();
	}

	public void AddOperator (string op) 
	{
		
		display.text += op;

	}
	// Use this for initialization
	void Start () {
		
	}

}
