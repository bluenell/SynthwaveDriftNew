using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Music")]
public class MusicTrack : ScriptableObject
{
	public AudioClip Track;
	[HideInInspector] public int BeatsPerSecond => _bpm / 60;

	[SerializeField] private string _trackName;
	[SerializeField] private string _trackArtist;
	[SerializeField] private int _bpm;

}
