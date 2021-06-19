using System;
using System.Collections.Generic;
using UnityEngine;

public class LoadedItems : MonoBehaviour
{
	[SerializeField] private Sprite _smallRat;
	[SerializeField] private Sprite _mediumRat;

	private static Dictionary<int, Sprite> _ratSprites = new Dictionary<int, Sprite>();

	private void Start()
	{
		_ratSprites.Add(1, _smallRat);
		_ratSprites.Add(2, _mediumRat);
	}

	public static Sprite GetSprite(int index)
	{
		var selectedSprite = _ratSprites[index];
		return selectedSprite;
	}
}
