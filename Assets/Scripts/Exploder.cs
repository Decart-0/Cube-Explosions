using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private List<Rigidbody> _cubes = new List<Rigidbody>();

    public void PassCubes(List<Rigidbody> cubes)
    {
        _cubes = cubes;
    }

    public void ExplodeCube(Vector3 position)
    {
        foreach (Rigidbody explodableObject in _cubes)
        {
            explodableObject.AddExplosionForce(_explosionForce, position, _explosionRadius);
        }
    }
}