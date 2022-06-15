using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Animator animator;
    public float speed = 5.0f;
     
    void Update()
    {
        if (GameManager.instance.condition == false) return;

        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.enabled = true;
        }
    }

    // OnBecameInvisible Render�� ���õǾ� �ִ� �Լ��̱� ������ MeshRenderer�� �߰��Ǿ� �־�� �մϴ�.
    // ȭ�� ������ ������ �Ǹ� ���� ������Ʈ �����մϴ�.
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0.1f, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}
