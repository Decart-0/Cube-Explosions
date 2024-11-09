using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Cube))]

public class HandleMouseClick : MonoBehaviour
{
    [SerializeField] private SpawnCube _spawnCube;
    [SerializeField] private ExplosionCube _explosionCube;
    
    private Rigidbody _rigidbody;
    private Cube _cube;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _cube = GetComponent<Cube>();
    }

    private void OnMouseDown()
    {
        _spawnCube.SpawnCubes(_rigidbody);
        _explosionCube.ExplodeCube(transform.position, _cube.GetChildrenCubes());

        Destroy(gameObject);
    }
}