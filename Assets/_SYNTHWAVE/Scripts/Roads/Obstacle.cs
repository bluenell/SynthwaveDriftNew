using UnityEngine;

public class Obstacle : MonoBehaviour, IHittable
{
	GameManager _gameManager;

	void Awake()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	public void Hit()
	{
		//_gameManager.EndCurrentGame();
	}
}