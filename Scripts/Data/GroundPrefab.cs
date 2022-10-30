using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct GroundPrefab : IComponentData
{
    public Entity Value;
}
