using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFunction : MonoBehaviour {

	public float temp = 50.0f;

	int num1 = 5;
	int num2 = 3;

	void AddNum() 
	{
		int sum;
		sum = num1 + num2;
		print (sum);

	}

	public void ChangeTempToF (){
		float sum;
		sum = ((temp * 9 / 5) + 32);
		print (sum);
	
	}

	public void ChangeTempToC ()
	{
		float sum;
		sum = ((temp - 32) * 5 / 9);
		print (sum);

	}
}
/*functions are a set of instructions. grouping together a lot of commands 
 * into one thing you can call*/
/* voids run a certain commands and doesn't give anything back*/ 
//how to call use the name you use and you need the () with it