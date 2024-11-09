using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CreatorCube))]

public class SpawnCube : MonoBehaviour
{
    [SerializeField] private float _spawnRadius;

    private CreatorCube _creatorCube;

    public void SpawnCubes(Rigidbody prefab)
    {
        int minCubes = 2;
        int maxCubes = 6;
        int numeCubes = Random.Range(minCubes, maxCubes);

        List<Rigidbody> cubes = new List<Rigidbody>();

        if (prefab.TryGetComponent<Cube>(out Cube component—ube))
        {
            if (component—ube.GetChanceSeparation() > Random.value)
            {
                component—ube.DecreaseChanceSeparation();

                for (int i = 0; i < numeCubes + 1; i++)
                {
                    cubes.Add(_creatorCube.CreateCube(GetRandomSpawnPoint(prefab.transform.position), prefab));
                }

                component—ube.PassCubes(cubes);
            }
        }
    }

    private void Awake()
    {
        _creatorCube = GetComponent<CreatorCube>();
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