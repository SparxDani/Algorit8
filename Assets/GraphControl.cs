using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphControl : MonoBehaviour
{
    public List<NodeControl> allListNodes;
    public NodeControl currentNodeControl;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player.ChangeMovePosition(currentNodeControl.gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
