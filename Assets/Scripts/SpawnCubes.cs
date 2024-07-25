using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    [SerializeField] public List<Rigidbody> CreatedCubes;

    [SerializeField] private CreatorCubes _creatorCubes;
    [SerializeField] private int _factorReduction;
    [SerializeField] private float _chanceSeparation;
    [SerializeField] private float _spawnRadius;

    private void OnMouseUpAsButton()
    {
        int minCubes = 2;
        int maxCubes = 6;
        int numeCubes = Random.Range(minCubes, maxCubes);
        List<Rigidbody> cubes = new List<Rigidbody>();

        if (_chanceSeparation > Random.Range(0f, 1f)) 
        {
            _chanceSeparation /= _factorReduction;

            for (int i = 0; i < numeCubes; i++)
            {
                cubes.Add(_creatorCubes.CreateCube(GetRandomSpawnPoint()));
            }

            CreatedCubes = cubes;
        }
    }

    private Vector3 GetRandomSpawnPoint()
    {
        float randomAngle = Random.Range(0f, 2 * Mathf.PI);
        float randomDistance = Random.Range(0f, _spawnRadius);
        float x = transform.position.x + Mathf.Cos(randomAngle) * randomDistance;
        float z = transform.position.z + Mathf.Sin(randomAngle) * randomDistance;

        return new Vector3(x, transform.position.y, z);
    }
}