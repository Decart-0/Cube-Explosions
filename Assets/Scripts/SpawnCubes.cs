using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private int _factorReduction;

    static private float _randomChance = 1.0f;

    private void OnMouseUpAsButton()
    {
        if (Random.Range(0f, 1f) < _randomChance)
            CreateCubes();

        Destroy(gameObject);
        _randomChance /= _factorReduction;
    }

    private void CreateCubes()
    {
        int numeCubes = Random.Range(2, 6);

        for (int i = 0; i < numeCubes; i++)
        {
            SetupCube();
            Instantiate(_cube);
        }
    }

    private void SetupCube()
    {
        _cube.GetComponent<Transform>().localScale /= _factorReduction;
        _cube.GetComponent<Renderer>().material = new Material(Shader.Find("Standard"));
        Vector4 randomRGB = new Vector4(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        _cube.GetComponent<Renderer>().material.SetColor("_Color", randomRGB);
    }
}