using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
	[SerializeField] private List<MusicTrack> _tracks = new List<MusicTrack>();

	AudioSource _audioSource;


	public static MusicPlayer instance;
	public MusicTrack CurrentTrack;


	private void Awake()
	{
		if (instance != null)
		{
			Destroy(instance);
		}
		else
		{
			instance = this;
		}
		
		_audioSource = GetComponent<AudioSource>();
		UpdateTrack(_tracks[Random.Range(0, _tracks.Count + 1)]);
	}

	private void UpdateTrack(MusicTrack track)
	{
		_audioSource.clip = track.Track;
		CurrentTrack = track;
		_audioSource.Play();
	}


}
