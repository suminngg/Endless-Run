using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling objectPool;

    // 오브젝트 풀에 담을 게임 오브젝트를 설정합니다.
    public GameObject tire;

    // 게임 오브젝트를 담을 수 있는 자료구조 Queue를 생성합니다.
    public Queue<GameObject> queue = new Queue<GameObject>();

    void Start()
    {
        objectPool = this;

        for(int i = 0; i < 5; i++)
        {
            GameObject obj = Instantiate(tire, new Vector3(0, 0.1f, 5), Quaternion.identity);
            queue.Enqueue(obj);
            obj.SetActive(false);
        }
    }

    public void InsertQueue(GameObject obj)
    {
        queue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject obj = queue.Dequeue();
        obj.SetActive(true);

        return obj;
    }


}
