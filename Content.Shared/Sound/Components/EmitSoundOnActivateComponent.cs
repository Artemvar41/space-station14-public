using Robust.Shared.GameStates;

namespace Content.Shared.Sound.Components
{
    /// <summary>
    /// Simple sound emitter that emits sound on ActivateInWorld
    /// </summary>
    [RegisterComponent, NetworkedComponent]
    public sealed class EmitSoundOnActivateComponent : BaseEmitSoundComponent
    {
        /// <summary>
        ///     Whether or not to mark an interaction as handled after playing the sound. Useful if this component is
        ///     used to play sound for some other component with activation functionality.
        /// </summary>
        /// <remarks>
        ///     If false, you should be confident that the interaction will also be handled by some other system, as
        ///     otherwise this might enable sound spamming, as use-delays are only initiated if the interaction was
        ///     handled.
        /// </remarks>
        [DataField("handle")]
        public bool Handle = true;
    }
}
