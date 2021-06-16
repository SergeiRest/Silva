using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseWheelSlider : MonoBehaviour
{
	[SerializeField] private float _speed;
	[SerializeField] private Transform _start, _finish;
	[SerializeField] private Vector3 _pointToMove;
	[SerializeField] private PlayerStats _stats;
	private Vector3 _startPosition;
    void Start()
    {
		_startPosition = transform.position;
		_pointToMove = new Vector3(Random.Range(_start.position.x, _finish.position.x), _startPosition.y, _startPosition.z);
    }

    
    void Update()
    {
		Moving();
    }

	private void Moving()
	{
		if (transform.position != _pointToMove)
		{
			transform.position = Vector3.MoveTowards(transform.position, _pointToMove, _speed * Time.deltaTime);
		}
		else
		{
			_pointToMove.x = Random.Range(_start.position.x, _finish.position.x);
		}
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.TryGetComponent(out RunProgress progress))
		{
			progress.RunScore++;
			Debug.Log($"QTE Score = {progress.RunScore}");

			if(progress.RunScore >= 100)
			{
				_stats.LoseWeight();
			}
		}
	}
}
