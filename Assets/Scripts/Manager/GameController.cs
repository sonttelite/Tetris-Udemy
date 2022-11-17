using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Board m_gameBoard;

    public Spawner m_spawner;

    // Start is called before the first frame update
    void Start()
    {
        //m_gameBoard = GameObject.FindWithTag("Board").GetComponent<Board>();
        GameObject test = GameObject.FindWithTag("Board");
        m_gameBoard = test.GetComponent<Board>();
        m_spawner = GameObject.FindWithTag("Spawner").GetComponent<Spawner>();

        if (m_spawner)
        {
            m_spawner.transform.position = Vectorf.Round(m_spawner.transform.position);
        }    
        else
        {
            Debug.Log("Warning!");
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
