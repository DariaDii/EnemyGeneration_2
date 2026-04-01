using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    private int _speed = 4;
    private Transform _currentPoint;
    private float _distanceToTargetPoint = 0.1f;

    private void Start()
    {
        _currentPoint = _startPoint;        
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,_currentPoint.position,_speed*Time.deltaTime);

        if (Vector3.Distance(transform.position, _currentPoint.position) < _distanceToTargetPoint)
        {
            if (_currentPoint == _startPoint)
                _currentPoint = _endPoint;
            else
                _currentPoint = _startPoint;
        }
    }
}