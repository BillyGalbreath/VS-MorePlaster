using System.Diagnostics.CodeAnalysis;
using MorePlaster.BlockBehavior;
using Vintagestory.API.Common;

namespace MorePlaster;

[SuppressMessage("ReSharper", "UnusedType.Global")]
public class MorePlasterMod : ModSystem {
    public override void Start(ICoreAPI api) {
        api.RegisterBlockBehaviorClass("MorePlaster.BlockName", typeof(BlockBehaviorName));
    }
}
