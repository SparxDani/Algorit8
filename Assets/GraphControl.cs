using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphControl : MonoBehaviour
{
    public List<NodeControl> allListNodes;
    public NodeControl currentNodeControl;
    public Player player;

    void Start()
    {
        player.ChangeMovePosition(currentNodeControl.gameObject.transform.position);
        player.SetCurrentNode(currentNodeControl);
    }

    void Update()
    {

    }
}
