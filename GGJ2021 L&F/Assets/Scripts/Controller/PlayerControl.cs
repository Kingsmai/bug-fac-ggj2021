using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    private NavMeshAgent agent;
    private CharacterStats characterStats;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        characterStats = GetComponent<CharacterStats>();

    }

    public void MoveToTarget(Vector3 target)
    {
        agent.destination = target;
    }

    // Start is called before the first frame update
    void Start()
    {
        //向MouseManager注册方法
        //注册方法的定义格式必须和类中的事件格式相同（参数）
        MouseManager.Instance.OnMouseClicked += MoveToTarget;

        GameManager.Instance.RigisterPlayer(characterStats);
    }

}
