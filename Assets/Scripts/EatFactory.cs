using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFactory : MonoBehaviour
{
	private EatingObjects eating;
    public void GetEat(string type, PlayerStats stats)
	{
		switch (type)
		{
			case "BigCheese":
				eating = new BigCheese();
				break;
			case "SmallCheese":
				eating = new SmallCheese();
				break;
		}
		eating.AddPoints(stats);
	}
}
