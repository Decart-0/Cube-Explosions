using System.Collections.Generic;
using UnityEngine;

public class ExplosionCube : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    public void ExplodeCube(Vector3 position, List<Rigidbody> cubes)
    {
        foreach (Rigidbody explodableObject in cubes)
        {
            explodableObject.AddExplosionForce(_explosionForce, position, _explosionRadius);
        }
    }
}