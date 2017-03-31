using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyInput : MonoBehaviour {


	public InputField money;
	public float MoneyToFloat () 
	{

		return float.Parse(money.text);

	}
	//parse means to change

}
