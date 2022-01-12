using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileObstacle : MonoBehaviour
{
    /// <summary>
    /// Indica la trayectoria actual
    /// </summary>
    enum DisplacementType { pointA , pointB }
    DisplacementType displacementType;

    /// <summary>
    /// Puntos de origen y destino
    /// </summary>
    public Transform pointA, pointB;

    /// <summary>
    /// Parámetro de la interpolación
    /// </summary>
    float currenPosition;

    /// <summary>
    /// Velocidad de desplazamiento
    /// </summary>
    public float speed = 1;

    Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = transform;
        displacementType = DisplacementType.pointA;
        currenPosition = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (displacementType == DisplacementType.pointA)
        {
            currenPosition += Time.deltaTime * speed;
            tr.position = Vector3.Lerp(pointA.position, pointB.position, currenPosition);

            if (currenPosition >= 1)
            {
                currenPosition = 0;
                displacementType = DisplacementType.pointB;
            }
        }
        else if (displacementType == DisplacementType.pointB)
        {
            currenPosition += Time.deltaTime * speed;
            tr.position = Vector3.Lerp(pointB.position, pointA.position, currenPosition);

            if (currenPosition >= 1)
            {
                currenPosition = 0;
                displacementType = DisplacementType.pointA;
            }
        }
    }

}

