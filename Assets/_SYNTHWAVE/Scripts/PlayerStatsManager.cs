using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
	public PlayerStats PlayerStats;

	public void WriteToPlayerPrefs(string key, int value)
	{
		PlayerPrefs.SetInt(key, value);
	}



}
