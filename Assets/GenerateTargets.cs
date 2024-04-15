using UnityEngine;
using Unity.VisualScripting;
using Random = System.Random;

public class GenerateTargets : MonoBehaviour
{
    private Random random = new Random();
    public GameObject target;
    private GameObject targetOne;
    private GameObject targetTwo;
    private GameObject targetThree;
    private GameObject targetFour;

    void Start()
    {
        targetOne = Instantiate(target, new Vector3(random.Next(-9, 9), (float) random.Next(1, 3), 9f), Quaternion.Euler(0, 0, 0));
        targetTwo = Instantiate(target, new Vector3(random.Next(-9, 9), (float) random.Next(1, 3), -9f), Quaternion.Euler(0, 180, 0));
        targetThree = Instantiate(target, new Vector3(9f, (float) random.Next(1, 3), random.Next(-9, 9)), Quaternion.Euler(0, 90, 0));
        targetFour = Instantiate(target, new Vector3(-9f, (float) random.Next(1, 3), random.Next(-9, 9)), Quaternion.Euler(0, 270, 0));
    }

    void Update()
    {
        if (targetOne.IsDestroyed())
        {
            targetOne = Instantiate(target, new Vector3(random.Next(-9, 9), (float) random.Next(1, 3), 9f), Quaternion.Euler(0, 0, 0));
        }
        
        if (targetTwo.IsDestroyed())
        {
            targetTwo = Instantiate(target, new Vector3(random.Next(-9, 9), (float) random.Next(1, 3), -9f), Quaternion.Euler(0, 180, 0));
        }

        if (targetThree.IsDestroyed())
        {
            targetThree = Instantiate(target, new Vector3(9f, (float) random.Next(1, 3), random.Next(-9, 9)), Quaternion.Euler(0, 90, 0));
        }

        if (targetFour.IsDestroyed())
        {
            targetFour = Instantiate(target, new Vector3(-9f, (float) random.Next(1, 3), random.Next(-9, 9)), Quaternion.Euler(0, 270, 0));
        }
    }
}