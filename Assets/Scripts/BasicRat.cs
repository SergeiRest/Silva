using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class BasicRat : IPlayerBehaviour
{
	private float _mass = 1f;
	private Sprite _playerSprite = LoadedItems.GetSprite(1);
	public void Enter(Rigidbody2D rigidbody2D, SpriteRenderer playerSprite)
	{
		playerSprite.sprite = _playerSprite;
		rigidbody2D.mass = _mass;
	}

	public void Update()
	{
		Debug.Log(_mass);
	}
}

