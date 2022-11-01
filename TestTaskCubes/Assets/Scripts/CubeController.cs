using UnityEngine;

public class CubeController : MonoBehaviour
{
    public static float Speed = 5, Distance = 5;
    private float _startPositionZ, _endPositionZ;
    private Rigidbody _rb;
    private Vector3 _forward;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _forward = transform.forward;
        _startPositionZ = transform.position.z;
    }


    void FixedUpdate()
    {
        _endPositionZ = _startPositionZ + Distance;
        _rb.MovePosition(transform.position + _forward * Speed * Time.fixedDeltaTime);
        if (transform.position.z >= _endPositionZ) Destroy(this.gameObject);
    }
}
