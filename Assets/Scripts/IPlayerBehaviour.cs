using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerBehaviour
{
	void Enter(Rigidbody2D rigidbody2D, SpriteRenderer _playerSprite);
	void Update();
}
