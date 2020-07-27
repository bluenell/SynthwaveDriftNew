using UnityEngine;

public static class PlayerStats
{
	private static int _currentCassettes;
	private static int _topScore;
	public static int CurrentCassettes { get => _currentCassettes; private set => _currentCassettes = value; } 

	public static void SpendCassetes(int value)
	{
		if (value < _currentCassettes)
		{
			_currentCassettes -= value;
		}
		else
		{
			Debug.Log("Cannot Purchase: Not enough cassettes");
		}		
	}

	public static void IncreaseCassettes(int value)
	{
		_currentCassettes += value;
	}

}
