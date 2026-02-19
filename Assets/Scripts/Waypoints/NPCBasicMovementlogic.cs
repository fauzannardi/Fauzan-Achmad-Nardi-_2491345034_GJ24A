using UnityEngine;

public class NPCBasicMovementlogic : MonoBehaviour
{
    public WaypointSO route;

    private Vector3 target;

    [SerializeField] private float speedMove = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = route.PointA;
        target = route.PointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speedMove * Time.deltaTime);
        if(transform.position ==  target)
        {
            target = (target == route.PointA) ? route.PointB : route.PointA;

        }
    }
}
