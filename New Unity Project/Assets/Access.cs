using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Access : MonoBehaviour {

	public Scope home;

	// Use this for initialization
	void Start () {
		print (home.owner);
		home.Awake ();
		print (home.renterDog);
	}
	

}
//private = only the script can see it
//publuc = other scripts can see it