using UnityEngine;

public class CreatorCube : MonoBehaviour
{
    [SerializeField] private int _factorReductionScale;   

    public Cube CreateCube(Vector3 spawnPoint, Cube prefab)
    {
        Cube newCube = Instantiate(prefab, spawnPoint, Quaternion.identity);
        ChangeCube(newCube);

        return newCube;
    }

    private void ChangeCube(Cube newCube)
    {
        Vector4 randomRGB = new Vector4(Random.value, Random.value, Random.value);
        newCube.transform.localScale /= _factorReductionScale;
        newCube.ChangeColor(randomRGB);
    }
}