using UnityEngine;

public class Magnet : Powerup, ICollectable
{
	[Header("Magnet Setting")]
	[SerializeField] float _radius;
	[SerializeField] GameObject _rangeVisualiser;

	public void Collect()
	{
		ActivatePowerup();
	}

	void Update()
	{
		if (_isActive)
		{
			CastMagnetSphere();
			return;
		}
	}

	void ActivatePowerup()
	{
		if (_powerupManager.CheckIfPowerupIsActive(this))
		{
			ExtendDuration();
			return;
		}

		_powerupManager.AddPowerupToList(this);
		_isActive = true;
	
	}

	void CastMagnetSphere()
	{


		Collider[] colliders = Physics.OverlapSphere(Vector3.zero, _radius);

		foreach (var collider in colliders)
		{
			Cassette cassette = collider.GetComponent<Cassette>();

			if (cassette != null)
			{
				cassette.Collect();
			}
		}


	}
}
