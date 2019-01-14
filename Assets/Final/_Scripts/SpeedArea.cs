using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
public enum Direction
{
    Left, Right

}

public class SpeedArea : MonoBehaviour
{
=======
public enum Direction
{
    Left, Right

}

public class SpeedArea : MonoBehaviour
{
>>>>>>> 2019WeRock
    public Direction direction;


    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        if (direction == Direction.Left)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                child.RotateAround(child.position, Vector3.up, 180);

            }
=======
        if (direction == Direction.Left)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                child.RotateAround(child.position, Vector3.up, 180);

            }
>>>>>>> 2019WeRock
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
