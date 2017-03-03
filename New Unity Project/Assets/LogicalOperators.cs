using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {


	public string string1;
	public string string2;
	public string Cat;
	public string Dog;
	public string Dessert;
	public string Topping;


	public void OnButtonClick () {
	
		if (string1 == "Thing1" && string2 == "Thing2") 
		{
		
			print ("These things are quite tame. Oh so tame.");
		
		}

		if (string1 == "Thing1" || string2 == "Thing2") 
		{

			print ("It's fun to have fun if you know what to do.");
		
		}

		if (string1 != "Thing1" && string2 != "Thing2") 
		{

			print ("Oh what a shame, what a shame, what a shame.");
		
		}
	
		if (Cat == "Meow" && Dog == "Woof") {
		
			print ("There are two animals!"); 
		}
	
		if (Cat == "Meow" || Dog == "Woof") {
		
			print ("One maybe two animals here");
		}

		if (Cat != "Meow" && Dog != "Woof") {
			print ("What animals are these?!");
		}

		if (Dessert == "Brownie" && Topping == "Ice Cream") {
			print ("This is Delicious!!");
		}
		if (Dessert == "Brownie" || Topping == "Ice Cream"){
			print ("Either one is good!");
		}
		if (Dessert != "Brownie" && Topping != "Ice Cream") {
		
			print ("Where's my brownie sunday!");
		}
		if (Dessert == "Carrots" && Topping == "PeanutButter") {
			print ("What???");
		
		}
	}

}
