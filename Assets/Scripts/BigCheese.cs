using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCheese : EatingObjects
{
	public int Points => 10;

	public override void AddPoints(PlayerStats stats)
	{
		stats.Points += Points;
	}
}

public class SmallCheese : EatingObjects
{
	public int Points => 5;

	public override void AddPoints(PlayerStats stats)
	{
		stats.Points += Points;
	}
}
