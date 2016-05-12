using UnityEngine;
using System.Collections;


public class ObjectRemover : MonoBehaviour, ICardboardGazeResponder
{
    public GameObject main_object;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnGazeEnter()
    {
        Debug.Log("Corsor in!");
        ObjectGenerator.decreseObjectCount();
        Destroy(gameObject, 0.2F);
        

    }

    public void OnGazeExit()
    {

    }

    public void OnGazeTrigger()
    {

    }
}
