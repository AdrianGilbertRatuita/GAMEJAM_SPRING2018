using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Protagonist
{

    //
    private int _Health;
    private float _Speed;
    private float _OrbCount;

    //
    public int Health { get { return _Health; } set { _Health = value; } }
    public float Speed { get { return _Speed; }  set { _Speed = value; } }
    public float OrbCount { get { return _OrbCount; } set { _OrbCount = value; } }

    public Protagonist()
    {

        Health = 3;
        Speed = 3;
        OrbCount = 0;

    }

    public Protagonist(int H, float S)
    {

        Health = H;
        Speed = S;
        OrbCount = 0;

    }

}