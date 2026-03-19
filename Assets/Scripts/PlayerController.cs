using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, IDamageable
{
    [SerializeField] private PlayerDataSO playerData;
    [SerializeField] private float currHp;

    [SerializeField] private HealthEventSO healthEventSO;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currHp = playerData.maxHp;   
    }

    public void TakeDamage(float damage)
    {
        currHp -= damage;
        Debug.Log($"피격 데미지 {damage} , 현재 HP {currHp}");
        
        // 데미지 처리를 위한 이벤트 발생 요청
        healthEventSO.Raise(currHp);
    }

    public void Update()
    {
        // if (Input.GetMouseButtonDown(0))  //=> Legacy Input Manager
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            TakeDamage(10.0f);
        }
    }
    
}

public interface IDamageable
{
    void TakeDamage(float damage);
}
