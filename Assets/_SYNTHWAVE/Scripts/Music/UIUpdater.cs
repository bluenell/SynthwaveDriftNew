using System;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{

	GameManager _gameManager;

	[SerializeField] private TMPro.TextMeshProUGUI _songNameText;
	[SerializeField] private TMPro.TextMeshProUGUI _distanceTravelledText;

	private void Awake()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	private void Start()
	{
		_songNameText.text = ($"{MusicPlayer.instance.CurrentTrack._trackName.ToUpper()} - {MusicPlayer.instance.CurrentTrack._trackArtist.ToUpper()}");		
	}

	private void Update()
	{

		_distanceTravelledText.text = ($"{(int)_gameManager.GetDistanceTravelled()} m");
	}

}