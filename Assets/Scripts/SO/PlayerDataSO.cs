using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDataSO", menuName = "MySO/PlayerDataSO")]
public class PlayerDataSO : ScriptableObject
{
    public float maxHp = 100f;
    public float defaultSpeed = 10f;
}
