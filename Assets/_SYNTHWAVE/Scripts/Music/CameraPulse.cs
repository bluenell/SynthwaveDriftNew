using System.Threading;
using UnityEngine;

public class CameraPulse : MonoBehaviour
{
	private float _beatTimeRemaining;
	private float _timer;

	private float _pulseFadeTime;
	private float _pulsePower;

	private float _startingFOV;
	private Camera _camera;

	private void Awake()
	{
		_camera = GetComponent<Camera>();
		_startingFOV = _camera.fieldOfView;
	}

	private void Update()
	{
		_timer += Time.deltaTime;
		_camera.fieldOfView = _startingFOV;

		if (_timer > MusicAnalyser.GetSecondsPerBeat(MusicPlayer.instance.CurrentTrack))
		{
			_timer = 0;
			StartPulse(0.25f, 3f);
		}
	}

	private void LateUpdate()
	{
		if (_beatTimeRemaining > 0)
		{
			float amount = 1 * _pulsePower;

			_camera.fieldOfView += amount;
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
