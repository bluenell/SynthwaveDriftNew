using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Music")]
public class MusicTrack : ScriptableObject
{
	public AudioClip Track;
	[HideInInspector] public int BeatsPerMinute => _bpm;
	
	public string _trackName;
	public string _trackArtist;

	[SerializeField] private int _bpm;

}
