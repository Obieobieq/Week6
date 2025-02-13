using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Week6 : MonoBehaviour
{

    [SerializeField] private int sizeOfForest;
    [SerializeField] private int stones;
    [SerializeField] GameObject tree;
    [SerializeField] GameObject rock;

    private float offsetBaseZ = 1f;
    private float offsetBaseX = 1f;


    int CubesBase1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        Pyramid();
        GenerateThePlane();
        Forest();
    }

    private void Forest()
    {
        GameObject forest = new GameObject("ForestParent");
        for (int i =0; i < 15; i++)
        {
            
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            
            cylinder.transform.localScale = new Vector3(Random.Range(.2f, 3f), Random.Range(1f, 3f), Random.Range(.2f, 3f));
            cylinder.transform.localPosition = new Vector3(Random.Range(-6f, -2f), 0, Random.Range(-5f, 5f));
            cylinder.GetComponent<MeshRenderer>().material.color = Color.green;
            cylinder.transform.parent = forest.transform;
        }

        
    }

    private void GenerateThePlane()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.localScale = new Vector3(5, 1, 5);
        plane.transform.localPosition = new Vector3(0, -.5f, 0);
        plane.GetComponent<MeshRenderer>().material.color = Color.red;


    }
    void Pyramid()
    {

        GameObject cubeParent = new GameObject("CubeParent");
        // making base level 
        for (CubesBase1 = 0; CubesBase1 < 5; CubesBase1++)
        {
            GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube1.transform.localScale = new Vector3(.9f, 1, .9f);
            cube1.transform.localPosition = new Vector3(0, 0, offsetBaseZ);
            offsetBaseZ++;
            cube1.GetComponent<MeshRenderer>().material.color = Color.blue;
            cube1.transform.parent = cubeParent.transform;

        }
       

        offsetBaseZ = 1;
        for (CubesBase1 = 0; CubesBase1 < 4; CubesBase1++)
        {
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localScale = new Vector3(.9f, 1, .9f);
            cube2.transform.localPosition = new Vector3(offsetBaseX, 0, offsetBaseZ);
            offsetBaseX++;
            cube2.GetComponent<MeshRenderer>().material.color = Color.blue;
            cube2.transform.parent = cubeParent.transform;

            if (CubesBase1 == 3 && offsetBaseZ < 5)
            {
                CubesBase1 = -1;
                offsetBaseZ++;
                offsetBaseX = 1;
            }

        }

        //second level
        offsetBaseZ = 1.5f;
        offsetBaseX = 0.5f;
        for (CubesBase1 = 0; CubesBase1 < 4; CubesBase1++)
        {
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localScale = new Vector3(.9f, 1, .9f);
            cube2.transform.localPosition = new Vector3(offsetBaseX, 1, offsetBaseZ);
            offsetBaseX++;
            cube2.GetComponent<MeshRenderer>().material.color = Color.yellow;
            cube2.transform.parent = cubeParent.transform;

            if (CubesBase1 == 3 && offsetBaseZ < 4f)
            {
                CubesBase1 = -1;
                offsetBaseZ++;
                offsetBaseX = .5f;
            }

        }

        // third level
        offsetBaseZ = 2f;
        offsetBaseX = 1f;
        for (CubesBase1 = 0; CubesBase1 < 3; CubesBase1++)
        {
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localScale = new Vector3(.9f, 1, .9f);
            cube2.transform.localPosition = new Vector3(offsetBaseX, 2, offsetBaseZ);
            offsetBaseX++;
            cube2.GetComponent<MeshRenderer>().material.color = Color.magenta;
            cube2.transform.parent = cubeParent.transform;

            if (CubesBase1 == 2 && offsetBaseZ < 3.5f)
            {
                CubesBase1 = -1;
                offsetBaseZ++;
                offsetBaseX = 1f;
            }

        }

        /// four 
        offsetBaseZ = 2.5f;
        offsetBaseX = 1.5f;
        for (CubesBase1 = 0; CubesBase1 < 2; CubesBase1++)
        {
            GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localScale = new Vector3(.9f, 1, .9f);
            cube2.transform.localPosition = new Vector3(offsetBaseX, 3, offsetBaseZ);
            offsetBaseX++;
            cube2.GetComponent<MeshRenderer>().material.color = Color.cyan;
            cube2.transform.parent = cubeParent.transform;

            if (CubesBase1 == 1 && offsetBaseZ < 3f)
            {
                CubesBase1 = -1;
                offsetBaseZ++;
                offsetBaseX = 1.5f;
            }

        }
        // last
        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.transform.localScale = new Vector3(.9f, 1, .9f);
        cube3.transform.localPosition = new Vector3(2, 4, 3);


        cube3.transform.parent = cubeParent.transform;
    }


}
