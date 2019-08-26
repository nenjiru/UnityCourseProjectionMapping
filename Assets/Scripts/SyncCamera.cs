using UnityEngine;

[ExecuteInEditMode]
public class SyncCamera : MonoBehaviour
{
    [SerializeField]
    float _fieldOfView = 28f;

    [SerializeField]
    Vector2 _resolution = new Vector2(1920, 1080);

    [SerializeField]
    Camera _renderCamera = null;

    [SerializeField]
    Camera _virtualCamera = null;

    [SerializeField]
    Projector _virtualProjector = null;

    void OnValidate()
    {
        _renderCamera.fieldOfView = _fieldOfView;
        _virtualCamera.fieldOfView = _fieldOfView;
        _virtualProjector.fieldOfView = _fieldOfView;
        _virtualProjector.aspectRatio = _resolution.x / _resolution.y;
    }
}
