using UnityEngine;

[RequireComponent(typeof(Cube))]

public class HandlerMouseClick : MonoBehaviour
{
    [SerializeField] private SpawnCube _spawnCube;
    [SerializeField] private Exploder _explosionCube;
    
    private Cube _cube;

    private void Awake()
    {
        _cube = GetComponent<Cube>();
    }

    private void OnMouseDown()
    {
        _spawnCube.SpawnCubes(_cube);
        _explosionCube.ExplodeCube(transform.position);

        Destroy(gameObject);
    }
}