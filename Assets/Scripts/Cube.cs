using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Renderer))]

public class Cube : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Renderer _renderer;

    [field: SerializeField] public float ChanceSeparation { get; private set; }

    public void ReduceChanceSeparation(float value)
    {
        ChanceSeparation /= value;
    }

    public Rigidbody GetRigidbody()
    { 
        return _rigidbody;
    }

    public void ChangeColor(Color color)
    {
        _renderer.material.color = color;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }
}