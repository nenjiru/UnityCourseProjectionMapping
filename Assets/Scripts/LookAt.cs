using UnityEngine;

[ExecuteInEditMode]
public class LookAt : MonoBehaviour
{
    [SerializeField]
    Transform _target = null;

    void Update()
    {
        transform.LookAt(_target);
    }
}
