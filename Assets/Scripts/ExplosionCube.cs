using System.Collections;
using UnityEngine;

public class ExplosionCube : MonoBehaviour
{
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _delayTime;

    private void OnMouseUpAsButton()
    {
        StartCoroutine(DelayedMethod());
    }

    private IEnumerator DelayedMethod()
    {
        yield return new WaitForSeconds(_delayTime);

        foreach (Rigidbody explodableObject in gameObject.GetComponent<SpawnCubes>().CreatedCubes)
        {
            explodableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }

        Destroy(gameObject);
    }
}