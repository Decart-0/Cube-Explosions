using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Cube : MonoBehaviour
{
    [field: SerializeField] private float _chanceSeparation;

    public float ChanceSeparation
    {
        get { return _chanceSeparation; }
        set { _chanceSeparation = value; }
    }

    public Rigidbody GetRigidbody()
    { 
        return gameObject.GetComponent<Rigidbody>();
    }
}