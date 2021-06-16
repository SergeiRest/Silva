using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerStats : MonoBehaviour
{
	private Rigidbody2D _playerRigidbody;
	private SpriteRenderer _playerSprite;
	private int _points = 10;
	public event Action OnPointsValueChanged;
	[SerializeField] private PlayerStates _playerStates;
	public int Points
	{
		get { return _points; }
		set { _points = value; }
	}

	private void Start()
	{
		_playerRigidbody = GetComponent<Rigidbody2D>();
		_playerSprite = GetComponent<SpriteRenderer>();

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		string typeName = collision.tag;
		try
		{
			var eat = new EatFactory();
			eat.GetEat(typeName, this);
			Destroy(collision.gameObject);
			AddPoint();
			_playerStates.ChangeBehaviour(_playerRigidbody, _playerSprite);
		}
		catch
		{
			
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		Debug.Log($"Stats {Points}");
	}

	private void AddPoint()
	{
		this.OnPointsValueChanged?.Invoke();
	}
}
