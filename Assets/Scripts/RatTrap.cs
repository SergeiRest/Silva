using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RatTrap : MonoBehaviour
{
	private Image _progressBar;
	private float _winScore = 0.5f;
	private bool isSelected = false;

	private void Start()
	{
		_progressBar = GetComponent<Image>();
		_progressBar.fillAmount = _winScore;
		StartCoroutine(TrapProgressDecrease());
	}

	private void Update()
	{
		AddScore();
	}

	private IEnumerator TrapProgressDecrease()
	{
		while (_winScore > 0)
		{
			yield return new WaitForSeconds(0.2f);
			SubtractScore();
		}
		yield return new WaitForSeconds(1f);
		Destroy(this.gameObject);
	}

	public void AddScore()
	{
		if (isSelected)
		{
			_winScore += 0.1f;
			_progressBar.fillAmount = _winScore;
			Debug.Log("Zalupa");
		}
	}

	private void SubtractScore()
	{
		_winScore -= 0.01f;
		_progressBar.fillAmount = _winScore;
	}
	public void DisableClick()
	{
		if (isSelected)
		{
			isSelected = false;
			Debug.Log("Disabled");
		}
	}

	public void EnableClick()
	{
		if (!isSelected)
		{
			isSelected = true;
			Debug.Log("Enabled");
		}
	}
}
