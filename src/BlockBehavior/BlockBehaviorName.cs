using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Datastructures;
using Vintagestory.API.MathTools;

namespace MorePlaster.BlockBehavior;

public class BlockBehaviorName : Vintagestory.API.Common.BlockBehavior {
    private string? _name;

    public BlockBehaviorName(Block block) : base(block) { }

    public override void Initialize(JsonObject properties) {
        base.Initialize(properties);

        _name = $"{Lang.Get(properties["material"].AsString())} {Lang.GetMatchingIfExists(properties["name"].AsString())}";
    }

    public override void GetHeldItemName(StringBuilder sb, ItemStack itemStack) {
        if (_name == null) {
            return;
        }

        sb.Clear().Append(_name);
    }

    public override void GetPlacedBlockName(StringBuilder sb, IWorldAccessor world, BlockPos pos) {
        if (_name == null) {
            return;
        }

        sb.Clear().Append(_name);
    }
}
