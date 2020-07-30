using System;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{

	GameManager _gameManager;
	PlayerStatsManager _playerStatsManager;


	[SerializeField] private TMPro.TextMeshProUGUI _songNameText;
	[SerializeField] private TMPro.TextMeshProUGUI _distanceTravelledText;
	[SerializeField] private TMPro.TextMeshProUGUI _totalCassettesText;

	private void Awake()
	{
		_gameManager = FindObjectOfType<GameManager>();
		_playerStatsManager = FindObjectOfType<PlayerStatsManager>();
		
	}

	private void Update()
	{
		_songNameText.text = ($"{MusicPlayer.instance.CurrentTrack._trackName.ToUpper()} - {MusicPlayer.instance.CurrentTrack._trackArtist.ToUpper()}");
		_distanceTravelledText.text = ($"{(int)_gameManager.GetDistanceTravelled()} m");
		_totalCassettesText.text = _gameManager.CurrentCassettes.ToString();
		
	}

}