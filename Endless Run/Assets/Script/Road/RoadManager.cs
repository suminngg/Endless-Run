using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    // ������ ���� ������Ʈ
    public GameObject road;

    public float speed = 1.0f;

    List<GameObject> roadList;

    // ��ġ �� ����
    Vector3 nextRoad = Vector3.zero;

    int firstRoad, lastRoad = 0;

    void Start()
    {
        roadList = new List<GameObject>();

        for(int i = 0; i < 3; i++)
        {
            roadList.Add(Instantiate(road, nextRoad, Quaternion.identity));
            nextRoad += Vector3.forward * 36f;
        }
    }

    void Update()
    {
        RoadMove();
    }

    void RoadMove()
    {
        // ����[0]  ����[1]  ����[2]
        for (int i = 0; i < roadList.Count; i++)
        {
            // ����Ʈ�� ����Ǿ� �ִ� ���� ��ü�� Translate�� �̿��ؼ� Vector3.back �������� �����ϰ� �̵���ŵ�ϴ�.
            roadList[i].transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        if (roadList[lastRoad].transform.position.z <= -36)
        {
            // -1 <---- 0 - 1
            firstRoad = lastRoad - 1;

            // -1 < 0
            if (firstRoad < 0)
            {
                //  -1 <----- (2) 3 - 1
                firstRoad = roadList.Count - 1;
            }

            // ���� [0] ��ġ  <---------- ���� [2] ��ġ 
            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 36;

            lastRoad++;

            if (lastRoad >= roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
