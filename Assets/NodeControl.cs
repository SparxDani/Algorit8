using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : MonoBehaviour
{
    public List<NodeControl> ListAdjacentNodes;
    public float energy = 5f;

    void Start()
    {

    }

    void Update()
    {

    }

    public NodeControl SelectNextNode(NodeControl previousNode)
    {
        List<NodeControl> validNodes = new List<NodeControl>();

        foreach (NodeControl node in ListAdjacentNodes)
        {
            if (node != previousNode)
            {
                validNodes.Add(node);
            }
        }

        if (validNodes.Count > 0)
        {
            int nodeSelected = Random.Range(0, validNodes.Count);
            return validNodes[nodeSelected];
        }

        return null;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            NodeControl previousNode = player.GetCurrentNode();
            NodeControl selected = SelectNextNode(previousNode);

            if (selected != null)
            {
                player.SetCurrentNode(this);
                other.GetComponent<Player>().ChangeMovePosition(selected.gameObject.transform.position);
                selected.DecreaseNodeEnergy(other.GetComponent<Player>().drainAmount);
            }
        }
    }

    public void DecreaseNodeEnergy(float amount)
    {
        energy -= amount;

        if (energy <= 0)
        {
            
        }
    }
}
