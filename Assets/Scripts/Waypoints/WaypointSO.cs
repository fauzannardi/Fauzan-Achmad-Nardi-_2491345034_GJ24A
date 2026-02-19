using UnityEngine;


[CreateAssetMenu(menuName = "WaypointSO", fileName = " RouteData" )]
public class WaypointSO : ScriptableObject
{
    public Vector3 PointA;
    public Vector3 PointB;
}
