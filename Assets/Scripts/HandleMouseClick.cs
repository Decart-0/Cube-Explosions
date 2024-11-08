using UnityEngine;

public class HandleMouseClick : MonoBehaviour 
{
    [SerializeField] private CubeManager _cubeManager;

    private void OnMouseDown()
    {
        _cubeManager.GetPrafab(GetComponent<Rigidbody>());
        Destroy(gameObject);
    }
}