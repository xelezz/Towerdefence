using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    public WaypointType type;
    //static readonly int shPropColor = Shader.PropertyToID("_Color");


    private void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position,(type.wayPoints[type.startPoint]));
        if (type.Enable)
        {
            if (dist > type.distance)
            {
                Move();
            }
            else
            {
                if (!type.random)
                {
                    if (type.startPoint + 1 == type.wayPoints.Length)
                    {
                        type.startPoint = 0;
                    }
                    else
                    {
                        type.startPoint++;
                    }
                }
                else
                {
                    type.startPoint = Random.Range(0, type.wayPoints.Length);
                }
            }
        }
        //Vector3 forward = transform.TransformDirection(Vector3.forward) * Time.deltaTime;
        //Debug.DrawRay(transform.position, forward, Color.green);
    }
    

    public void Move()
    {
        gameObject.transform.LookAt(type.wayPoints[type.startPoint],transform.position);
        gameObject.transform.position += gameObject.transform.forward * type.speed * Time.deltaTime;
        //gameObject.transform.Rotate(90.0f, 0.0f, 0.0f, Space.World);

    }
  
}
