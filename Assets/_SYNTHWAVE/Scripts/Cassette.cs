using System;
using UnityEngine;

public class Cassette : Collectable, ICollectable
{

	GameManager _gameManager;

	void Awake()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	public void Collect()
	{
		_gameManager.CassettesPerRun++;
		Destroy(this.gameObject);
	}

	




}
