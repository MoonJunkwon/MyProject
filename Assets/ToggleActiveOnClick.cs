using UnityEngine;
using UnityEngine.UI;

public class ToggleActiveOnClick : MonoBehaviour
{
    public GameObject targetObject; // 활성화 및 비활성화할 대상 오브젝트

    private bool isActive = false; // 초기 상태는 활성화 상태로 설정

    // 버튼 클릭 이벤트 핸들러
    public void ToggleActive()
    {
        if (targetObject != null)
        {
            isActive = !isActive; // 현재 상태를 반전

            // 대상 오브젝트의 활성화 상태를 업데이트
            targetObject.SetActive(isActive);
        }
    }
}