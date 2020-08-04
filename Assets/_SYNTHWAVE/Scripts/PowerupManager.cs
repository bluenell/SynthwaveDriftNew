using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{

	private float _timer;
	private float _duration;
	private bool _powerupActive;

	[SerializeField] List<Powerup> activePowerups;

	public bool CheckIfPowerupIsActive(Powerup powerup)
	{
		if (activePowerups.Contains(powerup))
		{
			return true;
		}
		else
		{
			return false;

		}
	}

	public void AddPowerupToList(Powerup powerupToAdd)
	{
		activePowerups.Add(powerupToAdd);
	}

	public void RemovePowerupFromList(Powerup powerupToRemove)
	{
		activePowerups.Remove(powerupToRemove);
	}

}
