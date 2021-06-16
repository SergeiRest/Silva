using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	[SerializeField] private int _horizontalAxis;
	[SerializeField] private int _verticalAxis;
	[SerializeField] private GameObject _player;
	[SerializeField] private int _rotationAxis;
	private PlayerMovement _playerMovement;

	private void Start()
	{
		_playerMovement = _player.GetComponent<PlayerMovement>();
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		_playerMovement.horizontalAxis = _horizontalAxis;
		_playerMovement.verticalAxis = _verticalAxis;
		_playerMovement.ChangeRotation(new Vector3(_rotationAxis, 1, 1));
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		_playerMovement.horizontalAxis = 0;
		_playerMovement.verticalAxis = 0;
	}
}
