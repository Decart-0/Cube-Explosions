using System.Collections.Generic;
using UnityEngine;

public class ExplosionCube : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    private List<Rigidbody> _createdCubes;

    public void GetCubes(List<Rigidbody> cubes, Vector3 position) 
    {
        _createdCubes = cubes;
        Explode(position);
    }

    private void Explode(Vector3 position)
    {
        foreach (Rigidbody explodableObject in _createdCubes)
        {
            explodableObject.AddExplosionForce(_explosionForce, position, _explosionRadius);
        }
    }
}