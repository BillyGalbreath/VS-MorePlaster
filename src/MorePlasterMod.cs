using MorePlaster.BlockBehavior;
using Vintagestory.API.Common;

namespace MorePlaster;

public class MorePlasterMod : ModSystem {
    public override void Start(ICoreAPI api) {
        api.RegisterBlockBehaviorClass("MorePlaster.BlockName", typeof(BlockBehaviorName));
    }

    public override void Dispose() { }
}
