using UnityEngine;

public class Road : MonoBehaviour
{
	public float GetRoadSize()
	{
		// Getting the size of the mesh in world units		
		return transform.GetChild(0).GetComponent<MeshRenderer>().bounds.size.z;	
	}

}
