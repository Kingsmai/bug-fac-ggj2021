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
        //��MouseManagerע�᷽��
        //ע�᷽���Ķ����ʽ��������е��¼���ʽ��ͬ��������
        MouseManager.Instance.OnMouseClicked += MoveToTarget;

        GameManager.Instance.RigisterPlayer(characterStats);
    }

}
