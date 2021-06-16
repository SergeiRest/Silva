using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWheelObject : MonoBehaviour
{
	[SerializeField] private Transform _endPoint;
	[SerializeField] private float _returnSpeed; // Скорость с которой возвращается обратно
	private Vector3 _startPosition;
    void Start()
    {
		_startPosition = transform.position;
    }

    void Update()
    {
		MovingBack();
    }

	private void MovingBack()
	{
		transform.position = Vector3.MoveTowards(transform.position, _startPosition, _returnSpeed * Time.deltaTime);
	}

	public void MoveRight(float distance)
	{
		Vector3 step = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
		if (step.x <= _endPoint.transform.position.x)
		{
			transform.position = step;
		}
	}
}
