using Chirper.Grains.Models;

namespace Chirper.Grains;

/// <summary>
/// Orleans observer interface IChirperSubscriber.
/// </summary>
public interface IChirperSubscriber : IGrainWithStringKey
{
    /// <summary>
    /// Notification that a new Chirp has been received.
    /// </summary>
    /// <param name="chirp">Chirp message entry.</param>
    Task NewChirpAsync(ChirperMessage chirp);
}
