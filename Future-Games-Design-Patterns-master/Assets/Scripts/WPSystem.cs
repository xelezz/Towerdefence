using UnityEngine;

public class WPSystem : MonoBehaviour
{
    public static Transform[] points;

    void Awake()
    {
       
        points = new Transform[transform.childCount];
        for(int i = points.GetLowerBound(0); i <= points.GetUpperBound(0); ++i)
        {
            points[i] = transform.GetChild(i);
        }
    }
}