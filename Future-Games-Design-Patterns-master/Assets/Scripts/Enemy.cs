using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    private Transform tf;
    private int wayPointIndex = 0;
    private float smooth;
    private Quaternion target;
    private float tiltAngle = 60.0f;

    private void Start()
    {

        tf = WPSystem.points[0];
    }

    private void Update()
    {
        Vector3 dir = tf.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, tf.position) < 0.4f)
        {
        tf = WPSystem.points[wayPointIndex];
            GetNextWaypoint();
        }
    }


    private void GetNextWaypoint()
    {
        if(wayPointIndex >= WPSystem.points.Length -1)
        {
            Destroy(gameObject);
        }
   
        wayPointIndex++;
    }
}
