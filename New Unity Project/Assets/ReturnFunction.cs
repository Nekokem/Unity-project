using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunction : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	GameObject firstPlayer;


	public string[] deepThoughts;
	public int i = 0;

	GameObject ChooseFirstPlayer ()
	{
		int randNum = Random.Range (1, 3);
		GameObject player;


		switch (randNum) 
		{
		case 1:
			return player1;
		case 2:
			return player2;
		default:
			return player3;
		}
	}

	string Messages () 
	{
		if (i >= deepThoughts.Length)
		{
			i = 0;
		}

		return deepThoughts [i++];
	}

	public void OnButtonCLick()
	{
		print (Messages ());
	}


	void Start () {
		float[] scores = { 24f, 68f, 98f, 50f, 100f };
		print (Average (scores));
		firstPlayer = ChooseFirstPlayer ();
		int num1 = 9248493;
		int num2 = 7736428;
		float[] customers = { 55f, 47f, 79f, 90f, 105f, 130f };
		print (AverageCustomersInWeek(customers));
	}

	float Sum (float num1, float num2)
	{
	
		float sum;
		sum = num1 + num2;

		return sum;

	}

	float Average (float[] scores)
	{
		float sum = 0;
		float average;

		foreach (float score in scores) 
		{
		
			sum += score;
		
		}

		average = sum / scores.Length;

		return average;
	}
	float AverageCustomersInWeek(float[] customers)
	{
		float sum = 0;
		float averageCustomer;

		foreach (float customer in customers) {
		
			sum += customer;
		}
		averageCustomer = sum / customers.Length;

		return averageCustomer;
	}

	int Difference (int num1, int num2)
	{
		int sum = 0;
		sum = num1 - num2;
		return sum;
	}

	string WaterFountain ()
	{
	
		return "Water";
	}

	float VendingMechine (float money) 
	{
		float coke = 1.50f;
		float change = 0f;
		if (money >= coke) {
			change = money - coke;
		}
		print ("One Coke Dispenced.");
		return 1.50f;
	
	}

}
