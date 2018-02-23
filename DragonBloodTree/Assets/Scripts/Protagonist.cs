using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Protagonist
{

    //
    private int _Health;
    private float _Speed;
    private ICollectible Orbs;

    //
    public int Health { get { return _Health; } set { _Health = value; } }
    public float Speed { get { return _Speed; }  set { _Speed = value; } }

    public Protagonist()
    {

        Health = 3;
        Speed = 3;

    }

    public Protagonist(int H, float S)
    {

        Health = H;
        Speed = S;

    }

}