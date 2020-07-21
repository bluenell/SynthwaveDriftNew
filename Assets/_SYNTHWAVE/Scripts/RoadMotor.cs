using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMotor : MonoBehaviour
{
	[SerializeField] float _movementSpeed;
	[SerializeField] float _speedMultiplier;	

	
	[SerializeField] CarCollider _carCollider;

	private void Awake()
	{
		_carCollider = FindObjectOfType<CarCollider>();
		_carCollider.Collided += StopMovement;
	}

	private void FixedUpdate()	
	{
		float speed = CalculateRoadSpeed(MusicSelector.instance.CurrentTrack.BeatsPerMinute);
		Debug.Log($"Road speed: {speed}");

		transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));	
	}

	public void StopMovement()	{	_movementSpeed = 0;	}

	private void OnDisable()	{	_carCollider.Collided -= StopMovement;	}

	float CalculateRoadSpeed(float bpm)
	{
		RoadGenerator roadGen = FindObjectOfType<RoadGenerator>();

		Debug.Log($"Beats per Minute: {bpm}");

		float beatsPerSecond = bpm / 60; Debug.Log($"Beats per Second: {beatsPerSecond}");
		float secondsPerBeat = (1 / bpm) * 60; Debug.Log($"Seconds per Beat: {secondsPerBeat}");
		float secondsPerBar = secondsPerBeat * 4; Debug.Log($"Seconds per Bar:  { secondsPerBar}");

		float speed = roadGen.RoadSize / secondsPerBar;

		return speed * _speedMultiplier;
	}



}
