using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBlock
{
    private int type;
    private int x;
    private int y;

    public int getType()
    {
        return type;
    }
    public void setTyep(int typeInput)
    {
        type = typeInput;
    }

    public int getX()
    {
        return x;
    }
    public void setX(int xInput)
    {
        x = xInput;
    }

    public int getY()
    {
        return y;
    }
    public void setY(int yInput)
    {
        y = yInput;
    }
}
