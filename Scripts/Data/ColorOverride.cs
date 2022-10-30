using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Rendering;

[GenerateAuthoringComponent]
[MaterialProperty("SphereColor", MaterialPropertyFormat.Float4)]
public struct ColorOverride : IComponentData
{
    public float4 Value;
}
