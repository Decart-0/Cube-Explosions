using UnityEngine;

public class CreatorCube : MonoBehaviour
{
    public Cube CreateCube(Vector3 spawnPoint, Cube prefab)
    {
        Cube newCube = Instantiate(prefab, spawnPoint, Quaternion.identity);

        return newCube;
    }
}