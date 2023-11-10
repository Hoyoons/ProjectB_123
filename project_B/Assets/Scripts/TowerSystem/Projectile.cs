using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed;
    public float damagedAmount;
    public bool hasDamaged;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Enemy" && !hasDamaged)
        {
            other.GetComponent<EnemyHealthController>().TakeDamange((int)damagedAmount);
            hasDamaged = true;
        }

        Destroy(gameObject);
    }
    public string targetTag = "wall"; // 대상 콜라이더의 태그를 지정합니다.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {
            // 충돌한 콜라이더의 태그가 지정한 태그와 일치할 경우 실행되는 코드
            Destroy(gameObject); // 총알을 파괴합니다.
        }
    }
}
