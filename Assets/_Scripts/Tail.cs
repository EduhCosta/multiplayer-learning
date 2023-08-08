using UnityEngine;

public class Tail : MonoBehaviour
{
    [SerializeField] private float delayTime = 0.1f;
    [SerializeField] private float distance = 0.3f;

    public Transform followTransform;
    public Transform networkedOwner;

    private Vector3 _targetPosition;
    private float _moveStep = 10f;

    private void Update()
    {
        _targetPosition = followTransform.position - followTransform.forward * distance;
        _targetPosition += (transform.position - _targetPosition) * delayTime;
        _targetPosition.z = 0f;

        transform.position = Vector3.Lerp(transform.position, _targetPosition, Time.deltaTime * _moveStep);
    }
}
