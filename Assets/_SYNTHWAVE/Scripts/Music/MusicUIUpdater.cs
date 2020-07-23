using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicUIUpdater : MonoBehaviour
{
	[SerializeField] private TMPro.TextMeshProUGUI _songName;

	private void Start()
	{
		_songName.text = ($"{MusicPlayer.instance.CurrentTrack._trackName.ToUpper()} - {MusicPlayer.instance.CurrentTrack._trackArtist.ToUpper()}");		
	}
}