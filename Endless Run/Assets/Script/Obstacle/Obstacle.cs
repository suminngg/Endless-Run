using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5.0f;
     
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    // OnBecameInvisible Render�� ���õǾ� �ִ� �Լ��̱� ������ MeshRenderer�� �߰��Ǿ� �־�� �մϴ�.
    // ȭ�� ������ ������ �Ǹ� ���� ������Ʈ �����մϴ�.
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}
