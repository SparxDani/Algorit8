using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : MonoBehaviour
{
    public List<NodeControl> ListAdjacentNodes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public NodeControl SelectNextNode()
    {
        int nodeSelected = Random.Range(0, ListAdjacentNodes.Count);
        return ListAdjacentNodes[nodeSelected];
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            NodeControl selected = SelectNextNode();
            other.GetComponent<Player>().ChangeMovePosition(selected.gameObject.transform.position);
        }
    }
}
