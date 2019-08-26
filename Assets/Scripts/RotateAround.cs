using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    Transform _target = null;

    [SerializeField]
    float _speed = 10.0f;

    [SerializeField]
    Direction _direction = Direction.forward;

    [System.Serializable]
    enum Direction
    {
        forward,
        back,
        right,
        left,
        up,
        down,
    }

    Vector3[] _dir = new Vector3[] {
        new Vector3(0, 0, 1),
        new Vector3(0, 0,-1),
        new Vector3(1, 0, 0),
        new Vector3(-1,0, 0),
        new Vector3(0, 1, 0),
        new Vector3(0,-1, 0),
    };

    void Update()
    {
        Vector3 axis = transform.TransformDirection(_dir[(int)_direction]);
        transform.RotateAround(_target.position, axis, _speed * Time.deltaTime);
    }
}
