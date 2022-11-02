using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using Unity.Core;
using Unity.Rendering;
using Unity.Physics;
using Random=UnityEngine.Random;

public partial class SpawnSpherePrefab : SystemBase
{
    private Entity _spherePrefab;
    private float _timer = 0.01f;
    private float _timePassed = 0f;


    protected override void OnStartRunning()
    {
        _spherePrefab = GetSingleton<SpherePrefab>().Value;
        
    }
    protected override void OnUpdate()
    {
        _timePassed += Time.DeltaTime;
        if (_timePassed > _timer)
        {
            var newSphere = EntityManager.Instantiate(_spherePrefab);
            _timePassed = 0f;
            
            //Every Entitie gets a random angular & linear velocity value
             Entities
                 .ForEach((ref PhysicsVelocity velocity, in Translation position, in Rotation rotation) =>
                 {
                     float3 diff = position.Value;
                     float distSqrd = math.lengthsq(diff);
                     float randomLinear = Random.value;
                     float randomAngular = Random.value;
                     velocity.Linear += randomLinear * (diff / math.sqrt(distSqrd));
                     velocity.Angular += randomAngular * (diff / math.sqrt(distSqrd));
                 })
                 .Run();
        }

        // Ignore
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     var newCapsule = EntityManager.Instantiate(_spherePrefab);
        // }
        
    }

    // Color changing
    // private static float4 CalculateColor(float randomNumber, float3 position)
    // {
    //     var hue = (float) ((5 * randomNumber + position.x + (0.5f * position.y) + (0.5f * position.z)) % 50) / 50;
    //     var newCol = Color.HSVToRGB(hue, 1f, 1f);
    //     return new float4(newCol.r, newCol.g, newCol.b, newCol.a);
    // }


}
