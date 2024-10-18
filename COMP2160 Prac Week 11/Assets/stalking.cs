using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stalking : MonoBehaviour
{
    [SerializeField] private Transform stalkee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(stalkee.position.x, 10, stalkee.position.z);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 0.5f);

    }
}
