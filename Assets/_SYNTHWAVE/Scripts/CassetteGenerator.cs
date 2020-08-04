using System.Collections;
using UnityEngine;

public class CassetteGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] _cassettePrefab;
    private void Awake()
    {
        GameObject cassette = Instantiate(_cassettePrefab[Random.Range(0, _cassettePrefab.Length)], GetCassSpawnPos(), this.transform.rotation);
        cassette.transform.parent = this.transform;
    }
    private Vector3 GetCassSpawnPos()
    {
        string name = this.gameObject.name;
        float xPos = 0;
        switch (name)
        {
            case "Group 011(Clone)":
                xPos = -5;
                break;
            case "Group 101(Clone)":
                xPos = 0;
                break;
            case "Group 110(Clone)":
                xPos = 5;
                break;
        }
        return new Vector3(xPos, 1, this.transform.position.z);
    }
}