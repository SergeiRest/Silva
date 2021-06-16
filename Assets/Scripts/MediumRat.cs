using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MediumRat : IPlayerBehaviour
{
	private float _mass = 0.5f;
	private Sprite _playerTexture;
	public void Enter(Rigidbody2D rigidbody2D, SpriteRenderer playerSprite)
	{
		rigidbody2D.mass = _mass;
		//playerSprite.sprite = _playerTexture;
	}

	public void Update()
	{
		Debug.Log(_mass);
	}
}
