using System.Threading;
using UnityEngine;

public class CameraPulse : MonoBehaviour
{
	private float _beatTimeRemaining;
	private float _timer;

	private float _pulseFadeTime;
	private float _pulsePower;

	private Vector3 _startPosition;

	private void Awake()
	{
		_startPosition = transform.position;
	}


	private void Update()
	{
		_timer += Time.deltaTime;
		transform.position = _startPosition;

		if (_timer > MusicAnalyser.GetSecondsPerBeat(MusicPlayer.instance.CurrentTrack))
		{
			_timer = 0;
			StartPulse(0.5f, 0.2f);
		}
	}

	private void LateUpdate()
	{
		if (_beatTimeRemaining > 0)
		{
			float xAmount = Random.Range(-1f, 1f) * _pulsePower;
			float yAmount = Random.Range(-1f, 1f) * _pulsePower;

			transform.position += new Vector3(xAmount, yAmount, 0);

			_pulsePower = Mathf.MoveTowards(_pulsePower, 0, _pulseFadeTime * Time.deltaTime);
		}		
	}

	public void StartPulse(float length, float power)
	{
		_pulsePower = power;
		_beatTimeRemaining = length;

		_pulseFadeTime = power / length;
	}

	



}
