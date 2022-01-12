using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    /// <summary>
    /// Establece el nivel de que otorga la llave
    /// </summary>
    public LevelAccess.LevelSecurity levelSecurity;


	private void OnTriggerEnter(Collider other)
	{
		AgentController agent = other.GetComponent<AgentController>();

		if(agent != null)
		{
			if(agent.levelSecurity < levelSecurity)
				agent.levelSecurity = levelSecurity;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		
	}

}
