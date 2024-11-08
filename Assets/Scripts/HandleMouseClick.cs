using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class HandleMouseClick : MonoBehaviour 
{
    [SerializeField] private SpawnCube _spawnCube;

    private void OnMouseDown()
    {
        _spawnCube.CallSpawnCubes(GetComponent<Rigidbody>());
        Destroy(gameObject);
    }
}