using UnityEngine;

public class setResolution : MonoBehaviour
{
    private void Awake()
    {
        SetResolution(); // 초기에 게임 해상도 고정
    }

    /* 해상도 설정하는 함수 */
    public void SetResolution()
    {
        int setWidth = 1920; // 사용자 설정 너비
        int setHeight = 1080; // 사용자 설정 높이

        Screen.SetResolution(setWidth, setHeight, true);
    }
}