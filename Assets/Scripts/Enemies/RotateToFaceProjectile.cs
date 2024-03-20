using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToFaceProjectile : MonoBehaviour
{
    [SerializeField]
    public float rotationModifier;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Vector3 vectorToTarget = player.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = q;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Face() 
    {
        
        
    }
}
