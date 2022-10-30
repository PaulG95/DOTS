using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

public partial class SpawnBathtub : SystemBase
{
    private Entity _bathtubPrefab;
    protected override void OnStartRunning()
    {
        _bathtubPrefab = GetSingleton<BathtubPrefab>().Value;
        var newGround = EntityManager.Instantiate(_bathtubPrefab);
    }
    protected override void OnUpdate()
    {
        // Assign values to local variables captured in your job here, so that it has
        // everything it needs to do its work when it runs later.
        // For example,
        //     float deltaTime = Time.DeltaTime;

        // This declares a new kind of job, which is a unit of work to do.
        // The job is declared as an Entities.ForEach with the target components as parameters,
        // meaning it will process all entities in the world that have both
        // Translation and Rotation components. Change it to process the component
        // types you want.
    }
}
