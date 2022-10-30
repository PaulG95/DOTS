using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct RandomColor : IComponentData
{
    public Random Random;
    public float4 Min;
    public float4 Max;

    public float4 Color()
    {
        return Random.NextFloat4(Min, Max);
    }
}
