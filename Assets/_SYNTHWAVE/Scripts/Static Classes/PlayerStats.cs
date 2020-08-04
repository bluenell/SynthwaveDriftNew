using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerStats")]

public class PlayerStats : ScriptableObject
{
	
   [SerializeField]	private int _totalCassettes;

	private int _topScore;
	public int TotalCassettes { get => _totalCassettes; set => _totalCassettes = value; } 

	

	public void SpendCassetes(int value)
	{
		if (value < _totalCassettes)
		{
			_totalCassettes -= value;
		}
		else
		{
			Debug.Log("Cannot Purchase: Not enough cassettes");
		}		
	}

	public void IncreaseCassettes(int value)
	{
		_totalCassettes += value;
	}

}
