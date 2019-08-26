using UnityEngine;

[ExecuteInEditMode]
public class SyncPosition : MonoBehaviour
{
    [SerializeField]
    Transform _target = null;

    void Update()
    {
        transform.localPosition = _target.localPosition;
        transform.localRotation = _target.localRotation;
        transform.localScale = _target.localScale;
    }
}
