using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

//.=floating number needs an f 

//ints are whole numbers and take less memory 
//bools are true or false nothing else. 

//strings need " " it's a string of words/letters it's nice not required. all variables start wiht lower-case 
//name = identifier 
//identifiers can't start with numbers. 

// classes don't get () 

public class Syntax : MonoBehaviour { 

	//varibles are changible pieces of data 

	public string myString = "Hello World"; 
	public string myOtherString = "1"; 
	public int myInt = 1; 
	public float myFloat = 1.2f; 
	public bool myBool = false; 

	// Use this for initialization 
	void Start () { 
		print("Hello world"); 

	} 

	// Update is called once per frame 
	void Update () { 

	} 
} 