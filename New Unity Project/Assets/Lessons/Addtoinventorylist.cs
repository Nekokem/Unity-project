using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addtoinventorylist : MonoBehaviour {

	public lists myInventory;
	public string myWeapon;


	public void AddToList()
	{
		myInventory.myWeaponList.Add(myWeapon);
	}


}
