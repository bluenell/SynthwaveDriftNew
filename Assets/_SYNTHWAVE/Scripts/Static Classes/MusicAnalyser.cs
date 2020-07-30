public static class MusicAnalyser
{
    public static float GetSecondsPerBeat(MusicTrack track)
	{
		float bpm = track.BeatsPerMinute;
		return (1 / bpm) * 60;
	}

}
