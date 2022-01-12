using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Referencia la navmeshAgent
    /// </summary>
    NavMeshAgent agent;

    /// <summary>
    /// Ruta de puntos de destino
    /// </summary>
    public UnityStandardAssets.Utility.WaypointCircuit circuit;

    /// <summary>
    /// Punto actual del circuito
    /// </summary>
    int currentWaypoint;

    /// <summary>
    /// Umbral de distancia a la que se considera que el player ha llegado a su destino
    /// </summary>
    float precision = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //Asigan el componente
        agent = GetComponent<NavMeshAgent>();

        //Primer punto de la ruta
        currentWaypoint = 0;

        //Envía al agente a la posición de currentWaypoint
        agent.SetDestination(circuit.Waypoints[currentWaypoint].position);
    }

    // Update is called once per frame
    void Update()
    {
        //Consulta si se ha llegado al destino
        if(agent.remainingDistance < precision)
		{
            //Consulta si se ha llegado al último punto de la ruta
            if (++currentWaypoint >= circuit.Waypoints.Length)
                currentWaypoint = 0;
		}

        //Envía al agente a la posición de currentWaypoint
        agent.SetDestination(circuit.Waypoints[currentWaypoint].position);
    }
}
