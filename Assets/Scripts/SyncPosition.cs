using UnityEngine;

[ExecuteInEditMode]
public class SyncPosition : MonoBehaviour
{
    [SerializeField]
    Transform _target = null;

    [SerializeField]
    bool useSyncPosition = false;

    [SerializeField]
    bool useSyncRotation = false;

    [SerializeField]
    bool useSyncScale = false;

    void Update()
    {
        if (useSyncPosition == true)
        {
            transform.localPosition = _target.localPosition;
        }
        if (useSyncRotation == true)
        {
            transform.localRotation = _target.localRotation;
        }
        if (useSyncScale == true)
        {
            transform.localScale = _target.localScale;
        }
    }
}
