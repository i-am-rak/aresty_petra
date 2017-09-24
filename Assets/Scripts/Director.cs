using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Director : MonoBehaviour {

    private List<GameObject> selectedUnits = new List<GameObject>();
    private GameObject selectedUnit;
    private float lastClickTime;
    public float catchTime = 0.25f;

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Agent" && Input.GetMouseButtonDown(0))
            {
                selectedUnit = hit.transform.gameObject;
                if (selectedUnits.Contains(selectedUnit))
                {
                    selectedUnit.SendMessage("Deselect", 1);
                    selectedUnits.Remove(selectedUnit);
                }
                else
                {
                    selectedUnit.SendMessage("Select", 1);
                    selectedUnits.Add(selectedUnit);
                }
            }
            else if (Input.GetMouseButtonDown(0))
            {
                if (Time.time - lastClickTime < catchTime)
                {
                    //double click
                    foreach (GameObject g in selectedUnits)
                    {
                        g.SendMessage("DoubleClick", 1);
                    }
                }
                lastClickTime = Time.time;
                foreach (GameObject g in selectedUnits)
                {
                    g.SendMessage("Destination", hit.point);
                }
            }
            /*
            if (hit.transform.tag == "Ground" && Input.GetMouseButtonDown(0))
            {
                foreach (GameObject g in selectedUnits)
                {
                    g.SendMessage("Deselect", 1);
                }
                selectedUnits.Clear();
            }
            */
        }
    }

}
