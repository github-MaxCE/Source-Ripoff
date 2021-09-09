using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float verticalfov = -80;
    public float horizontalfov = 150;

    public GameObject walkpointobject;

    public NavMeshData navMeshData;
    private NavMeshAgent agent;

    private GameObject player;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //States
    public LayerMask playermask;
    public float sightRange = 33f;
    public float instantsightRange = 16.5f;
    public bool canhearplayerb;

    public bool canseeplayerb;


    private Vector3 playertransform;

    void Awake()
    {

        player = GameObject.Find("Player");
        agent = this.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playertransform = player.transform.position;
        if(isplayerinfov()) canseeplayer();
        else                canhearplayer();
    }

    private bool isplayerinfov()
    {
        Vector3 directionx = (new Vector3(playertransform.x, 0, playertransform.z) - new Vector3(transform.position.x, 0, transform.position.z)).normalized;
        Vector3 directiony = (new Vector3(0, playertransform.y, playertransform.z) - new Vector3(0, transform.position.y, transform.position.z)).normalized;
        return ((Vector3.Angle(transform.forward, directionx) < horizontalfov / 2) && (Vector3.Angle(transform.forward, directiony) < verticalfov / 2));
    }

    private void canseeplayer()
    {
        RaycastHit hitinfo;
        Vector3 directiontoplayer = playertransform - transform.position;
        Physics.Raycast(transform.position, directiontoplayer, out hitinfo, sightRange);
        Debug.DrawRay(transform.position, directiontoplayer, Color.black);
        if(hitinfo.transform.name == "Player")
            canseeplayerb = true;
        else
            canseeplayerb = false;
    }

    private void canhearplayer()
    {
        canhearplayerb = Physics.CheckSphere(transform.position, instantsightRange, playermask);
    }
}