using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserBrush : BasicBrush
{
    //public GameObject drawingTool;
   public override void changeProperties(GameObject gameObject, BrushType currentBrush)
    {
        if (gameObject.CompareTag("Drawn Object"))
        {
            //drawingTool.GetComponent<DrawingTool>().electronicPenInstance.Remove(gameObject);
            Destroy(gameObject);
        }
        // Firstly, call this function in BasicBrush
        //base.changeProperties(gameObject);
        //base.brushName = "GravityBrush";

        //// Then, do something special to this brush
        //mutableObject.ChangeGravity();
    }
    public override Color getColor(BrushType currentBrush){
        return brushColor;
    }
}
