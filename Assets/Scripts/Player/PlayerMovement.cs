using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D _rigidbody;
	private Animator _animator;
	private float speed = 3f;
	public int verticalAxis = 0;
	public int horizontalAxis = 0;
    void Start()
    {
		_rigidbody = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
    }


    void Update()
    {
		Moving();
    }

	private void Moving()
	{
		transform.Translate(new Vector3(horizontalAxis, verticalAxis, 0) * speed * _rigidbody.mass * Time.deltaTime);
		ChangeAnimation();
	}

	public void ChangeRotation(Vector3 axis)
	{
		transform.localScale = axis;
	}

	private void ChangeAnimation()
	{
		if (horizontalAxis > 0 || horizontalAxis < 0)
		{
			_animator.SetFloat(AnimatorPlayerController.States.Run, 1);
		}
		else if (verticalAxis > 0 || verticalAxis < 0)
		{
			_animator.SetFloat(AnimatorPlayerController.States.Up, verticalAxis);
		}
		else
		{
			_animator.SetFloat(AnimatorPlayerController.States.Run, 0);
			_animator.SetFloat(AnimatorPlayerController.States.Up, 0);
		}
	}
}
