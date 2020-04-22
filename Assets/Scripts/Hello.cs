using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hello : MonoBehaviour
{

    public Slider sliderPosition, sliderScale;
    GameObject cube, sphere, capsule, cylinder;


    private Mode mode = Mode.None;

    enum Mode
    {
        Cube, Sphere, Capsule, Cylinder, None
    }

    private void Start()
    {
        InitGameObject();
        InitUIViews();
    }

    private void InitUIViews()
    {
        sliderScale = GameObject.Find("SliderScale").GetComponent<Slider>();
        sliderPosition = GameObject.Find("SliderPosition").GetComponent<Slider>();
    }

    private void InitGameObject()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(400, 270f, 103);
        cube.transform.localScale = new Vector3(100, 100, 1);
        cube.SetActive(false);

        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(400, 270f, 103);
        sphere.transform.localScale = new Vector3(100, 100, 1);
        sphere.SetActive(false);

        capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = new Vector3(400, 270f, 103);
        capsule.transform.localScale = new Vector3(100, 100, 1);
        capsule.SetActive(false);

        cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = new Vector3(400, 270f, 103);
        cylinder.transform.localScale = new Vector3(100, 100, 1);
        cylinder.SetActive(false);
    }

    public void onPressCreateCube()
    {
        mode = Mode.Cube;
    }

    public void onPressCreateSphere()
    {
        mode = Mode.Sphere;
    }

    public void onPressCreateCylinder()
    {
        mode = Mode.Cylinder;
    }

    public void onPressCreateCapsule()
    {
        mode = Mode.Capsule;
    }

    private void Update()
    {
        Vector3 newVector = new Vector3(100 + sliderScale.value * 100, 100 + sliderScale.value * 100, 1);
        Vector3 newVectorPosition = new Vector3(400 + sliderPosition.value * 100, 270 + sliderPosition.value * 150, 103);

        switch (mode)
        {
            case Mode.Cube:
                cube.SetActive(true);
                sphere.SetActive(false);
                cylinder.SetActive(false);
                capsule.SetActive(false);
                cube.transform.localScale = newVector;
                cube.transform.localPosition = newVectorPosition;
                break;
            case Mode.Sphere:
                sphere.SetActive(true);
                cube.SetActive(false);
                cylinder.SetActive(false);
                capsule.SetActive(false);
                sphere.transform.localScale = newVector;
                break;

            case Mode.Cylinder:
                cylinder.SetActive(true);
                sphere.SetActive(false);
                cube.SetActive(false);
                capsule.SetActive(false);
                cylinder.transform.localScale = newVector;
                break;

            case Mode.Capsule:
                capsule.SetActive(true);
                cylinder.SetActive(false);
                sphere.SetActive(false);
                cube.SetActive(false);
                capsule.transform.localScale = newVector;
                break;

        }
    }

}
