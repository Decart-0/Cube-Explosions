using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private int _factorReduction;
    [SerializeField] private float _chanceSeparation;
    [SerializeField] private float _spawnRadius;

    public void GetPrafab(Rigidbody prefab) 
    {
        SpawnCubes(prefab);
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

            for (int i = 0; i < numeCubes; i++)
            {
                cubes.Add(GetComponent<CreatorCube>().GetCube(GetRandomSpawnPoint(prefab.transform.position), prefab));
            }

            GetComponent<ExplosionCube>().GetCubes(cubes, prefab.position);
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