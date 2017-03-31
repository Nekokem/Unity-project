using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour {

	public MoneyInput moneyInput;

	public string productName = "Coke";
	public float productPrice = 1.50f;


	float VentProduct (float money) 
	{
		float change = 0;

		if (money >= productPrice) 
		{
		
			print ("Vending " + productName + ".");
			change = money - productPrice;

		}
			

		return change;

	}


	public void ButtonClick () 
	{
	
		print ("$" + VentProduct (moneyInput.MoneyToFloat()) + " is your change");
	

	}
}
