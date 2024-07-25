using UnityEngine;

public class CreatorCubes : MonoBehaviour
{
    [SerializeField] private int _factorReductionScale;
  
    public Rigidbody CreateCube(Vector3 spawnPoint)
    {
        GameObject newCube = Instantiate(gameObject);
        SetupCube(newCube, spawnPoint);

        return newCube.GetComponent<Collider>().attachedRigidbody;
    }

    private void SetupCube(GameObject cube, Vector3 spawnPoint)
    {
        Vector4 randomRGB = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        
        cube.GetComponent<Transform>().localScale /= _factorReductionScale;
        cube.GetComponent<Renderer>().material.color = randomRGB;
        cube.GetComponent<Transform>().position = spawnPoint;
    } 
}