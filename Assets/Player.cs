using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 vectorToMove;
    public float speed = 5f;
    public float energy = 5f;
    public float drainAmount = 1f;
    public float recoveryTime = 3f;
    private bool rest = false;
    private NodeControl currentNode;

    void Start()
    {

    }

    void Update()
    {
        if (!rest)
        {
            transform.position = Vector2.MoveTowards(transform.position, vectorToMove, speed * Time.deltaTime);
        }
    }

    public void ChangeMovePosition(Vector2 destination)
    {
        if (!rest)
        {
            vectorToMove = destination;
            DecreaseEnergy();
        }
    }

    private void DecreaseEnergy()
    {
        energy -= drainAmount;

        if (energy <= 0)
        {
            StartCoroutine(Rest());
        }
    }

    private IEnumerator Rest()
    {
        rest = true;
        yield return new WaitForSeconds(recoveryTime);
        energy = 5f;
        rest = false;
    }

    public void SetCurrentNode(NodeControl node)
    {
        currentNode = node;
    }

    public NodeControl GetCurrentNode()
    {
        return currentNode;
    }
}
