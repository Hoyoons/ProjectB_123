using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;

    private EnemyPath thePath;
    private int currentPoint;
    private bool reachEnd;

    // Start is called before the first frame update
    void Start()
    {
        if(thePath == null)
        {
            thePath = FindObjectOfType<EnemyPath>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(reachEnd == false)
        {
            transform.LookAt(thePath.points[currentPoint]);     //���ʹ� ���ݹ����� ���ؼ� ����.
            transform.position =
                Vector3.MoveTowards(transform.position, thePath.points[currentPoint].position, moveSpeed * Time.deltaTime);
            
            if(Vector3.Distance(transform.position , thePath.points[currentPoint].position) < 0.01f)
            {
                currentPoint += 1;
                if(currentPoint >= thePath.points.Length)
                {
                    reachEnd = true;
                }
            }
        }
    }
}
