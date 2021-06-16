using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EatingObjects : MonoBehaviour
{
	public int Points { get; set; }
	public abstract void AddPoints(PlayerStats stats);
}

public enum CheeseType
{
	SmallCheese,
	BigCheese
}