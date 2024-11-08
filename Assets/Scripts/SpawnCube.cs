using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CreatorCube))]
[RequireComponent(typeof(ExplosionCube))]

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private int _factorReduction;
    [SerializeField] private float _chanceSeparation;
    [SerializeField] private float _spawnRadius;

    private CreatorCube _creatorCube;
    private ExplosionCube _explosionCube;

    public void CallSpawnCubes(Rigidbody prefab) 
    {
        SpawnCubes(prefab);
    }

    private void Awake()
    {
        _creatorCube = GetComponent<CreatorCube>();
        _explosionCube = GetComponent<ExplosionCube>();
    }

    private void SpawnCubes(Rigidbody prefab)
    {
        int minCubes = 2;
        int maxCubes = 6;
        int numeCubes = Random.Range(minCubes, maxCubes);

        List<Rigidbody> cubes = new List<Rigidbody>();

        if (_chanceSeparation > Random.Range(0f, 1f))
        {
            _chanceSeparation /= _factorReduction;

            for (int i = 0; i < numeCubes + 1; i++)
            {
                cubes.Add(_creatorCube.CallCreateCube(GetRandomSpawnPoint(prefab.transform.position), prefab));
            }

            _explosionCube.GetCubes(cubes, prefab.position);
        }
    }

    private Vector3 GetRandomSpawnPoint(Vector3 transform)
    {
        float randomAngle = Random.Range(0f, 2 * Mathf.PI);
        float randomDistance = Random.Range(0f, _spawnRadius);
        float x = transform.x + Mathf.Cos(randomAngle) * randomDistance;
        float z = transform.z + Mathf.Sin(randomAngle) * randomDistance;

        return new Vector3(x, transform.y, z);
    }
}