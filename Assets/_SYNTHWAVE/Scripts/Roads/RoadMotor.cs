using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMotor : MonoBehaviour
{
	[SerializeField] float _movementSpeed;
	[SerializeField] float _speedMultiplier;	
	
	[SerializeField] CarCollider _carCollider;

	public float RoadSpeed => _movementSpeed;

	GameManager _gameManager;

	private void Awake()
	{
		_carCollider = FindObjectOfType<CarCollider>();
		_gameManager = FindObjectOfType<GameManager>();
		_carCollider.Collided += StopMovement;
	}

	private void FixedUpdate()	
	{
		_movementSpeed = CalculateRoadSpeed(MusicPlayer.instance.CurrentTrack);

		//Debug.Log($"Road speed: {_movementSpeed}");

		transform.Translate(new Vector3(0, 0, -_movementSpeed * Time.deltaTime));
	}

	public void StopMovement()	
	{
		_movementSpeed = 0;	
	}

	private void OnDisable()	{	_carCollider.Collided -= StopMovement;	}

	float CalculateRoadSpeed(MusicTrack track)
	{
		RoadGenerator roadGen = FindObjectOfType<RoadGenerator>();

		float beatsPerMinute = track.BeatsPerMinute;
		float secondsPerBeat = 1 / beatsPerMinute * 60;
		float secondsPerBar = secondsPerBeat * 4;
		float speed = roadGen.RoadSize / secondsPerBar;

		return speed * _speedMultiplier;
	}



}
