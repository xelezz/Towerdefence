using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 1f;

    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        bulletDamage();
    }

 
    private void bulletDamage()
    {

        Vector3 dir = target.position - transform.position;
        float dist = speed * Time.deltaTime;

        if(dir.magnitude <= dist)
        {
            Destroy(gameObject);
            return;
        }

        transform.Translate(dir.normalized * dist, Space.World);

    }
  public void SeekTarget(Transform _target)
    {
        target = _target;
    }
}
