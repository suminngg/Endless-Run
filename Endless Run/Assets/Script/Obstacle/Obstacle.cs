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

    // OnBecameInvisible Render와 관련되어 있는 함수이기 때문에 MeshRenderer가 추가되어 있어야 합니다.
    // 화면 밖으로 나가게 되면 게임 오브젝트 삭제합니다.
    private void OnBecameInvisible()
    {
        gameObject.transform.position = new Vector3(0, 0.1f, 5);
        ObjectPooling.objectPool.InsertQueue(gameObject);
    }
}
