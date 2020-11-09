using UnityEngine;
using UnityEngine.AI;

/*Denis Plaksia*/
public class EnemyMonement : MonoBehaviour
{
    private float distance = 0f;
    private Player player;
    private NavMeshAgent meshAgent;
    public float radius = 10f;
    private Enemy enemy;

    private void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<Player>();
        enemy = GetComponent<Enemy>();
    }

    private void Update()
    {
        SetDistance();
        if (distance < radius)
        {
            meshAgent.SetDestination(player.transform.position);
            enemy.Attack();
        }
    }
    private void SetDistance() => distance = Vector3.Distance(player.transform.position, transform.position);

}
