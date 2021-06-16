using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
	private Dictionary<int, IPlayerBehaviour> _behaviorMap;
	private IPlayerBehaviour _currentBehavior;
	private int _currentState = 1;

	

	private void SetBehaviour(IPlayerBehaviour newBehaviour, Rigidbody2D rigidbody2D, SpriteRenderer spriteRenderer)
	{
		_currentBehavior = newBehaviour;
		_currentBehavior.Enter(rigidbody2D, spriteRenderer);
	}

	private IPlayerBehaviour GetBehaviour(int index)
	{
		_currentState = index;
		var type = _behaviorMap[index];
		return type;
	}

	private void SetBehaviourByDefault()
	{
		SetBasicBehaviour();
	}

	public void InitBehaviors()
	{
		_behaviorMap = new Dictionary<int, IPlayerBehaviour>();
		_behaviorMap[1] = new BasicRat();
		_behaviorMap[2] = new MediumRat();
		SetBehaviourByDefault();
		_currentBehavior.Update();
	}

	public void SetBasicBehaviour()
	{
		_currentBehavior = _behaviorMap[1];
	}

	public void FattenTheRat(Rigidbody2D playerRigidbody, SpriteRenderer playerSprite)
	{
		if (_currentState < _behaviorMap.Count)
		{
			_currentState++;
			var behaviour = GetBehaviour(_currentState);
			SetBehaviour(behaviour, playerRigidbody, playerSprite);
		}
		else
			Debug.Log("Крыса и так жирная");
	}

	public void ShrinkTheRat(Rigidbody2D playerRigidbody, SpriteRenderer playerSprite)
	{
		if (_currentState <= _behaviorMap.Count && _currentState != 1)
		{
			_currentState--;
			var behaviour = GetBehaviour(_currentState);
			SetBehaviour(behaviour, playerRigidbody, playerSprite);
		}
		else
			Debug.Log("Крыса и так дрищь");
	}
}
