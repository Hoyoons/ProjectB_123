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
    public string targetTag = "wall"; // ��� �ݶ��̴��� �±׸� �����մϴ�.

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(targetTag))
        {
            // �浹�� �ݶ��̴��� �±װ� ������ �±׿� ��ġ�� ��� ����Ǵ� �ڵ�
            Destroy(gameObject); // �Ѿ��� �ı��մϴ�.
        }
    }
}
