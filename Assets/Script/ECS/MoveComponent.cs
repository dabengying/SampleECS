﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[System.Serializable]
public struct Move :  IComponentData
{
    public float Speed;
    public float MinX;

    public Move(float x)
    {
        Speed = Random.Range(2f, 5f);
        MinX = x;
    }
}

public class MoveComponent : ComponentDataWrapper<Move> {}

