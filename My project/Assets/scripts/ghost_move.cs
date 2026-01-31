using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ghost_move : MonoBehaviour
{
    public float speed = 2f;
    public float chaseDistance = 5f;
    public Transform pointA;
    public Transform pointB;
    private Transform currentTarget;
    private Transform player;
    private float fixedY;
  
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentTarget = pointA;
        fixedY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(new Vector3(transform.position.x, 0, transform.position.z),
            new Vector3(player.position.x, 0, player.position.z));
        if (distanceToPlayer <= chaseDistance)
        {
            MoveFlat(player.position);
        }
        else
        {
            MoveFlat(currentTarget.position);
            if (FlatDistance(transform.position, currentTarget.position) < 0.2f) 
            {
                currentTarget = currentTarget == pointA ? pointB : pointA;
            }
        }
    }
    void MoveFlat(Vector3 targetPos)
    {
        Vector3 target = new Vector3(
            targetPos.x,
            fixedY,
            targetPos.z
        );
        Vector3 dir = (target - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(
                new Vector3(dir.x, 0, dir.z)
            );
        }
    }
    float FlatDistance(Vector3 a, Vector3 b)
    {
        return Vector3.Distance(
            new Vector3(a.x, 0, a.z),
            new Vector3(b.x, 0, b.z)
        );
    }
}
