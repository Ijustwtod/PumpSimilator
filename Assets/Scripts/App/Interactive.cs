using UnityEngine;

public class Interactive : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private Ray _ray;
    private RaycastHit _hit;
    [SerializeField] private float _distance;
    Outline outline;
    private BoxCollider _lastBoxCollider;

    private void Ray()
    {
        _ray = _camera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
    }

    private void Update()
    {
        Ray();
        DrawRay();
        Interact();
    }

    private void DrawRay()
    {
        if (Physics.Raycast(_ray, out _hit, _distance))
            Debug.DrawRay(_ray.origin, _ray.direction * _distance, Color.green);

        if (_hit.transform == null)
            Debug.DrawRay(_ray.origin, _ray.direction * _distance, Color.red);
    }
    private void Interact() 
    {
        if (_hit.transform != null && _hit.transform.GetComponent<BoxCollider>()) 
        {
            _lastBoxCollider = _hit.transform.GetComponent<BoxCollider>();
            _lastBoxCollider.GetComponent<Outline>().enabled = true;
            Debug.DrawRay(_ray.origin, _ray.direction * _distance, Color.blue);
        }
        if(_hit.transform == null && _lastBoxCollider != null) 
        {
            _lastBoxCollider.GetComponent<Outline>().enabled = false;
            _lastBoxCollider = null;
        }
    }
}
