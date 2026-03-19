using System;
using UnityEngine;

[CreateAssetMenu(fileName = "HealthEventSO", menuName = "MySO/HealthEventSO")]
public class HealthEventSO : ScriptableObject
{
    // 구독자를 저장할 리스너 
    private event Action<float> listeners;

    // 구독자를 추가 메서드
    public void Subscribe(Action<float> listener)
    {
        listeners += listener;
    }

    // 구독자를 제거 메서드
    public void Unsubscribe(Action<float> listener)
    {
        listeners -= listener;
    }

    // 이벤트 발생 요청 메서드 (발행자가 호출할 메서드)
    public void Raise(float hp)
    {
        listeners?.Invoke(hp);
    }
}
