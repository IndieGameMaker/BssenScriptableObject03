using System;
using UnityEngine;
using UnityEngine.UI;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private Image hpBar;
    [SerializeField] private HealthEventSO healthEventSO;
    
    // 이벤트 수신
    private void OnEnable()
    {
        healthEventSO.Subscribe(OnHpChanged);
    }

    // 이벤트 해지
    private void OnDisable()
    {
        healthEventSO.Unsubscribe(OnHpChanged);
    }

    // 이벤트 발생시 호출할 메서드
    private void OnHpChanged(float hp)
    {
        hpBar.fillAmount = hp / 100.0f;
    }
}
