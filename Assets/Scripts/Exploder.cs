using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] private float _maxExplosionForce;

    public void ExplodeCube(Vector3 position, List<Rigidbody> cubes)
    {
        foreach (Rigidbody explodableObject in cubes)
        {
            float distance = Vector3.Distance(position, explodableObject.position);
            Vector3 direction = (explodableObject.position - position).normalized;
            float explosionForce = Mathf.Clamp(_maxExplosionForce / (distance + 1), 0, _maxExplosionForce);
            explodableObject.AddForce(direction * explosionForce, ForceMode.Impulse);
        }
    }
}