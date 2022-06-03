using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rigidBody = default;
    [SerializeField] private float _playerVelocity = default;

    void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidBody.position += new Vector3(_playerVelocity, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidBody.position -= new Vector3(_playerVelocity, 0, 0) * Time.deltaTime;
        }
    }
}
