using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _chanceSeparation;
    [SerializeField] private float _factorReduction;
    [SerializeField] private List<Rigidbody> _childrenCubes = new List<Rigidbody>();

    public void PassCubes(List<Rigidbody> cubes)
    {
        _childrenCubes = cubes;
    }

    public List<Rigidbody> GetChildrenCubes() 
    {
        return _childrenCubes;
    }

    public float GetChanceSeparation()
    {
        return _chanceSeparation;
    }

    public void DecreaseChanceSeparation()
    {
        _chanceSeparation /= _factorReduction;
    }
}