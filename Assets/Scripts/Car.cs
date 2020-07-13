using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Car : MonoBehaviour
{
	[Header("Game Setup")]
	[SerializeField] private Transform[] _lanes;                    // Array of lanes the car will be able to switch between
	[SerializeField] private CarInput _carInput;

	[Header("Speed Settings")]
	[SerializeField] private float _lerpSpeed;						// The speed that the car will switch lanes

	[SerializeField] private int _currentLane;                           // Reference to the current lane the car is in
	[SerializeField] private bool _directionSet;							// Used to check if the player has pressed a key

	private enum Direction { left, right };				// A enum used to store the directions the player is able to move in
	private Direction _currentDirection;                // A new direction for what the player wants to go in

	private Ease _movementEase = Ease.InOutSine;


	private void Awake()
	{
		_carInput = GetComponent<CarInput>();

		// Setting the car lane to be 1 as default
		_currentLane = 1;

	}

	private void Update()
	{
		// Checking for button input and setting the direction based on which button was pressed
		GetDirection();

		// Checking if a direction has been set
		if (_directionSet)
		{
			// Running the ChangeLane() method with the deteced button press
			ChangeLane(_currentDirection);
		}

	}

	private void GetDirection()
	{
		if (!_directionSet)
		{
			if (_carInput.HasSwipedRight)
			{
				_currentDirection = Direction.right;
				_directionSet = true;
			}

			if (_carInput.HasSwipedLeft)
			{
				Debug.Log("Left");
				_currentDirection = Direction.left;
				_directionSet = true;
			}
		}
	}

	void ChangeLane(Direction direction)
	{
		// If the direction received was left and the player isn't in the left most lane
		if (direction == Direction.left && _currentLane != 0)
		{
			// Checking if the lerp hasn't been completed
			if (transform.position != _lanes[_currentLane - 1].position)
			{
				// Lerping from the current lane to the lane towards the left
				transform.DOMove(_lanes[_currentLane - 1].position, _lerpSpeed, false);
			}
			else
			{
				// Decrementing the current lane by 1 and resetting directionSet
				_currentLane--;
				_directionSet = false;

			}

		}
		// If the direction received was right and the player isn't in the right most lane
		else if (direction == Direction.right && _currentLane != _lanes.Length - 1)
		{
			// Checking if the lerp hasn't been completed
			if (transform.position != _lanes[_currentLane + 1].position)
			{
				// Lerping from the current lane to the lane towards the right
				transform.DOMove(_lanes[_currentLane + 1].position, _lerpSpeed, true);
			}
			else
			{
				// Incrementing the current lane by 1 and resetting directionSet
				_currentLane++;
				_directionSet = false;
			}

		}
		else
		{
			_directionSet = false;
			Debug.Log($"Player cannot move to the {direction} anymore");
		}

	}

}
