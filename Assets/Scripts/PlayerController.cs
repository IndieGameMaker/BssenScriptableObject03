using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerDataSO playerData;
    [SerializeField] private float currHp;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currHp = playerData.maxHp;   
    }
    
}
