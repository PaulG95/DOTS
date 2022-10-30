using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct BathtubPrefab : IComponentData
{
    public Entity Value;
}