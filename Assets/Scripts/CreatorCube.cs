using UnityEngine;

public class CreatorCube : MonoBehaviour
{
    [SerializeField] private int _factorReductionScale;
    
    public Rigidbody CallCreateCube(Vector3 spawnPoint, Rigidbody prefab)
    {
        return CreateCube(spawnPoint, prefab);
    }

    private Rigidbody CreateCube(Vector3 spawnPoint, Rigidbody prefab)
    {
        Rigidbody newCube = Instantiate(prefab, spawnPoint, Quaternion.identity);
        ChangeCube(newCube);

        return newCube;
    }

    private void ChangeCube(Rigidbody newCube)
    {
        Vector4 randomRGB = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);

        newCube.transform.localScale /= _factorReductionScale;
        newCube.GetComponent<Renderer>().material.color = randomRGB;
    }
}