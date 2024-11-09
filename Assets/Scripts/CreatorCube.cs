using UnityEngine;

public class CreatorCube : MonoBehaviour
{
    [SerializeField] private int _factorReductionScale;   

    public Rigidbody CreateCube(Vector3 spawnPoint, Rigidbody prefab)
    {
        Rigidbody newCube = Instantiate(prefab, spawnPoint, Quaternion.identity);
        ChangeCube(newCube);

        return newCube;
    }

    private void ChangeCube(Rigidbody newCube)
    {
        Vector4 randomRGB = new Vector4(Random.value, Random.value, Random.value);
        newCube.transform.localScale /= _factorReductionScale;

        if (newCube.TryGetComponent<Renderer>(out Renderer renderer)) 
        { 
            renderer.material.color = randomRGB;
        }
    }
}