using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���ӸŴ����� �ν��Ͻ��� ��� ���������Դϴ�.
    // �� ���� ������ ���� �Ŵ��� �ν��Ͻ��� �� instance�� ��� ������Ʈ�� ������ �� �ֽ��ϴ�.
    public static GameManager instance;

    public bool condition = true;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

            // ���� ��ȯ�Ǵ��� �ı����� �ʰ� ������ �� �ֵ��� �����մϴ�.
            DontDestroyOnLoad(instance);
        }
        else
        {
            // ���� ���� �̵����� �� �� ������ ���� �Ŵ����� �����ϰ� �Ǹ� �ڱ� �ڽ��� �����մϴ�.
            Destroy(instance);
        }
    }

}
