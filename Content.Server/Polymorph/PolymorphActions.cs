using Content.Shared.Actions;
using Robust.Shared.Prototypes;

namespace Content.Server.Polymorph;

public sealed partial class PolymorphActionEvent : InstantActionEvent
{
    /// <summary>
    ///     The polymorph proto id, containing all the information about
    ///     the specific polymorph.
    /// </summary>
    [DataField]
    public ProtoId<PolymorphPrototype>? ProtoId;

    public PolymorphActionEvent(ProtoId<PolymorphPrototype> protoId) : this()
    {
        ProtoId = protoId;
    }
}

public sealed partial class RevertPolymorphActionEvent : InstantActionEvent
{

}
