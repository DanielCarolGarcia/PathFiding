using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    NavMeshAgent agent;

    public LayerMask layerMask;

    /// <summary>
    /// Establece el nivel de seguridad del jugador
    /// </summary>
    public LevelAccess.LevelSecurity levelSecurity;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Se procesa s�lo si se pulsa el bot�n izquierdo del rat�n
        if(Input.GetButton("Fire1"))
		{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Se lanza el rayo y se procesa s�lo si colisiona con algo
            if (Physics.Raycast(ray, out RaycastHit hit, 1000, layerMask, QueryTriggerInteraction.Ignore ))
            { 
                //Se procesa s�lo si la colisi�n es contra el suelo
                if(hit.collider.tag == "Floor")
				{
                    agent.SetDestination(hit.point);
				}
            }
		}
    }
}
