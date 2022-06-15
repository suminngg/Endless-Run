using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    // 생성할 게임 오브젝트
    public GameObject road;

    public float speed = 1.0f;

    List<GameObject> roadList;

    // 위치 값 설정
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
        // 도로[0]  도로[1]  도로[2]
        for (int i = 0; i < roadList.Count; i++)
        {
            // 리스트에 저장되어 있는 도로 전체를 Translate를 이용해서 Vector3.back 방향으로 일정하게 이동시킵니다.
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

            // 도로 [0] 위치  <---------- 도로 [2] 위치 
            roadList[lastRoad].transform.position = roadList[firstRoad].transform.position + Vector3.forward * 36;

            lastRoad++;

            if (lastRoad >= roadList.Count)
            {
                lastRoad = 0;
            }
        }
    }
}
