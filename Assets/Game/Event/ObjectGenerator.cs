using UnityEngine;
using System.Collections;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject main_object;
    private const float kDelay = 1.0F;
    private float object_delay_;
    private static int object_count = 0;
    private static int kMaxObject = 1;

    // Use this for initialization
    void Start()
    {
        object_delay_ = kDelay;

    }

    // Update is called once per frame
    void Update()
    {
        object_delay_ -= Time.deltaTime;
        if (object_delay_ <= 0)
        {
            if (object_count < kMaxObject)
            {
                Instantiate(main_object);
                float position_x = Random.Range(-10.0F, 10.0F);
                float position_z = Random.Range(-10.0F, 10.0F);
                while(position_x * position_x + position_z * position_z < 9)
                {
                    position_x = Random.Range(-10.0F, 10.0F);
                    position_z = Random.Range(-10.0F, 10.0F);
                }
                float position_y = Random.Range(1.0F,  Mathf.Sqrt(position_x * position_x + position_z * position_z) / Mathf.Sqrt(3.0F));
                main_object.transform.position = new Vector3(position_x, position_y,
                                                             position_z);
                ++object_count;
            }
            object_delay_ = kDelay;
        }
    }

    public static void decreseObjectCount()
    {
        object_count--;
    }
    
    public static void increaseMaxCount()
    {
        kMaxObject++;
    }

}