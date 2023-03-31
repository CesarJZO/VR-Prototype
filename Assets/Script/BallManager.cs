using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static BallManager Instance { get; private set; }
    [SerializeField] private Transform ballOriginPoint;

    [SerializeField] private GameObject ballPrefab;
    
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ballPrefab, ballOriginPoint.position, Quaternion.identity);
    }

    public void ResetBall(GameObject ball)
    {
        Destroy(ball);
        InstantiateBall();
    }

    private void InstantiateBall()
    {
        StartCoroutine(InstantiateBallCoroutine());
        {
            yield return new WaitForSeconds(3f);
            Instantiate(ballPrefab, ballOriginPoint.position, Quaternion.identity);
        }
    }
}
