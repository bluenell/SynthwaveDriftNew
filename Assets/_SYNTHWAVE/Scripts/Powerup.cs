using UnityEngine;

public class Powerup : Collectable
{
    [Header("Powerup Settings")]
    [SerializeField] float _powerupDuration;

    protected float _timeRemaining;
    protected bool _isActive;

	protected PowerupManager _powerupManager;

	public float TimeRemaining => _timeRemaining;
    public bool IsActive => _isActive;

	void Awake()
	{
		_powerupManager = FindObjectOfType<PowerupManager>();	
	}

    private void Update()
	{
		if (_isActive)		
			DecreaseTimeRemaining();		
	}

    void DecreaseTimeRemaining()
	{
        _timeRemaining -= Time.deltaTime;

		if (_timeRemaining <= 0)
		{
			_isActive = false;
			_powerupManager.RemovePowerupFromList(this);
		}
	}

	protected void ExtendDuration()
	{
		_timeRemaining = _powerupDuration;
	}

}
