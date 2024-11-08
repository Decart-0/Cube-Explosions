using UnityEngine;

public class CreatorCube : MonoBehaviour
{
    [SerializeField] private int _factorReductionScale;

    private Vector3 _spawnPoint;
    private Rigidbody _prefab;

    public Rigidbody GetCube(Vector3 spawnPoint, Rigidbody prefab)
    {
        _spawnPoint = spawnPoint;
        _prefab = prefab;

        return CreateCube();
    }

    private Rigidbody CreateCube()
    {
        Rigidbody newCube = Instantiate(_prefab, _spawnPoint, Quaternion.identity);
        ChangeCube(newCube);

        return newCube.GetComponent<Collider>().attachedRigidbody;
    }

    private void ChangeCube(Rigidbody newCube)
    {
        Vector4 randomRGB = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);

        newCube.transform.localScale /= _factorReductionScale;
        newCube.GetComponent<Renderer>().material.color = randomRGB;
    }
}