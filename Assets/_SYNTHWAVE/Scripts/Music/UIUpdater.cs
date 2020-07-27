using System;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{

	GameManager _gameManager;

	[SerializeField] private TMPro.TextMeshProUGUI _songNameText;
	[SerializeField] private TMPro.TextMeshProUGUI _distanceTravelledText;
	[SerializeField] private TMPro.TextMeshProUGUI _cassettesText;

	private void Awake()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	private void Update()
	{
		_songNameText.text = ($"{MusicPlayer.instance.CurrentTrack._trackName.ToUpper()} - {MusicPlayer.instance.CurrentTrack._trackArtist.ToUpper()}");
		_distanceTravelledText.text = ($"{(int)_gameManager.GetDistanceTravelled()} m");
		_cassettesText.text = PlayerStats.CurrentCassettes.ToString();
	}

}