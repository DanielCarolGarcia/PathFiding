using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerController : MonoBehaviour
{
    /// <summary>
    /// Establece el nivel de seguridad de la puerta
    /// </summary>
    public LevelAccess.LevelSecurity levelSecurity;

    /// <summary>
    /// Evento de entrada
    /// </summary>
    public UnityEvent @enter;

    /// <summary>
    /// Evento de salida
    /// </summary>
    public UnityEvent @exit;


	private void OnTriggerEnter(Collider other)
	{
        AgentController agent = other.GetComponent<AgentController>();

        if (agent != null)
        {
            if (agent.levelSecurity >= levelSecurity)
                @enter.Invoke();
        }

        
	}

	private void OnTriggerExit(Collider other)
	{
        AgentController agent = other.GetComponent<AgentController>();

        if (agent != null)
        {
            if (agent.levelSecurity >= levelSecurity)
                @exit.Invoke();
        }

        
    }

}
