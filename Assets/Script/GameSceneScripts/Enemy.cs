using UnityEngine;

[CreateAssetMenu]
public class Enemy : ScriptableObject
{
    [Header("Enemy Info")] 
    [SerializeField] public string enemyName;
    [SerializeField] public int enemyCost;
    [SerializeField] public int enemyGoldAward;
    
    [Header("Enemy Stats")] 
    [SerializeField] public int health;
    [SerializeField] public float speed;
    [SerializeField] public int damage;
    [SerializeField] public int attackSpeed=1;
    [SerializeField] public float attackRange=1f;
    [SerializeField] public bool isRangeUnit;

    [SerializeField] public GameObject enemySkill;
    [SerializeField] public GameObject enemySkillEffect;
    [SerializeField] public float enemySkillSpeed=1f;
    
    [Space(10)]
    public GameObject enemyPrefab;
}