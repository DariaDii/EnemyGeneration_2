using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private int _speed = 2;

    private void Update()
    {
        Vector3 direction = _target.transform.position - transform.position;

        transform.position = Vector3.MoveTowards(transform.position,_target.transform.position,_speed*Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(direction);
    }

    public void ChangeTarget(Target target)
    {
        _target = target;
    }
}