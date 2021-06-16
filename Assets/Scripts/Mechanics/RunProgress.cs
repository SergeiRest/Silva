using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunProgress : MonoBehaviour
{

	private int _runScore = 0;
	/// <summary>
	/// Подсчёт очков при беге в колесе
	/// </summary>
	public int RunScore
	{
		get { return _runScore; }
		set
		{
			_runScore = value;
			Debug.Log(_runScore);
		}
	}
}
