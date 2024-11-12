using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Renderer))]

public class Cube : MonoBehaviour
{
    [SerializeField] private SpawnerCube _spawnCube;
    [SerializeField] private Exploder _explosionCube;

    private Renderer _renderer;

    [field: SerializeField] public float ChanceSeparation { get; private set; }

    public Rigidbody Rigidbody { get; private set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }

    public void Init(float factorReductionSpawne, float factorReductionScale) 
    {
        _renderer.material.color = new Color(Random.value, Random.value, Random.value);
        transform.localScale /= factorReductionScale;
        ChanceSeparation /= factorReductionSpawne;
    }

    private void OnMouseDown()
    {
        _explosionCube.ExplodeCube(transform.position, _spawnCube.SpawnCubes(this));
        Destroy(gameObject);
    }
}