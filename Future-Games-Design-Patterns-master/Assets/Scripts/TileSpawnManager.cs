using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class TileSpawnManager : ScriptableObject
{
    public string prefabName;
    //public GameObject entityToSpawn;
    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}