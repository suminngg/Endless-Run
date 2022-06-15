using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 게임매니저의 인스턴스를 담는 전역변수입니다.
    // 이 게임 내에서 게임 매니저 인스턴스는 이 instance에 담긴 오브젝트만 존재할 수 있습니다.
    public static GameManager instance;

    public bool condition = true;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

            // 씬이 전환되더라도 파괴되지 않고 유지할 수 있도록 설정합니다.
            DontDestroyOnLoad(instance);
        }
        else
        {
            // 만약 씬을 이동했을 때 그 씬에도 게임 매니저가 존재하게 되면 자기 자신을 삭제합니다.
            Destroy(instance);
        }
    }

}
